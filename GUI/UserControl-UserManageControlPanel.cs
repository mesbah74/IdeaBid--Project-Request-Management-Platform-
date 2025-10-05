using IdeaBid__Project_Request___Management_Platform.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IdeaBid__Project_Request___Management_Platform
{
    public partial class UserControlUserManageControlPanel : UserControl
    {
        private int? selectedUserId = null;
        private string oldUsername = null;
        private string oldEmail = null;
        public UserControlUserManageControlPanel()
        {
            InitializeComponent();

            dgvTable.MultiSelect = false;
            dgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvTable.SelectionChanged += dgvTable_SelectionChanged;

            buttonDeleteUser.Enabled = false;

        }

        public void LoadUsers(string search = null)
        {
            string sql = @"SELECT ID, UserName, FullName, Email, UserType, Password, CreatedDate
               FROM UserInfo";

            SqlParameter[] pars = null;

            if (!string.IsNullOrWhiteSpace(search))
            {
                sql += @" WHERE 
                    CAST(ID AS NVARCHAR) LIKE @s OR 
                    UserName LIKE @s OR 
                    FullName LIKE @s OR 
                    Email LIKE @s";

                pars = new SqlParameter[]
                {
            new SqlParameter("@s", $"%{search}%")
                };
            }

            sql += " ORDER BY ID ASC";

            DataTable dt = DataBase.GetDataTable(sql, pars);
            dgvTable.AutoGenerateColumns = false;
            dgvTable.DataSource = dt;

            ClearFields();
            textBoxSearch.Focus();
        }


        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count == 0)
            {
                selectedUserId = null;
                oldUsername = null;
                oldEmail = null;
                buttonDeleteUser.Enabled = false;
                return;
            }

            DataGridViewRow row = dgvTable.SelectedRows[0];

            var idCell = row.Cells["dgvReference"];
            if (idCell == null || idCell.Value == null || !int.TryParse(idCell.Value.ToString(), out int id))
            {
                selectedUserId = null;
                buttonDeleteUser.Enabled = false;
                return;
            }

            selectedUserId = id;
            oldUsername = row.Cells["dgvUserName"].Value?.ToString();
            oldEmail = row.Cells["dgvEmail"].Value?.ToString();

            textBoxUserName.Text = oldUsername;
            textBoxFullName.Text = row.Cells["dgvFullName"].Value?.ToString();
            textBoxEmail.Text = oldEmail;
            textBoxPassword.Text = row.Cells["dgvPassword"].Value?.ToString();

            string userType = row.Cells["dgvUserType"].Value?.ToString();
            radioButtonStudent.Checked = userType == "Student";
            radioButtonCompany.Checked = userType == "Company";
            radioButtonOthers.Checked = userType == "Others";

            buttonDeleteUser.Enabled = true;
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
            textBoxSearch.Text = "";
        }

        private void buttonSearchBy_Click(object sender, EventArgs e)
        {
            string s = textBoxSearch.Text.Trim();
            LoadUsers(string.IsNullOrEmpty(s) ? null : s);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                string s = textBoxSearch.Text.Trim();
                LoadUsers(string.IsNullOrEmpty(s) ? null : s);
            }
        }

        private void ClearFields()
        {
            textBoxUserName.Text = string.Empty;
            textBoxFullName.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPassword.Text = string.Empty;

            radioButtonCompany.Checked = false;
            radioButtonStudent.Checked = false;
            radioButtonOthers.Checked = false;

            dgvTable.ClearSelection();
            if (dgvTable.CurrentCell != null)
                dgvTable.CurrentCell = null;

            selectedUserId = null;
            oldUsername = null;
            oldEmail = null;
            buttonDeleteUser.Enabled = false;
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            ClearFields();
            textBoxUserName.Focus();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.Trim();
            string fullName = textBoxFullName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            string userType = radioButtonStudent.Checked ? "Student" :
                              radioButtonCompany.Checked ? "Company" :
                              radioButtonOthers.Checked ? "Others" : "";

            var (error, field) = ValidationHelper.ValidateUserInput(username, fullName, email, password, userType);
            if (error != null)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                switch (field)
                {
                    case "username": textBoxUserName.Focus(); break;
                    case "fullname": textBoxFullName.Focus(); break;
                    case "email": textBoxEmail.Focus(); break;
                    case "password": textBoxPassword.Focus(); break;
                    case "usertype": radioButtonStudent.Focus(); break;
                }

                return;
            }

            // INSERT OR UPDATE
            if (selectedUserId == null) 
            {
                var (uExists, eExists) = DataBase.CheckUsernameOrEmailExists(username, email);
                if (uExists || eExists)
                {
                    MessageBox.Show("Username or email already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertSql = @"INSERT INTO UserInfo (UserName, FullName, Email, UserType, Password, CreatedDate)
                             VALUES (@u, @f, @e, @ut, @p, GETDATE())";

                var pars = DataBase.CreateParameters(
                    ("@u", username), ("@f", fullName), ("@e", email),
                    ("@ut", userType), ("@p", password)
                );

                if (DataBase.ExecuteNonQuery(insertSql, pars) > 0)
                {
                    MessageBox.Show("User added successfully!");
                    LoadUsers();
                }
            }
            else
            {
                if (username != oldUsername || email != oldEmail)
                {
                    var (uExists, eExists) = DataBase.CheckUsernameOrEmailExists(username, email);

                    if (uExists && username != oldUsername)
                    {
                        MessageBox.Show("This username is already taken.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (eExists && email != oldEmail)
                    {
                        MessageBox.Show("This email is already used.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string updateSql = @"UPDATE UserInfo 
                             SET UserName=@u, FullName=@f, Email=@e, UserType=@ut, Password=@p
                             WHERE ID=@id";

                var pars = DataBase.CreateParameters(
                    ("@u", username), ("@f", fullName), ("@e", email),
                    ("@ut", userType), ("@p", password), ("@id", selectedUserId)
                );

                if (DataBase.ExecuteNonQuery(updateSql, pars) > 0)
                {
                    MessageBox.Show("User updated successfully!");
                    LoadUsers();
                }

            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == null)
            {
                MessageBox.Show("Please select a user to delete.", "No selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this user? This action cannot be undone.",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            string sql = "DELETE FROM UserInfo WHERE ID = @id";
            var pars = DataBase.CreateParameters(("@id", selectedUserId));
            int rows = DataBase.ExecuteNonQuery(sql, pars);

            if (rows > 0)
            {
                //MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
                buttonDeleteUser.Enabled = false;
            }
            else
            {
                MessageBox.Show("Delete failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            Control current = sender as Control;

            if (current == textBoxUserName)
                textBoxFullName.Focus();
            else if (current == textBoxFullName)
                textBoxEmail.Focus();
            else if (current == textBoxEmail)
                radioButtonStudent.Focus();
            else if (current == radioButtonStudent)
                radioButtonCompany.Focus();
            else if (current == radioButtonCompany)
                radioButtonOthers.Focus();
            else if (current == radioButtonOthers)
                textBoxPassword.Focus();
            else if (current == textBoxPassword)
                buttonSaveUser.PerformClick();
        }

    }
}
