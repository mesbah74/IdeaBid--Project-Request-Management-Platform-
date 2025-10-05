namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class UserControlProjectBoard
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
            this.tableLayoutPanelProjectBoard = new System.Windows.Forms.TableLayoutPanel();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.dataGridViewProjectBoard = new System.Windows.Forms.DataGridView();
            this.dgvRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPostedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonResponse = new System.Windows.Forms.Button();
            this.tableLayoutPanelProjectBoard.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectBoard)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelProjectBoard
            // 
            this.tableLayoutPanelProjectBoard.ColumnCount = 1;
            this.tableLayoutPanelProjectBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProjectBoard.Controls.Add(this.panelDisplay, 0, 1);
            this.tableLayoutPanelProjectBoard.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanelProjectBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProjectBoard.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelProjectBoard.Name = "tableLayoutPanelProjectBoard";
            this.tableLayoutPanelProjectBoard.RowCount = 2;
            this.tableLayoutPanelProjectBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanelProjectBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProjectBoard.Size = new System.Drawing.Size(1167, 688);
            this.tableLayoutPanelProjectBoard.TabIndex = 0;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDisplay.Controls.Add(this.dataGridViewProjectBoard);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(3, 82);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1161, 603);
            this.panelDisplay.TabIndex = 1;
            // 
            // dataGridViewProjectBoard
            // 
            this.dataGridViewProjectBoard.AllowUserToAddRows = false;
            this.dataGridViewProjectBoard.AllowUserToDeleteRows = false;
            this.dataGridViewProjectBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProjectBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjectBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRequestID,
            this.dgvUserID,
            this.dgvCategory,
            this.dgvLanguage,
            this.dgvTitle,
            this.dgvDescription,
            this.dgvBudget,
            this.dgvDeadLine,
            this.dgvStatus,
            this.dgvPostedDate});
            this.dataGridViewProjectBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProjectBoard.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProjectBoard.Name = "dataGridViewProjectBoard";
            this.dataGridViewProjectBoard.ReadOnly = true;
            this.dataGridViewProjectBoard.RowHeadersWidth = 51;
            this.dataGridViewProjectBoard.RowTemplate.Height = 24;
            this.dataGridViewProjectBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjectBoard.Size = new System.Drawing.Size(1159, 601);
            this.dataGridViewProjectBoard.TabIndex = 0;
            this.dataGridViewProjectBoard.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewProjectBoard_DataBindingComplete);
            // 
            // dgvRequestID
            // 
            this.dgvRequestID.DataPropertyName = "RequestID";
            this.dgvRequestID.HeaderText = "Request ID";
            this.dgvRequestID.MinimumWidth = 6;
            this.dgvRequestID.Name = "dgvRequestID";
            this.dgvRequestID.ReadOnly = true;
            // 
            // dgvUserID
            // 
            this.dgvUserID.DataPropertyName = "UserID";
            this.dgvUserID.HeaderText = "User ID";
            this.dgvUserID.MinimumWidth = 6;
            this.dgvUserID.Name = "dgvUserID";
            this.dgvUserID.ReadOnly = true;
            // 
            // dgvCategory
            // 
            this.dgvCategory.DataPropertyName = "Category";
            this.dgvCategory.HeaderText = "Category";
            this.dgvCategory.MinimumWidth = 6;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            // 
            // dgvLanguage
            // 
            this.dgvLanguage.DataPropertyName = "Languages";
            this.dgvLanguage.HeaderText = "Language";
            this.dgvLanguage.MinimumWidth = 6;
            this.dgvLanguage.Name = "dgvLanguage";
            this.dgvLanguage.ReadOnly = true;
            // 
            // dgvTitle
            // 
            this.dgvTitle.DataPropertyName = "Title";
            this.dgvTitle.HeaderText = "Title";
            this.dgvTitle.MinimumWidth = 6;
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.ReadOnly = true;
            // 
            // dgvDescription
            // 
            this.dgvDescription.DataPropertyName = "Description";
            this.dgvDescription.HeaderText = "Description";
            this.dgvDescription.MinimumWidth = 6;
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // dgvBudget
            // 
            this.dgvBudget.DataPropertyName = "Budget";
            this.dgvBudget.HeaderText = "Budget";
            this.dgvBudget.MinimumWidth = 6;
            this.dgvBudget.Name = "dgvBudget";
            this.dgvBudget.ReadOnly = true;
            // 
            // dgvDeadLine
            // 
            this.dgvDeadLine.DataPropertyName = "Deadline";
            this.dgvDeadLine.HeaderText = "Dead Line";
            this.dgvDeadLine.MinimumWidth = 6;
            this.dgvDeadLine.Name = "dgvDeadLine";
            this.dgvDeadLine.ReadOnly = true;
            // 
            // dgvStatus
            // 
            this.dgvStatus.DataPropertyName = "Status";
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.MinimumWidth = 6;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            // 
            // dgvPostedDate
            // 
            this.dgvPostedDate.DataPropertyName = "PostedDate";
            this.dgvPostedDate.HeaderText = "Posted Date";
            this.dgvPostedDate.MinimumWidth = 6;
            this.dgvPostedDate.Name = "dgvPostedDate";
            this.dgvPostedDate.ReadOnly = true;
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Controls.Add(this.buttonSearch);
            this.panelTop.Controls.Add(this.buttonRefresh);
            this.panelTop.Controls.Add(this.buttonResponse);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1161, 73);
            this.panelTop.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(678, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(529, 43);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(558, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 52);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Teal;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(21, 9);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(154, 52);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonResponse
            // 
            this.buttonResponse.BackColor = System.Drawing.Color.Teal;
            this.buttonResponse.FlatAppearance.BorderSize = 0;
            this.buttonResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResponse.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResponse.ForeColor = System.Drawing.Color.White;
            this.buttonResponse.Location = new System.Drawing.Point(220, 8);
            this.buttonResponse.Name = "buttonResponse";
            this.buttonResponse.Size = new System.Drawing.Size(188, 52);
            this.buttonResponse.TabIndex = 0;
            this.buttonResponse.Text = "Respond Now";
            this.buttonResponse.UseVisualStyleBackColor = false;
            this.buttonResponse.Click += new System.EventHandler(this.buttonResponse_Click);
            // 
            // UserControlProjectBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelProjectBoard);
            this.Name = "UserControlProjectBoard";
            this.Size = new System.Drawing.Size(1167, 688);
            this.Load += new System.EventHandler(this.UserControlProjectBoard_Load);
            this.tableLayoutPanelProjectBoard.ResumeLayout(false);
            this.panelDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectBoard)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProjectBoard;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonResponse;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewProjectBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPostedDate;
    }
}
