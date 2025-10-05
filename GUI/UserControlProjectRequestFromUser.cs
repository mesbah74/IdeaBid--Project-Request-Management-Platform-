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
    public partial class UserControlProjectRequestFromUser : UserControlTest
    {
        public int currentUserId;
        public UserControlProjectRequestFromUser()
        {
            InitializeComponent();
        }

        public void LoadRequests(int userId, string search = null)
        {
            this.currentUserId = userId;
            string sql = @"
        SELECT
            pr.RequestID,
            c.CategoryName   AS Category,
            pr.Languages     AS Languages,   -- now coming directly from ProjectRequest
            pr.Title,
            pr.Description,
            pr.BudgetOffered AS Budget,
            pr.Deadline      AS Deadline,
            s.StatusName     AS Status,
            pr.PostedDate    AS PostedDate
        FROM ProjectRequest pr
        JOIN Category c ON pr.CategoryID = c.CategoryID
        JOIN ProjectStatus s ON pr.StatusID = s.StatusID
        WHERE pr.UserID = @userId
    ";

            SqlParameter[] pars;
            if (!string.IsNullOrWhiteSpace(search))
            {
                sql += @"
            AND (
                CAST(pr.RequestID AS NVARCHAR(50)) LIKE @s
                OR pr.Title LIKE @s
                OR c.CategoryName LIKE @s
            )";

                pars = DataBase.CreateParameters(
                    ("@userId", userId),
                    ("@s", $"%{search}%")
                );
            }
            else
            {
                pars = DataBase.CreateParameters(("@userId", userId));
            }
            sql += " ORDER BY pr.RequestID DESC";

            DataTable dt = DataBase.GetDataTable(sql, pars);

            metroGridForRequestProject.AutoGenerateColumns = false;
            metroGridForRequestProject.DataSource = dt;
            metroGridForRequestProject.ClearSelection();
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            LoadRequests(currentUserId);

        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            LoadRequests(currentUserId, textBoxSearch.Text.Trim());
        }

        private void buttonNewRequest_Click(object sender, EventArgs e)
        {

            using (var newProjectForm = new NewProjectForm(FormUserDashboard.CurrentUserId))
            {
                if (newProjectForm.ShowDialog() == DialogResult.OK)
                {
                    LoadRequests(currentUserId);
                }
            }
        }

        private void metroGridForRequestProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int requestId = Convert.ToInt32(metroGridForRequestProject.Rows[e.RowIndex].Cells["dgvRequestId"].Value);
                NewProjectForm editForm = new NewProjectForm(currentUserId, requestId);
                editForm.ShowDialog();
                LoadRequests(currentUserId);
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (metroGridForRequestProject.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the RequestID of the selected row
            int requestId = Convert.ToInt32(metroGridForRequestProject.SelectedRows[0].Cells["dgvRequestId"].Value);

            // Confirm deletion
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete request ID {requestId}?",
                                              "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            try
            {
                // Delete from database
                string sql = "DELETE FROM ProjectRequest WHERE RequestID = @RequestID";
                var parameters = DataBase.CreateParameters(("RequestID", requestId));
                int affected = DataBase.ExecuteNonQuery(sql, parameters);

                if (affected > 0)
                {
                    LoadRequests(currentUserId);
                    MessageBox.Show("Request deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh grid
                    
                }
                else
                {
                    MessageBox.Show("Failed to delete request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViewResponse_Click(object sender, EventArgs e)
        {
            if (metroGridForRequestProject.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request to view its response.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requestId = Convert.ToInt32(
                metroGridForRequestProject.SelectedRows[0].Cells["dgvRequestId"].Value
            );



            using (var formViewResponse = new FormViewResponse(requestId))
            {
                if (formViewResponse.ShowDialog() == DialogResult.OK)
                {
                    LoadRequests(currentUserId);
                }
            }
        }



    }
}
