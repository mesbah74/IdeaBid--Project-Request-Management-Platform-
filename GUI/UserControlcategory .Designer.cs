namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class UserControlcategory
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.panelDataTable = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelOptionsUserManage = new System.Windows.Forms.Panel();
            this.tableLayoutPanelUserManager = new System.Windows.Forms.TableLayoutPanel();
            this.panelEditable = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.dgvCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtons.SuspendLayout();
            this.panelCrud.SuspendLayout();
            this.panelDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panelOptionsUserManage.SuspendLayout();
            this.tableLayoutPanelUserManager.SuspendLayout();
            this.panelEditable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelCrud);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(983, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(489, 67);
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
            this.panelCrud.Size = new System.Drawing.Size(489, 67);
            this.panelCrud.TabIndex = 6;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(360, 9);
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
            this.panelDataTable.Size = new System.Drawing.Size(974, 595);
            this.panelDataTable.TabIndex = 0;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCategoryID,
            this.dgvCategoryName});
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(974, 595);
            this.dgvTable.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(360, 14);
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
            this.buttonSearch.Location = new System.Drawing.Point(227, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 53);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
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
            this.panelOptionsUserManage.Size = new System.Drawing.Size(974, 67);
            this.panelOptionsUserManage.TabIndex = 9;
            // 
            // tableLayoutPanelUserManager
            // 
            this.tableLayoutPanelUserManager.ColumnCount = 2;
            this.tableLayoutPanelUserManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 495F));
            this.tableLayoutPanelUserManager.Controls.Add(this.panelEditable, 1, 1);
            this.tableLayoutPanelUserManager.Controls.Add(this.panelOptionsUserManage, 0, 0);
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
            // panelEditable
            // 
            this.panelEditable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelEditable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditable.Controls.Add(this.textBoxID);
            this.panelEditable.Controls.Add(this.textBoxName);
            this.panelEditable.Controls.Add(this.label1);
            this.panelEditable.Controls.Add(this.labelUserName);
            this.panelEditable.Controls.Add(this.buttonSaveUser);
            this.panelEditable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditable.Location = new System.Drawing.Point(983, 76);
            this.panelEditable.Name = "panelEditable";
            this.panelEditable.Size = new System.Drawing.Size(489, 595);
            this.panelEditable.TabIndex = 5;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(163, 17);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(300, 34);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(163, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(300, 34);
            this.textBoxName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "category Id:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(9, 64);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(153, 28);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "category name:";
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.BackColor = System.Drawing.Color.Teal;
            this.buttonSaveUser.FlatAppearance.BorderSize = 0;
            this.buttonSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUser.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveUser.Location = new System.Drawing.Point(14, 144);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(459, 52);
            this.buttonSaveUser.TabIndex = 0;
            this.buttonSaveUser.Text = "Save";
            this.buttonSaveUser.UseVisualStyleBackColor = false;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // dgvCategoryID
            // 
            this.dgvCategoryID.DataPropertyName = "CategoryID";
            this.dgvCategoryID.HeaderText = "CategoryID";
            this.dgvCategoryID.MinimumWidth = 6;
            this.dgvCategoryID.Name = "dgvCategoryID";
            this.dgvCategoryID.ReadOnly = true;
            // 
            // dgvCategoryName
            // 
            this.dgvCategoryName.DataPropertyName = "CategoryName";
            this.dgvCategoryName.HeaderText = "CategoryName";
            this.dgvCategoryName.MinimumWidth = 6;
            this.dgvCategoryName.Name = "dgvCategoryName";
            this.dgvCategoryName.ReadOnly = true;
            // 
            // UserControlcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelUserManager);
            this.Name = "UserControlcategory";
            this.Size = new System.Drawing.Size(1475, 674);
            this.panelButtons.ResumeLayout(false);
            this.panelCrud.ResumeLayout(false);
            this.panelDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panelOptionsUserManage.ResumeLayout(false);
            this.panelOptionsUserManage.PerformLayout();
            this.tableLayoutPanelUserManager.ResumeLayout(false);
            this.panelEditable.ResumeLayout(false);
            this.panelEditable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelCrud;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Panel panelDataTable;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panelOptionsUserManage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserManager;
        private System.Windows.Forms.Panel panelEditable;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoryName;
    }
}
