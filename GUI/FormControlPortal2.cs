using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    public partial class FormControlPortal2 : Form
    {
        public string LoggedInUser { get; private set; }
        public string Role { get; private set; }
        private bool isLogoutClicked = false;
        private bool isCloseConfirmed = false;
        public FormControlPortal2()
        {
            InitializeComponent();
        }
        public FormControlPortal2(string username, string role) : this()
        {
            LoggedInUser = username;
            Role = role;
        }



        private void FormAdminDevPortal_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogoutControl_Click(object sender, EventArgs e)
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
    }
}
