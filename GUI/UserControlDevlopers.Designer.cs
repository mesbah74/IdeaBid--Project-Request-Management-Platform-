namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class UserControlDevlopers
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.panelDataTable = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.dgvDevID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdminUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDevPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxDevUsername = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.panelEditable = new System.Windows.Forms.Panel();
            this.textBoxAdmin = new System.Windows.Forms.TextBox();
            this.textBoxDevId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelManupulation = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelOptionsUserManage = new System.Windows.Forms.Panel();
            this.tableLayoutPanelUserManager = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panelCrud.SuspendLayout();
            this.panelDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panelEditable.SuspendLayout();
            this.panelManupulation.SuspendLayout();
            this.panelOptionsUserManage.SuspendLayout();
            this.tableLayoutPanelUserManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelCrud);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(1100, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(372, 67);
            this.panelButtons.TabIndex = 2;
            // 
            // panelCrud
            // 
            this.panelCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.panelCrud.Controls.Add(this.buttonDelete);
            this.panelCrud.Controls.Add(this.buttonNewUser);
            this.panelCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrud.Location = new System.Drawing.Point(0, 0);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(372, 67);
            this.panelCrud.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(254, 9);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 47);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.panelDataTable.Size = new System.Drawing.Size(1091, 595);
            this.panelDataTable.TabIndex = 0;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDevID,
            this.dgvAdminUsername,
            this.dgvDevUserName,
            this.dgvDevFullName,
            this.dgvDevEmail,
            this.dgvDevPassword});
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(1091, 595);
            this.dgvTable.TabIndex = 8;
            // 
            // dgvDevID
            // 
            this.dgvDevID.DataPropertyName = "DevID";
            this.dgvDevID.HeaderText = "DevId";
            this.dgvDevID.MinimumWidth = 6;
            this.dgvDevID.Name = "dgvDevID";
            this.dgvDevID.ReadOnly = true;
            // 
            // dgvAdminUsername
            // 
            this.dgvAdminUsername.DataPropertyName = "AdminUsername";
            this.dgvAdminUsername.HeaderText = "AdminUserName";
            this.dgvAdminUsername.MinimumWidth = 6;
            this.dgvAdminUsername.Name = "dgvAdminUsername";
            this.dgvAdminUsername.ReadOnly = true;
            // 
            // dgvDevUserName
            // 
            this.dgvDevUserName.DataPropertyName = "DevUserName";
            this.dgvDevUserName.HeaderText = "Username";
            this.dgvDevUserName.MinimumWidth = 6;
            this.dgvDevUserName.Name = "dgvDevUserName";
            this.dgvDevUserName.ReadOnly = true;
            // 
            // dgvDevFullName
            // 
            this.dgvDevFullName.DataPropertyName = "DevFullName";
            this.dgvDevFullName.HeaderText = "Full Name";
            this.dgvDevFullName.MinimumWidth = 6;
            this.dgvDevFullName.Name = "dgvDevFullName";
            this.dgvDevFullName.ReadOnly = true;
            // 
            // dgvDevEmail
            // 
            this.dgvDevEmail.DataPropertyName = "DevEmail";
            this.dgvDevEmail.HeaderText = "Email";
            this.dgvDevEmail.MinimumWidth = 6;
            this.dgvDevEmail.Name = "dgvDevEmail";
            this.dgvDevEmail.ReadOnly = true;
            // 
            // dgvDevPassword
            // 
            this.dgvDevPassword.DataPropertyName = "DevPassword";
            this.dgvDevPassword.HeaderText = "Password";
            this.dgvDevPassword.MinimumWidth = 6;
            this.dgvDevPassword.Name = "dgvDevPassword";
            this.dgvDevPassword.ReadOnly = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(35, 210);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 28);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(126, 204);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(241, 34);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxDevPassword
            // 
            this.textBoxDevPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDevPassword.Location = new System.Drawing.Point(136, 332);
            this.textBoxDevPassword.Name = "textBoxDevPassword";
            this.textBoxDevPassword.Size = new System.Drawing.Size(231, 34);
            this.textBoxDevPassword.TabIndex = 10;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(23, 336);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 28);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(126, 140);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(241, 34);
            this.textBoxFullName.TabIndex = 7;
            // 
            // textBoxDevUsername
            // 
            this.textBoxDevUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDevUsername.Location = new System.Drawing.Point(126, 76);
            this.textBoxDevUsername.Name = "textBoxDevUsername";
            this.textBoxDevUsername.Size = new System.Drawing.Size(241, 34);
            this.textBoxDevUsername.TabIndex = 6;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(16, 146);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(104, 28);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
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
            // panelEditable
            // 
            this.panelEditable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelEditable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditable.Controls.Add(this.label2);
            this.panelEditable.Controls.Add(this.labelEmail);
            this.panelEditable.Controls.Add(this.textBoxEmail);
            this.panelEditable.Controls.Add(this.textBoxAdmin);
            this.panelEditable.Controls.Add(this.textBoxDevPassword);
            this.panelEditable.Controls.Add(this.labelPassword);
            this.panelEditable.Controls.Add(this.textBoxFullName);
            this.panelEditable.Controls.Add(this.textBoxDevId);
            this.panelEditable.Controls.Add(this.textBoxDevUsername);
            this.panelEditable.Controls.Add(this.labelFullName);
            this.panelEditable.Controls.Add(this.label1);
            this.panelEditable.Controls.Add(this.labelUserName);
            this.panelEditable.Controls.Add(this.buttonSaveUser);
            this.panelEditable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditable.Location = new System.Drawing.Point(0, 0);
            this.panelEditable.Name = "panelEditable";
            this.panelEditable.Size = new System.Drawing.Size(372, 595);
            this.panelEditable.TabIndex = 5;
            // 
            // textBoxAdmin
            // 
            this.textBoxAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdmin.Location = new System.Drawing.Point(135, 268);
            this.textBoxAdmin.Name = "textBoxAdmin";
            this.textBoxAdmin.Size = new System.Drawing.Size(232, 34);
            this.textBoxAdmin.TabIndex = 10;
            // 
            // textBoxDevId
            // 
            this.textBoxDevId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDevId.Location = new System.Drawing.Point(126, 12);
            this.textBoxDevId.Name = "textBoxDevId";
            this.textBoxDevId.ReadOnly = true;
            this.textBoxDevId.Size = new System.Drawing.Size(241, 34);
            this.textBoxDevId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "DevId";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(19, 79);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(104, 28);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Username";
            // 
            // panelManupulation
            // 
            this.panelManupulation.Controls.Add(this.panelEditable);
            this.panelManupulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManupulation.Location = new System.Drawing.Point(1100, 76);
            this.panelManupulation.Name = "panelManupulation";
            this.panelManupulation.Size = new System.Drawing.Size(372, 595);
            this.panelManupulation.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(487, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(340, 41);
            this.textBoxSearch.TabIndex = 4;
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
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            // panelOptionsUserManage
            // 
            this.panelOptionsUserManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.panelOptionsUserManage.Controls.Add(this.textBoxSearch);
            this.panelOptionsUserManage.Controls.Add(this.buttonSearch);
            this.panelOptionsUserManage.Controls.Add(this.buttonRefresh);
            this.panelOptionsUserManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOptionsUserManage.Location = new System.Drawing.Point(3, 3);
            this.panelOptionsUserManage.Name = "panelOptionsUserManage";
            this.panelOptionsUserManage.Size = new System.Drawing.Size(1091, 67);
            this.panelOptionsUserManage.TabIndex = 9;
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
            this.tableLayoutPanelUserManager.Size = new System.Drawing.Size(1475, 674);
            this.tableLayoutPanelUserManager.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "AdminUserName:";
            // 
            // UserControlDevlopers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelUserManager);
            this.Name = "UserControlDevlopers";
            this.Size = new System.Drawing.Size(1475, 674);
            this.panelButtons.ResumeLayout(false);
            this.panelCrud.ResumeLayout(false);
            this.panelDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panelEditable.ResumeLayout(false);
            this.panelEditable.PerformLayout();
            this.panelManupulation.ResumeLayout(false);
            this.panelOptionsUserManage.ResumeLayout(false);
            this.panelOptionsUserManage.PerformLayout();
            this.tableLayoutPanelUserManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelCrud;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Panel panelDataTable;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDevPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxDevUsername;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Panel panelEditable;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panelManupulation;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panelOptionsUserManage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserManager;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox textBoxDevId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDevID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAdminUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDevUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDevFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDevEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDevPassword;
        private System.Windows.Forms.TextBox textBoxAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
