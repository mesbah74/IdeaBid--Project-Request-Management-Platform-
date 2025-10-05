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
    public partial class FormUserDashboard : Form
    {
        public string LoggedInUser { get; private set; }
        public static int CurrentUserId { get; private set; }

        private bool isLogoutClicked = false;
        private bool isCloseConfirmed = false;
        

        public FormUserDashboard()
        {
            //InitializeComponent();
        }

        public FormUserDashboard(string username) : this()
        {
            InitializeComponent();
            LoggedInUser = username;
            object userIdResult = DataBase.ExecuteScalar(
                "SELECT TOP 1 ID FROM UserInfo WHERE UserName = @u",
                DataBase.CreateParameters(("@u", username))
            );

            if (userIdResult == null || userIdResult == DBNull.Value)
            {
                MessageBox.Show("User not found in database. Please contact administrator.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

           CurrentUserId = Convert.ToInt32(userIdResult);

            //Welcome Message
            string fullName = DataBase.ExecuteScalar(
                "SELECT FullName FROM UserInfo WHERE ID = @id",
                DataBase.CreateParameters(("@id", CurrentUserId))
            )?.ToString();

            //labelUserDashboard.Text = $"Welcome, {fullName}!";
            labelUserDashboard.Text =
                  $"👤 Welcome, {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fullName.ToLower())}!";
        }


        private void buttonLogout_Click(object sender, EventArgs e)
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

        private void FormUserDashboard_Load(object sender, EventArgs e)
        {
            userControlProjectRequestFormUser.LoadRequests(CurrentUserId);

            userControlProjectRequestFormUser.BringToFront();


        }

    




        private void buttonProjectRequest_Click(object sender, EventArgs e)
        {
            userControlProjectRequestFormUser.LoadRequests(CurrentUserId);

            userControlProjectRequestFormUser.BringToFront();

        }

        private void userControlProjectRequestFormUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonPublicProjeect_Click(object sender, EventArgs e)
        {
            userControlPublicProjects.BringToFront();
        }

        private void userControlUserProfile1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
         
        }

        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            userControlUserProfile1.BringToFront();
            userControlUserProfile1.LoadUserInfo(CurrentUserId);
            userControlUserProfile1.LoadUserInfo(CurrentUserId);
        }

 //       userControlUserProfile1.bringtofront();
 //userControlUserProfile1.loaduserinfo(currentuserid);
 //userControlUserProfile1.loaduserinfo(currentuserid);
    }
}
