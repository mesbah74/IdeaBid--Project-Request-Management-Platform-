using IdeaBid__Project_Request___Management_Platform.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    public partial class FormViewResponse : Form
    {
        private int requestId;
        public FormViewResponse(int requestId)
        {
            InitializeComponent();
            this.requestId = requestId;
        }

        private void FormViewResponse_Load(object sender, EventArgs e)
        {
            LoadResponseData();
        }

        private void LoadResponseData()
        {
            //    string sql = @"
            //SELECT 
            //    pr.RequestID,
            //    pr.ProposalDate,
            //    pr.ProposalAmount,
            //    pr.Deadline,
            //    pr.Feedback,
            //    s.StatusName,
            //    ISNULL(d.DevFullName, a.AdminFullName) AS ResponderName
            //FROM ProjectResponse pr
            //LEFT JOIN DevInfo d ON pr.DevID = d.DevID
            //LEFT JOIN AdminInfo a ON pr.AdminID = a.AdminID
            //LEFT JOIN ProjectStatus s ON pr.StatusID = s.StatusID
            //WHERE pr.RequestID = @RequestID";

            //    var parameters = DataBase.CreateParameters(("@RequestID", requestId));
            //    DataTable dt = DataBase.GetDataTable(sql, parameters);

            //    if (dt.Rows.Count > 0)
            //    {
            //        DataRow row = dt.Rows[0];

            //        // RequestID already passed, just show
            //        labelShowID.Text = requestId.ToString();

            //        // Other values
            //        labelShowResponderName.Text = row["ResponderName"].ToString();
            //        Responsedate.Text = Convert.ToDateTime(row["ProposalDate"]).ToString("yyyy-MM-dd");
            //        label1.Text = row["ProposalAmount"].ToString();
            //        labelExpectedDeadline.Text = Convert.ToDateTime(row["Deadline"]).ToString("yyyy-MM-dd");
            //        labelStatus.Text = row["StatusName"].ToString();
            //        richTextBox1.Text = row["Feedback"].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No response found for this Request ID.",
            //                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            // First check the status of the request
            string checkSql = "SELECT StatusID FROM ProjectRequest WHERE RequestID = @RequestID";
            var checkPars = DataBase.CreateParameters(("@RequestID", requestId));
            object statusObj = DataBase.ExecuteScalar(checkSql, checkPars);

            int statusId = statusObj != null ? Convert.ToInt32(statusObj) : 0;

            // If still Open (1) → skip response and show placeholders
            if (statusId == 1)
            {
                labelShowID.Text = requestId.ToString();
                labelShowResponderName.Text = "No responder [N/A]";
                Responsedate.Text = "Not provided";
                label1.Text = "Not set";
                labelExpectedDeadline.Text = "Not provided";
                labelStatus.Text = "Open";
                richTextBox1.Text = "No feedback provided.";
                return;
            }


            string sql = @"
                SELECT TOP 1
                    pr.ResponseID,
                    pr.RequestID,
                    pr.ProposalDate,
                    pr.ProposalAmount,
                    pr.Deadline,
                    pr.Feedback,
                    s.StatusName,
                    COALESCE(d.DevFullName, a.AdminFullName) AS ResponderName,
                    CASE 
                        WHEN pr.DevID IS NOT NULL THEN 'Dev'
                        WHEN pr.AdminID IS NOT NULL THEN 'Admin'
                        ELSE 'Unknown'
                    END AS ResponderRole
                FROM ProjectResponse pr
                LEFT JOIN DevInfo d ON pr.DevID = d.DevID
                LEFT JOIN AdminInfo a ON pr.AdminID = a.AdminID
                LEFT JOIN ProjectStatus s ON pr.StatusID = s.StatusID
                WHERE pr.RequestID = @RequestID
                ORDER BY pr.ResponseID DESC; -- newest response first
            ";

            var pars = DataBase.CreateParameters(("@RequestID", requestId));
            DataTable dt = DataBase.GetDataTable(sql, pars);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No response found for this Request ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear UI or set defaults:
                labelShowID.Text = requestId.ToString();
                labelShowResponderName.Text = "No responder [N/A]";
                Responsedate.Text = "Not provided";
                label1.Text = "Not set";
                labelExpectedDeadline.Text = "Not provided";
                richTextBox1.Text = "No feedback provided.";
                return;
            }

            DataRow row = dt.Rows[0];

            labelShowID.Text = requestId.ToString();

            string rawName = row["ResponderName"] == DBNull.Value ? "" : row["ResponderName"].ToString().Trim();
            string role = row["ResponderRole"] == DBNull.Value ? "Unknown" : row["ResponderRole"].ToString();

            if (string.IsNullOrWhiteSpace(rawName))
            {
                if (role == "Admin") rawName = "Administrator";
                else if (role == "Dev") rawName = "Developer";
                else rawName = "Unknown";
            }

            labelShowResponderName.Text = $"{rawName} [{(role == "Dev" ? "Dev" : role == "Admin" ? "Admin" : "Unknown")}]";

            if (row["ProposalDate"] == DBNull.Value)
                Responsedate.Text = "Not provided";
            else
                Responsedate.Text = Convert.ToDateTime(row["ProposalDate"]).ToString("yyyy-MM-dd");

            if (row["ProposalAmount"] == DBNull.Value)
                label1.Text = "Not set";
            else
            {
                if (decimal.TryParse(row["ProposalAmount"].ToString(), out decimal amt))
                    label1.Text = amt.ToString("N2"); 
                else
                    label1.Text = row["ProposalAmount"].ToString();
            }

            if (row["Deadline"] == DBNull.Value)
                labelExpectedDeadline.Text = "Not provided";
            else
                labelExpectedDeadline.Text = Convert.ToDateTime(row["Deadline"]).ToString("yyyy-MM-dd");

            string statusName = row["StatusName"] == DBNull.Value ? "" : row["StatusName"].ToString();
            labelStatus.Text = string.IsNullOrWhiteSpace(statusName) ? "Not set" : statusName;

            string feedback = row["Feedback"] == DBNull.Value ? "" : row["Feedback"].ToString().Trim();
            richTextBox1.Text = string.IsNullOrWhiteSpace(feedback) ? "No feedback provided." : feedback;
        }

        private void buttonModifyRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            NewProjectForm editForm = new NewProjectForm(FormUserDashboard.CurrentUserId, requestId);
            editForm.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.LoadResponseData();

        }

        private void FormViewResponse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }


    }
}








