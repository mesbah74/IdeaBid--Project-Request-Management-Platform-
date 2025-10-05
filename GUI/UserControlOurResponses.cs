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
    public partial class UserControlOurResponses : UserControl
    {
        public UserControlOurResponses()
        {
            InitializeComponent();
        }

        public void LoadOurResponses(string search = null)
        {
            string sql = @"
                SELECT 
                    pr.ResponseID,
                    pr.RequestID,
                    pr.DevID,
                    pr.AdminID,
                    pr.ProposalDate,
                    pr.ProposalAmount,
                    pr.Deadline,
                    pr.Feedback,
                    pr.StatusID,        -- keep the ID for reference if needed
                    s.StatusName        -- show name in grid
                FROM ProjectResponse pr
                LEFT JOIN ProjectStatus s ON pr.StatusID = s.StatusID
                WHERE 1=1
            ";

            SqlParameter[] pars;

            if (!string.IsNullOrWhiteSpace(search))
            {
                sql += @"
                        AND (
                            CAST(pr.RequestID AS NVARCHAR(50)) LIKE @s
                            OR CAST(pr.ResponseID AS NVARCHAR(50)) LIKE @s
                        )";

                pars = DataBase.CreateParameters(
                    ("@s", "%" + search + "%")
                );
            }
            else
            {
                pars = new SqlParameter[0]; // no parameters
            }

            sql += " ORDER BY pr.ResponseID DESC";

            DataTable dt = DataBase.GetDataTable(sql, pars);

            metroGridDisplayResponses.AutoGenerateColumns = false;
            metroGridDisplayResponses.DataSource = dt;
            metroGridDisplayResponses.ClearSelection();
        }




        private void UserControlOurResponses_Load(object sender, EventArgs e)
        {
            this.LoadOurResponses();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.LoadOurResponses();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.LoadOurResponses(textBoxSearch.Text.Trim());
        }

        private void metroGridDisplayResponses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            metroGridDisplayResponses.ClearSelection();
            metroGridDisplayResponses.CurrentCell = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (metroGridDisplayResponses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Response first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int requestId = Convert.ToInt32(metroGridDisplayResponses.SelectedRows[0].Cells["dgvRequestID"].Value);

            using (var form = new FormNewResponed(FormControlPortal.LoggedInUser, FormControlPortal.Role, requestId))
            {
                if (form.ShowDialog() == DialogResult.OK) 
                {
                    LoadOurResponses();
                }
            }
        }





    }
}
