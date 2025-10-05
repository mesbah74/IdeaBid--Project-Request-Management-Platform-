using IdeaBid__Project_Request___Management_Platform.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    public partial class FormControlPortal : Form
    {
        //Global Variables
        public static string LoggedInUser { get; private set; }
        public static string Role { get; private set; }
        private bool isLogoutClicked = false;
        private bool isCloseConfirmed = false;

        //Reference to Login Form
        public FormControlPortal(string username, string role) : this()
        {
            LoggedInUser = username;
            Role = role;
            string tableName, columnName,userNameColumn; ;

            if (Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                tableName = "AdminInfo";
                columnName = "AdminFullName";
                userNameColumn = "AdminUserName";
            }
            else 
            {
                tableName = "DevInfo";
                columnName = "DevFullName";
                userNameColumn = "DevUserName";
            }

            string fullName = DataBase.ExecuteScalar(
                $"SELECT {columnName} FROM {tableName} WHERE {userNameColumn} = @u",
                DataBase.CreateParameters(("@u", username))
            )?.ToString();

            labelAdminDevDashboardControlPortal.Text =
                $"👤 Welcome, {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fullName.ToLower())}  |  Role: {Role}";



            }
        public FormControlPortal()
        {
            InitializeComponent();
        }

        private void ButtonUsersInfoControlPortal_Click(object sender, EventArgs e)
        {
            UserManageControlPanel1.LoadUsers();
            UserManageControlPanel1.BringToFront();
            
        }

        private void FormControlPanel_Load(object sender, EventArgs e)
        {
            DashboardControlPanel1.BringToFront();
        }

  


        //Logout Button Method
        private void buttonLogoutControlPortal_Click(object sender, EventArgs e)
        {
            isLogoutClicked = true;

            if (this.Owner != null && this.Owner is FormLogin loginForm)
            {
                loginForm.Show();
                loginForm.TextBoxUserNameLogin.Focus();
            }
            else
            {
                loginForm = new FormLogin();
                loginForm.Show();
                loginForm.TextBoxUserNameLogin.Focus();
            }

            this.Close();
        }

        //FormClosing Method
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isLogoutClicked || isCloseConfirmed)
            {
                base.OnFormClosing(e);
                return;
            }

            DialogResult result = MessageBox.Show(
             "Are you sure you want to exit?",
             "Exit Application",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            isCloseConfirmed = true;
            Application.Exit();

            return;
        }

        private void buttonOurProjectsControlPortal_Click(object sender, EventArgs e)
        {
            userControlOurProjects.LoadOurProjects();
            userControlOurProjects.BringToFront();
        }

        private void buttonProjectBoardControlPortal_Click(object sender, EventArgs e)
        {
            userControlProjectBoard.LoadRequests();
            userControlProjectBoard.BringToFront();
        }

        private void buttonOurResponsesControlPortal_Click(object sender, EventArgs e)
        {
            userControlOurResponses.LoadOurResponses();
            userControlOurResponses.BringToFront();
        }

        private void buttonDashboardControlPortal_Click(object sender, EventArgs e)
        {
           userControlDashBoard1.BringToFront();
        }
    }
}
