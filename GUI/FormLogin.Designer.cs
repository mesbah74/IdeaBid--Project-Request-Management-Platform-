using System.Drawing;
using System.Windows.Forms;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubTitle = new System.Windows.Forms.Label();
            this.panelLoginImage = new System.Windows.Forms.Panel();
            this.pictureBoxLaptopImage = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelInvalidWaringLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.checkBoxVisibleLogin = new System.Windows.Forms.CheckBox();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.textBoxUserNameLogin = new System.Windows.Forms.TextBox();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.labelUserNameLogin = new System.Windows.Forms.Label();
            this.buttonSignUpClickLogin = new System.Windows.Forms.Button();
            this.buttonLoginClickLogin = new System.Windows.Forms.Button();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.checkBoxVisibleSignUp = new System.Windows.Forms.CheckBox();
            this.buttonClearSignUp = new System.Windows.Forms.Button();
            this.buttonSignUP = new System.Windows.Forms.Button();
            this.radioButtonOtherSignUp = new System.Windows.Forms.RadioButton();
            this.radioButtonCompanySignUp = new System.Windows.Forms.RadioButton();
            this.radioButtonStudentSignUp = new System.Windows.Forms.RadioButton();
            this.labelUserTypeSignUp = new System.Windows.Forms.Label();
            this.labelPasswordSignUP = new System.Windows.Forms.Label();
            this.labelEmailSignUP = new System.Windows.Forms.Label();
            this.textBoxPasswordSignUp = new System.Windows.Forms.TextBox();
            this.textBoxEmailSignUp = new System.Windows.Forms.TextBox();
            this.textBoxFullNameSignUp = new System.Windows.Forms.TextBox();
            this.textBoxUserNameSignUp = new System.Windows.Forms.TextBox();
            this.labelFullNameSignUP = new System.Windows.Forms.Label();
            this.labelUserNameSignUp = new System.Windows.Forms.Label();
            this.buttonSignUpClickSignUP = new System.Windows.Forms.Button();
            this.buttonLoginClickSignUP = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.niceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLoginImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaptopImage)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Elephant", 28.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTitle.Location = new System.Drawing.Point(30, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(269, 81);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "IdeaBid";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubTitle
            // 
            this.labelSubTitle.AutoSize = true;
            this.labelSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSubTitle.Location = new System.Drawing.Point(223, 92);
            this.labelSubTitle.Name = "labelSubTitle";
            this.labelSubTitle.Size = new System.Drawing.Size(286, 25);
            this.labelSubTitle.TabIndex = 1;
            this.labelSubTitle.Text = "\"Where Ideas Meet Opportunities\"";
            // 
            // panelLoginImage
            // 
            this.panelLoginImage.BackColor = System.Drawing.Color.Transparent;
            this.panelLoginImage.Controls.Add(this.pictureBoxLaptopImage);
            this.panelLoginImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLoginImage.Location = new System.Drawing.Point(632, 0);
            this.panelLoginImage.Name = "panelLoginImage";
            this.panelLoginImage.Size = new System.Drawing.Size(450, 653);
            this.panelLoginImage.TabIndex = 2;
            // 
            // pictureBoxLaptopImage
            // 
            this.pictureBoxLaptopImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLaptopImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLaptopImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLaptopImage.ErrorImage")));
            this.pictureBoxLaptopImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLaptopImage.Image")));
            this.pictureBoxLaptopImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLaptopImage.Name = "pictureBoxLaptopImage";
            this.pictureBoxLaptopImage.Size = new System.Drawing.Size(450, 653);
            this.pictureBoxLaptopImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLaptopImage.TabIndex = 0;
            this.pictureBoxLaptopImage.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.labelSubTitle);
            this.panelTitle.Location = new System.Drawing.Point(356, 22);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(570, 134);
            this.panelTitle.TabIndex = 3;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelInvalidWaringLogin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.checkBoxRememberMe);
            this.panelLogin.Controls.Add(this.checkBoxVisibleLogin);
            this.panelLogin.Controls.Add(this.textBoxPasswordLogin);
            this.panelLogin.Controls.Add(this.textBoxUserNameLogin);
            this.panelLogin.Controls.Add(this.labelPasswordLogin);
            this.panelLogin.Controls.Add(this.labelUserNameLogin);
            this.panelLogin.Controls.Add(this.buttonSignUpClickLogin);
            this.panelLogin.Controls.Add(this.buttonLoginClickLogin);
            this.panelLogin.Location = new System.Drawing.Point(93, 162);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(665, 487);
            this.panelLogin.TabIndex = 4;
            // 
            // labelInvalidWaringLogin
            // 
            this.labelInvalidWaringLogin.AutoSize = true;
            this.labelInvalidWaringLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelInvalidWaringLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidWaringLogin.ForeColor = System.Drawing.Color.Red;
            this.labelInvalidWaringLogin.Location = new System.Drawing.Point(198, 361);
            this.labelInvalidWaringLogin.Name = "labelInvalidWaringLogin";
            this.labelInvalidWaringLogin.Size = new System.Drawing.Size(272, 25);
            this.labelInvalidWaringLogin.TabIndex = 10;
            this.labelInvalidWaringLogin.Text = "Invalid username or password!";
            this.labelInvalidWaringLogin.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Teal;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(348, 288);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(140, 55);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxRememberMe.Location = new System.Drawing.Point(316, 238);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(172, 32);
            this.checkBoxRememberMe.TabIndex = 7;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisibleLogin
            // 
            this.checkBoxVisibleLogin.AutoSize = true;
            this.checkBoxVisibleLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkBoxVisibleLogin.Location = new System.Drawing.Point(508, 182);
            this.checkBoxVisibleLogin.Name = "checkBoxVisibleLogin";
            this.checkBoxVisibleLogin.Size = new System.Drawing.Size(91, 32);
            this.checkBoxVisibleLogin.TabIndex = 6;
            this.checkBoxVisibleLogin.Text = "Visible";
            this.checkBoxVisibleLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(168, 180);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(320, 34);
            this.textBoxPasswordLogin.TabIndex = 5;
            this.textBoxPasswordLogin.UseSystemPasswordChar = true;
            this.textBoxPasswordLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // textBoxUserNameLogin
            // 
            this.textBoxUserNameLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameLogin.Location = new System.Drawing.Point(168, 130);
            this.textBoxUserNameLogin.Name = "textBoxUserNameLogin";
            this.textBoxUserNameLogin.Size = new System.Drawing.Size(320, 34);
            this.textBoxUserNameLogin.TabIndex = 0;
            this.textBoxUserNameLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelPasswordLogin.Location = new System.Drawing.Point(22, 181);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(118, 30);
            this.labelPasswordLogin.TabIndex = 3;
            this.labelPasswordLogin.Text = "Password ";
            // 
            // labelUserNameLogin
            // 
            this.labelUserNameLogin.AutoSize = true;
            this.labelUserNameLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelUserNameLogin.Location = new System.Drawing.Point(22, 126);
            this.labelUserNameLogin.Name = "labelUserNameLogin";
            this.labelUserNameLogin.Size = new System.Drawing.Size(127, 30);
            this.labelUserNameLogin.TabIndex = 2;
            this.labelUserNameLogin.Text = "User Name";
            // 
            // buttonSignUpClickLogin
            // 
            this.buttonSignUpClickLogin.FlatAppearance.BorderSize = 0;
            this.buttonSignUpClickLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUpClickLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUpClickLogin.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSignUpClickLogin.Location = new System.Drawing.Point(191, 20);
            this.buttonSignUpClickLogin.Name = "buttonSignUpClickLogin";
            this.buttonSignUpClickLogin.Size = new System.Drawing.Size(139, 53);
            this.buttonSignUpClickLogin.TabIndex = 1;
            this.buttonSignUpClickLogin.Text = "Sign up";
            this.buttonSignUpClickLogin.UseVisualStyleBackColor = true;
            this.buttonSignUpClickLogin.Click += new System.EventHandler(this.buttonSignUpClickLogin_Click);
            // 
            // buttonLoginClickLogin
            // 
            this.buttonLoginClickLogin.FlatAppearance.BorderSize = 0;
            this.buttonLoginClickLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginClickLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginClickLogin.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonLoginClickLogin.Location = new System.Drawing.Point(57, 20);
            this.buttonLoginClickLogin.Name = "buttonLoginClickLogin";
            this.buttonLoginClickLogin.Size = new System.Drawing.Size(139, 53);
            this.buttonLoginClickLogin.TabIndex = 0;
            this.buttonLoginClickLogin.Text = "Login";
            this.buttonLoginClickLogin.UseVisualStyleBackColor = true;
            this.buttonLoginClickLogin.Click += new System.EventHandler(this.buttonLoginClickLogin_Click);
            // 
            // panelSignUp
            // 
            this.panelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.panelSignUp.Controls.Add(this.checkBoxVisibleSignUp);
            this.panelSignUp.Controls.Add(this.buttonClearSignUp);
            this.panelSignUp.Controls.Add(this.buttonSignUP);
            this.panelSignUp.Controls.Add(this.radioButtonOtherSignUp);
            this.panelSignUp.Controls.Add(this.radioButtonCompanySignUp);
            this.panelSignUp.Controls.Add(this.radioButtonStudentSignUp);
            this.panelSignUp.Controls.Add(this.labelUserTypeSignUp);
            this.panelSignUp.Controls.Add(this.labelPasswordSignUP);
            this.panelSignUp.Controls.Add(this.labelEmailSignUP);
            this.panelSignUp.Controls.Add(this.textBoxPasswordSignUp);
            this.panelSignUp.Controls.Add(this.textBoxEmailSignUp);
            this.panelSignUp.Controls.Add(this.textBoxFullNameSignUp);
            this.panelSignUp.Controls.Add(this.textBoxUserNameSignUp);
            this.panelSignUp.Controls.Add(this.labelFullNameSignUP);
            this.panelSignUp.Controls.Add(this.labelUserNameSignUp);
            this.panelSignUp.Controls.Add(this.buttonSignUpClickSignUP);
            this.panelSignUp.Controls.Add(this.buttonLoginClickSignUP);
            this.panelSignUp.Location = new System.Drawing.Point(93, 165);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(665, 521);
            this.panelSignUp.TabIndex = 9;
            // 
            // checkBoxVisibleSignUp
            // 
            this.checkBoxVisibleSignUp.AutoSize = true;
            this.checkBoxVisibleSignUp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkBoxVisibleSignUp.Location = new System.Drawing.Point(517, 342);
            this.checkBoxVisibleSignUp.Name = "checkBoxVisibleSignUp";
            this.checkBoxVisibleSignUp.Size = new System.Drawing.Size(91, 32);
            this.checkBoxVisibleSignUp.TabIndex = 16;
            this.checkBoxVisibleSignUp.Text = "Visible";
            this.checkBoxVisibleSignUp.UseVisualStyleBackColor = true;
            // 
            // buttonClearSignUp
            // 
            this.buttonClearSignUp.BackColor = System.Drawing.Color.Teal;
            this.buttonClearSignUp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonClearSignUp.ForeColor = System.Drawing.Color.White;
            this.buttonClearSignUp.Location = new System.Drawing.Point(168, 411);
            this.buttonClearSignUp.Name = "buttonClearSignUp";
            this.buttonClearSignUp.Size = new System.Drawing.Size(140, 55);
            this.buttonClearSignUp.TabIndex = 15;
            this.buttonClearSignUp.Text = "Clear";
            this.buttonClearSignUp.UseVisualStyleBackColor = false;
            this.buttonClearSignUp.Click += new System.EventHandler(this.buttonClearSignUp_Click);
            // 
            // buttonSignUP
            // 
            this.buttonSignUP.BackColor = System.Drawing.Color.Teal;
            this.buttonSignUP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonSignUP.ForeColor = System.Drawing.Color.White;
            this.buttonSignUP.Location = new System.Drawing.Point(359, 411);
            this.buttonSignUP.Name = "buttonSignUP";
            this.buttonSignUP.Size = new System.Drawing.Size(140, 55);
            this.buttonSignUP.TabIndex = 14;
            this.buttonSignUP.Text = "Sign up";
            this.buttonSignUP.UseVisualStyleBackColor = false;
            this.buttonSignUP.Click += new System.EventHandler(this.buttonSignUP_Click);
            // 
            // radioButtonOtherSignUp
            // 
            this.radioButtonOtherSignUp.AutoSize = true;
            this.radioButtonOtherSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOtherSignUp.Location = new System.Drawing.Point(417, 291);
            this.radioButtonOtherSignUp.Name = "radioButtonOtherSignUp";
            this.radioButtonOtherSignUp.Size = new System.Drawing.Size(83, 32);
            this.radioButtonOtherSignUp.TabIndex = 13;
            this.radioButtonOtherSignUp.TabStop = true;
            this.radioButtonOtherSignUp.Text = "Other";
            this.radioButtonOtherSignUp.UseVisualStyleBackColor = true;
            this.radioButtonOtherSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // radioButtonCompanySignUp
            // 
            this.radioButtonCompanySignUp.AutoSize = true;
            this.radioButtonCompanySignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCompanySignUp.Location = new System.Drawing.Point(286, 291);
            this.radioButtonCompanySignUp.Name = "radioButtonCompanySignUp";
            this.radioButtonCompanySignUp.Size = new System.Drawing.Size(117, 32);
            this.radioButtonCompanySignUp.TabIndex = 12;
            this.radioButtonCompanySignUp.TabStop = true;
            this.radioButtonCompanySignUp.Text = "Company";
            this.radioButtonCompanySignUp.UseVisualStyleBackColor = true;
            this.radioButtonCompanySignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // radioButtonStudentSignUp
            // 
            this.radioButtonStudentSignUp.AutoSize = true;
            this.radioButtonStudentSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudentSignUp.Location = new System.Drawing.Point(179, 290);
            this.radioButtonStudentSignUp.Name = "radioButtonStudentSignUp";
            this.radioButtonStudentSignUp.Size = new System.Drawing.Size(101, 32);
            this.radioButtonStudentSignUp.TabIndex = 11;
            this.radioButtonStudentSignUp.TabStop = true;
            this.radioButtonStudentSignUp.Text = "Student";
            this.radioButtonStudentSignUp.UseVisualStyleBackColor = true;
            this.radioButtonStudentSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // labelUserTypeSignUp
            // 
            this.labelUserTypeSignUp.AutoSize = true;
            this.labelUserTypeSignUp.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelUserTypeSignUp.Location = new System.Drawing.Point(38, 288);
            this.labelUserTypeSignUp.Name = "labelUserTypeSignUp";
            this.labelUserTypeSignUp.Size = new System.Drawing.Size(122, 30);
            this.labelUserTypeSignUp.TabIndex = 10;
            this.labelUserTypeSignUp.Text = "User Type ";
            // 
            // labelPasswordSignUP
            // 
            this.labelPasswordSignUP.AutoSize = true;
            this.labelPasswordSignUP.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelPasswordSignUP.Location = new System.Drawing.Point(38, 340);
            this.labelPasswordSignUP.Name = "labelPasswordSignUP";
            this.labelPasswordSignUP.Size = new System.Drawing.Size(118, 30);
            this.labelPasswordSignUP.TabIndex = 8;
            this.labelPasswordSignUP.Text = "Password ";
            // 
            // labelEmailSignUP
            // 
            this.labelEmailSignUP.AutoSize = true;
            this.labelEmailSignUP.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelEmailSignUP.Location = new System.Drawing.Point(38, 235);
            this.labelEmailSignUP.Name = "labelEmailSignUP";
            this.labelEmailSignUP.Size = new System.Drawing.Size(75, 30);
            this.labelEmailSignUP.TabIndex = 6;
            this.labelEmailSignUP.Text = "Email ";
            // 
            // textBoxPasswordSignUp
            // 
            this.textBoxPasswordSignUp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPasswordSignUp.Location = new System.Drawing.Point(178, 340);
            this.textBoxPasswordSignUp.Name = "textBoxPasswordSignUp";
            this.textBoxPasswordSignUp.Size = new System.Drawing.Size(320, 34);
            this.textBoxPasswordSignUp.TabIndex = 4;
            this.textBoxPasswordSignUp.UseSystemPasswordChar = true;
            this.textBoxPasswordSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // textBoxEmailSignUp
            // 
            this.textBoxEmailSignUp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxEmailSignUp.Location = new System.Drawing.Point(179, 230);
            this.textBoxEmailSignUp.Name = "textBoxEmailSignUp";
            this.textBoxEmailSignUp.Size = new System.Drawing.Size(320, 34);
            this.textBoxEmailSignUp.TabIndex = 4;
            this.textBoxEmailSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // textBoxFullNameSignUp
            // 
            this.textBoxFullNameSignUp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxFullNameSignUp.Location = new System.Drawing.Point(179, 178);
            this.textBoxFullNameSignUp.Name = "textBoxFullNameSignUp";
            this.textBoxFullNameSignUp.Size = new System.Drawing.Size(320, 34);
            this.textBoxFullNameSignUp.TabIndex = 4;
            this.textBoxFullNameSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // textBoxUserNameSignUp
            // 
            this.textBoxUserNameSignUp.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserNameSignUp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxUserNameSignUp.Location = new System.Drawing.Point(179, 126);
            this.textBoxUserNameSignUp.Name = "textBoxUserNameSignUp";
            this.textBoxUserNameSignUp.Size = new System.Drawing.Size(320, 34);
            this.textBoxUserNameSignUp.TabIndex = 4;
            this.textBoxUserNameSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // labelFullNameSignUP
            // 
            this.labelFullNameSignUP.AutoSize = true;
            this.labelFullNameSignUP.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelFullNameSignUP.Location = new System.Drawing.Point(38, 179);
            this.labelFullNameSignUP.Name = "labelFullNameSignUP";
            this.labelFullNameSignUP.Size = new System.Drawing.Size(122, 30);
            this.labelFullNameSignUP.TabIndex = 3;
            this.labelFullNameSignUP.Text = "Full Name ";
            // 
            // labelUserNameSignUp
            // 
            this.labelUserNameSignUp.AutoSize = true;
            this.labelUserNameSignUp.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelUserNameSignUp.Location = new System.Drawing.Point(38, 126);
            this.labelUserNameSignUp.Name = "labelUserNameSignUp";
            this.labelUserNameSignUp.Size = new System.Drawing.Size(133, 30);
            this.labelUserNameSignUp.TabIndex = 2;
            this.labelUserNameSignUp.Text = "User Name ";
            // 
            // buttonSignUpClickSignUP
            // 
            this.buttonSignUpClickSignUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.buttonSignUpClickSignUP.FlatAppearance.BorderSize = 0;
            this.buttonSignUpClickSignUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUpClickSignUP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUpClickSignUP.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSignUpClickSignUP.Location = new System.Drawing.Point(191, 24);
            this.buttonSignUpClickSignUP.Name = "buttonSignUpClickSignUP";
            this.buttonSignUpClickSignUP.Size = new System.Drawing.Size(139, 53);
            this.buttonSignUpClickSignUP.TabIndex = 1;
            this.buttonSignUpClickSignUP.Text = "Sign up";
            this.buttonSignUpClickSignUP.UseVisualStyleBackColor = true;
            this.buttonSignUpClickSignUP.Click += new System.EventHandler(this.buttonSignUpClickSignUP_Click);
            // 
            // buttonLoginClickSignUP
            // 
            this.buttonLoginClickSignUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.buttonLoginClickSignUP.FlatAppearance.BorderSize = 0;
            this.buttonLoginClickSignUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginClickSignUP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginClickSignUP.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonLoginClickSignUP.Location = new System.Drawing.Point(55, 24);
            this.buttonLoginClickSignUP.Name = "buttonLoginClickSignUP";
            this.buttonLoginClickSignUP.Size = new System.Drawing.Size(139, 53);
            this.buttonLoginClickSignUP.TabIndex = 0;
            this.buttonLoginClickSignUP.Text = "Login";
            this.buttonLoginClickSignUP.UseVisualStyleBackColor = true;
            this.buttonLoginClickSignUP.Click += new System.EventHandler(this.buttonLoginClickSignUP_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niceToolStripMenuItem,
            this.hhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 52);
            // 
            // niceToolStripMenuItem
            // 
            this.niceToolStripMenuItem.Name = "niceToolStripMenuItem";
            this.niceToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.niceToolStripMenuItem.Text = "nice";
            // 
            // hhToolStripMenuItem
            // 
            this.hhToolStripMenuItem.Name = "hhToolStripMenuItem";
            this.hhToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.hhToolStripMenuItem.Text = "hh";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelLoginImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdeaBId";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLoginImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaptopImage)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubTitle;
        private System.Windows.Forms.Panel panelLoginImage;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLaptopImage;
        private Panel panelLogin;
        private Button buttonLoginClickLogin;
        private Button buttonSignUpClickLogin;
        private Label labelUserNameLogin;
        private Label labelPasswordLogin;
        private CheckBox checkBoxVisibleLogin;
        private TextBox textBoxPasswordLogin;
        private TextBox textBoxUserNameLogin;
        private CheckBox checkBoxRememberMe;
        private Button buttonLogin;
        private Panel panelSignUp;
        private Button buttonSignUP;
        private RadioButton radioButtonOtherSignUp;
        private RadioButton radioButtonCompanySignUp;
        private RadioButton radioButtonStudentSignUp;
        private Label labelUserTypeSignUp;
        private Label labelPasswordSignUP;
        private Label labelEmailSignUP;
        private TextBox textBoxPasswordSignUp;
        private TextBox textBoxEmailSignUp;
        private TextBox textBoxFullNameSignUp;
        private TextBox textBoxUserNameSignUp;
        private Label labelFullNameSignUP;
        private Label labelUserNameSignUp;
        private Button buttonSignUpClickSignUP;
        private Button buttonLoginClickSignUP;
        private Button buttonClearSignUp;
        private CheckBox checkBoxVisibleSignUp;
        private Label labelInvalidWaringLogin;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem niceToolStripMenuItem;
        private ToolStripMenuItem hhToolStripMenuItem;
    }
}
