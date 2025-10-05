namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class UserControlUserProfile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUserProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProfile = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelCreatedDate = new System.Windows.Forms.Label();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonCompany = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.labelUserType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.labelProfile);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 82);
            this.panel1.TabIndex = 70;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI Black", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.Blue;
            this.labelProfile.Location = new System.Drawing.Point(47, 15);
            this.labelProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(166, 57);
            this.labelProfile.TabIndex = 0;
            this.labelProfile.Text = "Profile";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(267, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "ShowCreatingDate";
            // 
            // labelCreatedDate
            // 
            this.labelCreatedDate.AutoSize = true;
            this.labelCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelCreatedDate.Location = new System.Drawing.Point(65, 320);
            this.labelCreatedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreatedDate.Name = "labelCreatedDate";
            this.labelCreatedDate.Size = new System.Drawing.Size(141, 26);
            this.labelCreatedDate.TabIndex = 67;
            this.labelCreatedDate.Text = "Created Date";
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOther.Location = new System.Drawing.Point(515, 271);
            this.radioButtonOther.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(78, 28);
            this.radioButtonOther.TabIndex = 66;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            this.radioButtonOther.CheckedChanged += new System.EventHandler(this.radioButtonOther_CheckedChanged);
            // 
            // radioButtonCompany
            // 
            this.radioButtonCompany.AutoSize = true;
            this.radioButtonCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCompany.Location = new System.Drawing.Point(393, 271);
            this.radioButtonCompany.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCompany.Name = "radioButtonCompany";
            this.radioButtonCompany.Size = new System.Drawing.Size(112, 28);
            this.radioButtonCompany.TabIndex = 65;
            this.radioButtonCompany.TabStop = true;
            this.radioButtonCompany.Text = "Company";
            this.radioButtonCompany.UseVisualStyleBackColor = true;
            this.radioButtonCompany.CheckedChanged += new System.EventHandler(this.radioButtonCompany_CheckedChanged);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudent.Location = new System.Drawing.Point(272, 271);
            this.radioButtonStudent.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(95, 28);
            this.radioButtonStudent.TabIndex = 64;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.radioButtonStudent_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(272, 596);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(337, 59);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(272, 540);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(334, 30);
            this.txtConfirmPassword.TabIndex = 62;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(55, 538);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(210, 29);
            this.labelConfirmPassword.TabIndex = 61;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(272, 496);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(334, 30);
            this.txtNewPassword.TabIndex = 60;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(65, 495);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(176, 29);
            this.labelNewPassword.TabIndex = 59;
            this.labelNewPassword.Text = "New Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(272, 452);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(334, 30);
            this.txtOldPassword.TabIndex = 58;
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPassword.Location = new System.Drawing.Point(65, 452);
            this.labelOldPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(165, 29);
            this.labelOldPassword.TabIndex = 57;
            this.labelOldPassword.Text = "Old Password";
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserType.Location = new System.Drawing.Point(65, 265);
            this.labelUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(125, 29);
            this.labelUserType.TabIndex = 55;
            this.labelUserType.Text = "User Type";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(268, 218);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(341, 30);
            this.txtEmail.TabIndex = 54;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(65, 219);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 29);
            this.labelEmail.TabIndex = 53;
            this.labelEmail.Text = "Email";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(268, 171);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(341, 30);
            this.txtFullName.TabIndex = 52;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(65, 173);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(124, 29);
            this.labelFullName.TabIndex = 51;
            this.labelFullName.Text = "Full Name";
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangePassword.ForeColor = System.Drawing.Color.Black;
            this.labelChangePassword.Location = new System.Drawing.Point(194, 379);
            this.labelChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(311, 39);
            this.labelChangePassword.TabIndex = 56;
            this.labelChangePassword.Text = "Change Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(268, 129);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(341, 30);
            this.txtUserName.TabIndex = 50;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(65, 127);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(135, 29);
            this.labelUserName.TabIndex = 49;
            this.labelUserName.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(773, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCreatedDate);
            this.Controls.Add(this.radioButtonOther);
            this.Controls.Add(this.radioButtonCompany);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.labelOldPassword);
            this.Controls.Add(this.labelUserType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelChangePassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelUserName);
            this.Name = "UserControlUserProfile";
            this.Size = new System.Drawing.Size(1498, 674);
            this.Load += new System.EventHandler(this.UserControlUserProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCreatedDate;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonCompany;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labelUserName;
    }
}
