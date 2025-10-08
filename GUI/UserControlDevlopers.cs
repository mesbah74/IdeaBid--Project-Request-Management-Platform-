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
    public partial class UserControlDevlopers : UserControl
    {

        private int? selectedDevId = null;
        private string oldDevUsername = null;
        private string oldDevEmail = null;

        public UserControlDevlopers()
        {
            InitializeComponent();

            textBoxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    buttonSearch.PerformClick();
                    e.SuppressKeyPress = true;
                }
            };

            dgvTable.MultiSelect = false;

            dgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvTable.SelectionChanged += dgvDev_SelectionChanged;

            buttonDelete.Enabled = false;

            //textBoxAdmin.Text = FormLogin.LoggedInAdminUsername;
            //textBoxAdmin.ReadOnly = true;
        }

        public void LoadDevelopers(string search = null)
        {
            string sql = @"SELECT DevId, DevUsername, DevFullName, DevEmail, DevPassword, AdminUsername FROM DevInfo";

            SqlParameter[] pars = null;

            if (!string.IsNullOrWhiteSpace(search))
            {
                sql += @" WHERE 
                    CAST(DevId AS NVARCHAR) LIKE @s OR
                    DevUsername LIKE @s OR
                    DevFullName LIKE @s OR
                    DevEmail LIKE @s";

                pars = new SqlParameter[]
                {
                    new SqlParameter("@s", $"%{search}%")
                };
            }

            sql += " ORDER BY DevId ASC";

            DataTable dt = DataBase.GetDataTable(sql, pars);

            dgvTable.AutoGenerateColumns = false; 
            dgvTable.DataSource = dt;

            ClearFields();
        }


        private void dgvDev_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count == 0)
            {
                selectedDevId = null;
                oldDevUsername = null;
                oldDevEmail = null;
                buttonDelete.Enabled = false;
                return;
            }

            DataGridViewRow row = dgvTable.SelectedRows[0];

            var idCell = row.Cells["dgvDevId"];
            if (idCell == null || idCell.Value == null || !int.TryParse(idCell.Value.ToString(), out int id))
            {
                selectedDevId = null;
                buttonDelete.Enabled = false;
                return;
            }

            selectedDevId = id;
            oldDevUsername = row.Cells["dgvDevUsername"].Value?.ToString();
            oldDevEmail = row.Cells["dgvDevEmail"].Value?.ToString();

            textBoxDevId.Text = id.ToString();
            textBoxDevUsername.Text = oldDevUsername;
            textBoxFullName.Text = row.Cells["dgvDevFullName"].Value?.ToString();
            textBoxEmail.Text = oldDevEmail;
            textBoxDevPassword.Text = row.Cells["dgvDevPassword"].Value?.ToString();
            textBoxAdmin.Text = row.Cells["dgvAdminUsername"].Value?.ToString();


            buttonDelete.Enabled = true;
        }

        private void ClearFields()
        {
            textBoxDevId.Text = "";
            textBoxDevUsername.Text = "";
            textBoxFullName.Text = "";
            textBoxEmail.Text = "";
            textBoxDevPassword.Text = "";
            textBoxAdmin.Text = "";

            dgvTable.ClearSelection();
            if (dgvTable.CurrentCell != null)
                dgvTable.CurrentCell = null;

            selectedDevId = null;
            oldDevUsername = null;
            oldDevEmail = null;

            buttonDelete.Enabled = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            LoadDevelopers();
            textBoxSearch.Text = "";
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            ClearFields();
            textBoxDevUsername.Focus();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            string devUsername = textBoxDevUsername.Text.Trim();
            string devFullName = textBoxFullName.Text.Trim();
            string devEmail = textBoxEmail.Text.Trim();
            string devPassword = textBoxDevPassword.Text.Trim();
            string adminUsername = textBoxAdmin.Text.Trim();

            if (FormLogin.LoggedInAdminUsername == null ||
                !adminUsername.Equals(FormLogin.LoggedInAdminUsername, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Admin username does not match the logged-in admin!",
                                "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(devUsername) || string.IsNullOrWhiteSpace(devFullName) ||
                string.IsNullOrWhiteSpace(devEmail) || string.IsNullOrWhiteSpace(devPassword))
            {
                MessageBox.Show("All fields are required!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            if (selectedDevId == null)
            {
         
                string checkSql = @"SELECT COUNT(*) FROM DevInfo WHERE DevUsername=@u OR DevEmail=@e";
                var parsCheck = DataBase.CreateParameters(("@u", devUsername), ("@e", devEmail));
                int count = Convert.ToInt32(DataBase.ExecuteScalar(checkSql, parsCheck));

                if (count > 0)
                {
                    MessageBox.Show("Username or Email already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertSql = @"INSERT INTO DevInfo (DevUsername, DevFullName, DevEmail, DevPassword, AdminUsername) 
                             VALUES (@u, @f, @e, @p, @a)";
                var pars = DataBase.CreateParameters(
                    ("@u", devUsername), ("@f", devFullName), ("@e", devEmail), ("@p", devPassword), ("@a", adminUsername)
                );

                if (DataBase.ExecuteNonQuery(insertSql, pars) > 0)
                {
                    MessageBox.Show("Developer added successfully!");
                    LoadDevelopers();
                }
            }
            else
            {
              
                if (devUsername == oldDevUsername &&
                    devEmail == oldDevEmail)
                {
                    MessageBox.Show("Please update something before saving!",
                                    "No Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            

                string updateSql = @"UPDATE DevInfo 
                             SET DevUsername=@u, DevFullName=@f, DevEmail=@e, DevPassword=@p, AdminUsername=@a
                             WHERE DevId=@id";
                var pars = DataBase.CreateParameters(
                    ("@u", devUsername), ("@f", devFullName), ("@e", devEmail),
                    ("@p", devPassword), ("@a", adminUsername), ("@id", selectedDevId)
                );

                if (DataBase.ExecuteNonQuery(updateSql, pars) > 0)
                {
                    MessageBox.Show("Developer updated successfully!");
                    LoadDevelopers();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (selectedDevId == null)
            {
                MessageBox.Show("Please select a developer to delete.", "No selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this developer? This action cannot be undone.",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            string sql = "DELETE FROM DevInfo WHERE DevId=@id";
            var pars = DataBase.CreateParameters(("@id", selectedDevId));
            int rows = DataBase.ExecuteNonQuery(sql, pars);

            if (rows > 0)
            {
                LoadDevelopers();
            }
            else
            {
                MessageBox.Show("Delete failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadDevelopers();
            }
            else
            {
               
                LoadDevelopers(searchText);
            }
        }
    }
}
