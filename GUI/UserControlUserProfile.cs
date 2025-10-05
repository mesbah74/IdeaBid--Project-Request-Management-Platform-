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
    public partial class UserControlUserProfile : UserControl
    {

        private int currentUserId;

        // Variables to store original data for comparison
        private string originalFullName = "";
        private string originalUserType = "";

        public UserControlUserProfile()
        {
            InitializeComponent();
            SetPasswordFieldProperties();
        }


        public int CurrentUserId
        {
            get { return currentUserId; }
            set { currentUserId = value; LoadUserInfo(value); }
        }


        private void SetPasswordFieldProperties()
        {
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }


        // Default LoadUserInfo method - loads current user
        public void LoadUserInfo()
        {
            if (currentUserId > 0)
            {
                LoadUserInfo(currentUserId);
            }
            else
            {
                MessageBox.Show("User ID is not set.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void LoadUserInfo(int userId)
        {
            try
            {
                string sql = "SELECT UserName, FullName, Email, UserType, CreatedDate FROM UserInfo WHERE ID = @id";
                var parameters = DataBase.CreateParameters(("@id", userId));
                DataTable dt = DataBase.GetDataTable(sql, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Load all data but make UserName and Email readonly
                    txtUserName.Text = row["UserName"].ToString();
                    txtUserName.ReadOnly = true; // Make UserName readonly

                    txtFullName.Text = row["FullName"].ToString();
                    txtFullName.ReadOnly = false; // Allow editing

                    txtEmail.Text = row["Email"].ToString();
                    txtEmail.ReadOnly = true; // Make Email readonly

                    // UserType radio button set করা
                    string userType = row["UserType"].ToString();
                    SetUserTypeRadioButton(userType);

                    // *** Store original data for change detection ***
                    originalFullName = row["FullName"].ToString();
                    originalUserType = row["UserType"].ToString();

                    // CreatedDate format করে show করা
                    if (row["CreatedDate"] != DBNull.Value)
                    {
                        DateTime createdDate = Convert.ToDateTime(row["CreatedDate"]);
                        label1.Text = createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                    }
                    else
                    {
                        label1.Text = "Date not found";
                    }

                    currentUserId = userId;
                }
                else
                {
                    //MessageBox.Show("No user found with this ID.", "User Not Found",
                    //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user information: {ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if current user ID is set
            if (currentUserId <= 0)
            {
                MessageBox.Show("No user is selected.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if user wants to change password (any password field is filled)
            bool isPasswordChange = !string.IsNullOrWhiteSpace(txtOldPassword.Text) ||
                                   !string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                                   !string.IsNullOrWhiteSpace(txtConfirmPassword.Text);

            // Check if profile data has changed
            bool isProfileChanged = HasProfileDataChanged();

            // If no password change and no profile change
            if (!isPasswordChange && !isProfileChanged)
            {
                MessageBox.Show("Please change anything to update.", "No Changes Detected",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (isPasswordChange)
            {
                // Password change validation
                if (ValidatePasswordInput())
                {
                    // Verify old password first
                    if (VerifyOldPassword(txtOldPassword.Text))
                    {
                        // Update both profile and password
                        if (ValidateUpdateInput()) // Check FullName validation
                        {
                            UpdateUserInfoWithPassword();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current password is incorrect.", "Authentication Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOldPassword.Focus();
                    }
                }
            }
            else
            {
                // Only profile update (no password change)
                if (ValidateUpdateInput())
                {
                    UpdateUserInfo();
                }
            }
        }


        private bool HasProfileDataChanged()
        {
            // Get current selected user type
            string currentUserType = GetSelectedUserType();

            // Compare FullName (case insensitive)
            bool fullNameChanged = !string.Equals(originalFullName.Trim(), txtFullName.Text.Trim(), StringComparison.OrdinalIgnoreCase);

            // Compare UserType
            bool userTypeChanged = !string.Equals(originalUserType, currentUserType, StringComparison.OrdinalIgnoreCase);

            return fullNameChanged || userTypeChanged;
        }


        private bool ValidateUpdateInput()
        {
            // Check if FullName is empty or null
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full name cannot be empty.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            // Check FullName length (max 100 chars based on your table)
            if (txtFullName.Text.Trim().Length > 100)
            {
                MessageBox.Show("Full name cannot exceed 100 characters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            return true;
        }



        private bool ValidatePasswordInput()
        {
            // Check if old password is entered
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                MessageBox.Show("Please enter your current password.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPassword.Focus();
                return false;
            }

            // Check if new password is entered
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter a new password.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }

            // Check if confirm password is entered
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please confirm your new password.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            // Check minimum password length first
            if (txtNewPassword.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }

            // *** CRITICAL VALIDATION: Current and New password cannot be same ***
            if (txtOldPassword.Text.Trim() == txtNewPassword.Text.Trim())
            {
                MessageBox.Show("New password must be different from your current password.\nPlease choose a different password.", "Same Password Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Clear(); // Clear the new password field
                txtConfirmPassword.Clear(); // Also clear confirm field
                txtNewPassword.Focus();
                return false;
            }

            // Check if new password and confirm password match
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New password and confirm password do not match.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        }

        // Method to verify old password from database
        private bool VerifyOldPassword(string oldPassword)
        {
            try
            {
                string sql = "SELECT Password FROM UserInfo WHERE ID = @id";
                var parameters = DataBase.CreateParameters(("@id", currentUserId));
                DataTable dt = DataBase.GetDataTable(sql, parameters);

                if (dt.Rows.Count > 0)
                {
                    string dbPassword = dt.Rows[0]["Password"].ToString();
                    return dbPassword == oldPassword; // Direct comparison
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verifying password: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to update only FullName and UserType (no password change)
        private void UpdateUserInfo()
        {
            try
            {
                // Get selected UserType
                string userType = GetSelectedUserType();

                // Update SQL query - only FullName and UserType
                string sql = @"UPDATE UserInfo 
                              SET FullName = @fullName, 
                                  UserType = @userType 
                              WHERE ID = @id";

                var parameters = DataBase.CreateParameters(
                    ("@fullName", txtFullName.Text.Trim()),
                    ("@userType", userType),
                    ("@id", currentUserId)
                );

                int rowsAffected = DataBase.ExecuteNonQuery(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User information updated successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset original data after successful update
                    ResetOriginalData();

                    // Reload data to show updated information
                    LoadUserInfo(currentUserId);
                }
                else
                {
                    MessageBox.Show("No information was updated. Please try again.", "Update Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex) when (ex.Number == 8152)
            {
                MessageBox.Show("Data is too large. Please make it shorter.", "Data Too Long",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Method to update user info including password
        private void UpdateUserInfoWithPassword()
        {
            try
            {
                // Get selected UserType
                string userType = GetSelectedUserType();

                // Update SQL query - FullName, UserType, and Password
                string sql = @"UPDATE UserInfo 
                              SET FullName = @fullName, 
                                  UserType = @userType,
                                  Password = @password 
                              WHERE ID = @id";

                var parameters = DataBase.CreateParameters(
                    ("@fullName", txtFullName.Text.Trim()),
                    ("@userType", userType),
                    ("@password", txtNewPassword.Text), // New password
                    ("@id", currentUserId)
                );

                int rowsAffected = DataBase.ExecuteNonQuery(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User information and password updated successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset original data after successful update
                    ResetOriginalData();

                    // Clear password fields after successful update
                    ClearPasswordFields();

                    // Reload user data
                    LoadUserInfo(currentUserId);
                }
                else
                {
                    MessageBox.Show("No information was updated. Please try again.", "Update Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex) when (ex.Number == 8152)
            {
                MessageBox.Show("Data is too large. Please make it shorter.", "Data Too Long",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to reset original data after successful update
        private void ResetOriginalData()
        {
            originalFullName = txtFullName.Text.Trim();
            originalUserType = GetSelectedUserType();
        }

        // Method to get selected UserType from radio buttons
        private string GetSelectedUserType()
        {
            if (radioButtonStudent.Checked)
                return "Student";
            else if (radioButtonCompany.Checked)
                return "Company";
            else if (radioButtonOther.Checked)
                return "Other";
            else
                return "Other"; // Default fallback
        }



        // Method to set UserType radio buttons based on database value
        private void SetUserTypeRadioButton(string userType)
        {
            radioButtonStudent.Checked = false;
            radioButtonCompany.Checked = false;
            radioButtonOther.Checked = false;

            switch (userType.ToLower())
            {
                case "student":
                    radioButtonStudent.Checked = true;
                    break;
                case "company":
                    radioButtonCompany.Checked = true;
                    break;
                case "other":
                    radioButtonOther.Checked = true;
                    break;
                default:
                    radioButtonOther.Checked = true;
                    break;
            }
        }



        // Method to clear password fields
        private void ClearPasswordFields()
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        // Method to clear all fields
        private void ClearFields()
        {
            txtUserName.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            label1.Text = "";

            // Clear password fields
            ClearPasswordFields();

            radioButtonStudent.Checked = false;
            radioButtonCompany.Checked = false;
            radioButtonOther.Checked = false;

            // Clear original data
            originalFullName = "";
            originalUserType = "";

            currentUserId = 0;
        }

        // Method to enable/disable controls
        public void SetControlsEnabled(bool enabled)
        {
            txtFullName.Enabled = enabled; // Only FullName is editable
            radioButtonStudent.Enabled = enabled;
            radioButtonCompany.Enabled = enabled;
            radioButtonOther.Enabled = enabled;
            btnUpdate.Enabled = enabled;

            // Password fields
            txtOldPassword.Enabled = enabled;
            txtNewPassword.Enabled = enabled;
            txtConfirmPassword.Enabled = enabled;

            // Keep these readonly
            txtUserName.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }

        private void UserControlUserProfile_Load(object sender, EventArgs e)
        {
            SetPasswordFieldProperties();
        }


        private void UpdateChangeIndicator()
        {
            if (HasProfileDataChanged())
            {
                btnUpdate.Text = "Update"; // Show asterisk for changes
                btnUpdate.ForeColor = Color.Red;
            }
            else
            {
                btnUpdate.Text = "Update";
                btnUpdate.ForeColor = Color.Black;
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            UpdateChangeIndicator();
        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChangeIndicator();
        }

        private void radioButtonCompany_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChangeIndicator();
        }

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChangeIndicator();
        }
    }
}

