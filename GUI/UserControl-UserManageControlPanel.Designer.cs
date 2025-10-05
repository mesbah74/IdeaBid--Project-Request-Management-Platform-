namespace IdeaBid__Project_Request___Management_Platform
{
    partial class UserControlUserManageControlPanel
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
            this.tableLayoutPanelUserManager = new System.Windows.Forms.TableLayoutPanel();
            this.panelOptionsUserManage = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelManupulation = new System.Windows.Forms.Panel();
            this.panelEditable = new System.Windows.Forms.Panel();
            this.radioButtonOthers = new System.Windows.Forms.RadioButton();
            this.radioButtonCompany = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserType = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.panelDataTable = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.dgvReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelUserManager.SuspendLayout();
            this.panelOptionsUserManage.SuspendLayout();
            this.panelManupulation.SuspendLayout();
            this.panelEditable.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelCrud.SuspendLayout();
            this.panelDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelUserManager
            // 
            this.tableLayoutPanelUserManager.ColumnCount = 2;
            this.tableLayoutPanelUserManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tableLayoutPanelUserManager.Controls.Add(this.panelOptionsUserManage, 0, 0);
            this.tableLayoutPanelUserManager.Controls.Add(this.panelManupulation, 1, 1);
            this.tableLayoutPanelUserManager.Controls.Add(this.panelButtons, 1, 0);
            this.tableLayoutPanelUserManager.Controls.Add(this.panelDataTable, 0, 1);
            this.tableLayoutPanelUserManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUserManager.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUserManager.Name = "tableLayoutPanelUserManager";
            this.tableLayoutPanelUserManager.RowCount = 2;
            this.tableLayoutPanelUserManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanelUserManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserManager.Size = new System.Drawing.Size(1214, 641);
            this.tableLayoutPanelUserManager.TabIndex = 1;
            // 
            // panelOptionsUserManage
            // 
            this.panelOptionsUserManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.panelOptionsUserManage.Controls.Add(this.textBoxSearch);
            this.panelOptionsUserManage.Controls.Add(this.buttonSearch);
            this.panelOptionsUserManage.Controls.Add(this.buttonRefresh);
            this.panelOptionsUserManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOptionsUserManage.Location = new System.Drawing.Point(3, 3);
            this.panelOptionsUserManage.Name = "panelOptionsUserManage";
            this.panelOptionsUserManage.Size = new System.Drawing.Size(830, 67);
            this.panelOptionsUserManage.TabIndex = 9;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(487, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(340, 41);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(354, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 53);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchBy_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Teal;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRefresh.Location = new System.Drawing.Point(22, 9);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(136, 50);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelManupulation
            // 
            this.panelManupulation.Controls.Add(this.panelEditable);
            this.panelManupulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManupulation.Location = new System.Drawing.Point(839, 76);
            this.panelManupulation.Name = "panelManupulation";
            this.panelManupulation.Size = new System.Drawing.Size(372, 562);
            this.panelManupulation.TabIndex = 3;
            // 
            // panelEditable
            // 
            this.panelEditable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelEditable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditable.Controls.Add(this.radioButtonOthers);
            this.panelEditable.Controls.Add(this.radioButtonCompany);
            this.panelEditable.Controls.Add(this.radioButtonStudent);
            this.panelEditable.Controls.Add(this.labelEmail);
            this.panelEditable.Controls.Add(this.textBoxEmail);
            this.panelEditable.Controls.Add(this.textBoxPassword);
            this.panelEditable.Controls.Add(this.labelPassword);
            this.panelEditable.Controls.Add(this.textBoxFullName);
            this.panelEditable.Controls.Add(this.textBoxUserName);
            this.panelEditable.Controls.Add(this.labelUserType);
            this.panelEditable.Controls.Add(this.labelFullName);
            this.panelEditable.Controls.Add(this.labelUserName);
            this.panelEditable.Controls.Add(this.buttonSaveUser);
            this.panelEditable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditable.Location = new System.Drawing.Point(0, 0);
            this.panelEditable.Name = "panelEditable";
            this.panelEditable.Size = new System.Drawing.Size(372, 562);
            this.panelEditable.TabIndex = 5;
            // 
            // radioButtonOthers
            // 
            this.radioButtonOthers.AutoSize = true;
            this.radioButtonOthers.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOthers.Location = new System.Drawing.Point(298, 218);
            this.radioButtonOthers.Name = "radioButtonOthers";
            this.radioButtonOthers.Size = new System.Drawing.Size(72, 23);
            this.radioButtonOthers.TabIndex = 17;
            this.radioButtonOthers.TabStop = true;
            this.radioButtonOthers.Text = "Others";
            this.radioButtonOthers.UseVisualStyleBackColor = true;
            this.radioButtonOthers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // radioButtonCompany
            // 
            this.radioButtonCompany.AutoSize = true;
            this.radioButtonCompany.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCompany.Location = new System.Drawing.Point(203, 218);
            this.radioButtonCompany.Name = "radioButtonCompany";
            this.radioButtonCompany.Size = new System.Drawing.Size(89, 23);
            this.radioButtonCompany.TabIndex = 16;
            this.radioButtonCompany.TabStop = true;
            this.radioButtonCompany.Text = "Company";
            this.radioButtonCompany.UseVisualStyleBackColor = true;
            this.radioButtonCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudent.Location = new System.Drawing.Point(119, 218);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(78, 23);
            this.radioButtonStudent.TabIndex = 15;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(9, 147);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 28);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(116, 147);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(241, 34);
            this.textBoxEmail.TabIndex = 11;
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(116, 274);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(241, 34);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(9, 274);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 28);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(116, 86);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(241, 34);
            this.textBoxFullName.TabIndex = 7;
            this.textBoxFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(116, 23);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(241, 34);
            this.textBoxUserName.TabIndex = 6;
            this.textBoxUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserType.Location = new System.Drawing.Point(9, 212);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(102, 28);
            this.labelUserType.TabIndex = 5;
            this.labelUserType.Text = "User Type";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(9, 85);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(104, 28);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(9, 23);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(104, 28);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Username";
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.BackColor = System.Drawing.Color.Teal;
            this.buttonSaveUser.FlatAppearance.BorderSize = 0;
            this.buttonSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUser.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveUser.Location = new System.Drawing.Point(14, 505);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(343, 52);
            this.buttonSaveUser.TabIndex = 0;
            this.buttonSaveUser.Text = "Save";
            this.buttonSaveUser.UseVisualStyleBackColor = false;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelCrud);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(839, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(372, 67);
            this.panelButtons.TabIndex = 2;
            // 
            // panelCrud
            // 
            this.panelCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.panelCrud.Controls.Add(this.buttonDeleteUser);
            this.panelCrud.Controls.Add(this.buttonNewUser);
            this.panelCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrud.Location = new System.Drawing.Point(0, 0);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(372, 67);
            this.panelCrud.TabIndex = 6;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(254, 9);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(104, 47);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.BackColor = System.Drawing.Color.Teal;
            this.buttonNewUser.FlatAppearance.BorderSize = 0;
            this.buttonNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNewUser.Location = new System.Drawing.Point(15, 9);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(104, 47);
            this.buttonNewUser.TabIndex = 1;
            this.buttonNewUser.Text = "New";
            this.buttonNewUser.UseVisualStyleBackColor = false;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // panelDataTable
            // 
            this.panelDataTable.Controls.Add(this.dgvTable);
            this.panelDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataTable.Location = new System.Drawing.Point(3, 76);
            this.panelDataTable.Name = "panelDataTable";
            this.panelDataTable.Size = new System.Drawing.Size(830, 562);
            this.panelDataTable.TabIndex = 0;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvReference,
            this.dgvUserName,
            this.dgvFullName,
            this.dgvEmail,
            this.dgvUserType,
            this.dgvPassword,
            this.dgvCreatedDate});
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(830, 562);
            this.dgvTable.TabIndex = 8;
            // 
            // dgvReference
            // 
            this.dgvReference.DataPropertyName = "ID";
            this.dgvReference.HeaderText = "Reference";
            this.dgvReference.MinimumWidth = 6;
            this.dgvReference.Name = "dgvReference";
            this.dgvReference.ReadOnly = true;
            // 
            // dgvUserName
            // 
            this.dgvUserName.DataPropertyName = "UserName";
            this.dgvUserName.HeaderText = "Username";
            this.dgvUserName.MinimumWidth = 6;
            this.dgvUserName.Name = "dgvUserName";
            this.dgvUserName.ReadOnly = true;
            // 
            // dgvFullName
            // 
            this.dgvFullName.DataPropertyName = "FullName";
            this.dgvFullName.HeaderText = "Full Name";
            this.dgvFullName.MinimumWidth = 6;
            this.dgvFullName.Name = "dgvFullName";
            this.dgvFullName.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "Email";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvUserType
            // 
            this.dgvUserType.DataPropertyName = "UserType";
            this.dgvUserType.HeaderText = "User Type";
            this.dgvUserType.MinimumWidth = 6;
            this.dgvUserType.Name = "dgvUserType";
            this.dgvUserType.ReadOnly = true;
            // 
            // dgvPassword
            // 
            this.dgvPassword.DataPropertyName = "Password";
            this.dgvPassword.HeaderText = "Password";
            this.dgvPassword.MinimumWidth = 6;
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.ReadOnly = true;
            // 
            // dgvCreatedDate
            // 
            this.dgvCreatedDate.DataPropertyName = "CreatedDate";
            this.dgvCreatedDate.HeaderText = "Created At";
            this.dgvCreatedDate.MinimumWidth = 6;
            this.dgvCreatedDate.Name = "dgvCreatedDate";
            this.dgvCreatedDate.ReadOnly = true;
            // 
            // UserControlUserManageControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanelUserManager);
            this.Name = "UserControlUserManageControlPanel";
            this.Size = new System.Drawing.Size(1214, 641);
            this.tableLayoutPanelUserManager.ResumeLayout(false);
            this.panelOptionsUserManage.ResumeLayout(false);
            this.panelOptionsUserManage.PerformLayout();
            this.panelManupulation.ResumeLayout(false);
            this.panelEditable.ResumeLayout(false);
            this.panelEditable.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelCrud.ResumeLayout(false);
            this.panelDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserManager;
        private System.Windows.Forms.Panel panelDataTable;
        private System.Windows.Forms.Panel panelManupulation;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelEditable;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel panelCrud;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonOthers;
        private System.Windows.Forms.RadioButton radioButtonCompany;
        private System.Windows.Forms.Panel panelOptionsUserManage;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreatedDate;
    }
}
