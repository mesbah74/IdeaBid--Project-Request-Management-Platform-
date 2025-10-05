namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class UserControlOurResponses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelOurResponses = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroGridDisplayResponses = new MetroFramework.Controls.MetroGrid();
            this.dgvResponseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProposalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProposalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFeedBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanelOurResponses.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDisplayResponses)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOurResponses
            // 
            this.tableLayoutPanelOurResponses.ColumnCount = 1;
            this.tableLayoutPanelOurResponses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOurResponses.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanelOurResponses.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanelOurResponses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOurResponses.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOurResponses.Name = "tableLayoutPanelOurResponses";
            this.tableLayoutPanelOurResponses.RowCount = 2;
            this.tableLayoutPanelOurResponses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanelOurResponses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOurResponses.Size = new System.Drawing.Size(1167, 688);
            this.tableLayoutPanelOurResponses.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroGridDisplayResponses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 609);
            this.panel1.TabIndex = 1;
            // 
            // metroGridDisplayResponses
            // 
            this.metroGridDisplayResponses.AllowUserToAddRows = false;
            this.metroGridDisplayResponses.AllowUserToDeleteRows = false;
            this.metroGridDisplayResponses.AllowUserToResizeRows = false;
            this.metroGridDisplayResponses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridDisplayResponses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDisplayResponses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridDisplayResponses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridDisplayResponses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDisplayResponses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridDisplayResponses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridDisplayResponses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvResponseID,
            this.dgvRequestID,
            this.dgvDevID,
            this.dgvAdminID,
            this.dgvProposalDate,
            this.dgvProposalAmount,
            this.dgvDeadLine,
            this.dgvFeedBack,
            this.dgvStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridDisplayResponses.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridDisplayResponses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridDisplayResponses.EnableHeadersVisualStyles = false;
            this.metroGridDisplayResponses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridDisplayResponses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDisplayResponses.Location = new System.Drawing.Point(0, 0);
            this.metroGridDisplayResponses.Name = "metroGridDisplayResponses";
            this.metroGridDisplayResponses.ReadOnly = true;
            this.metroGridDisplayResponses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDisplayResponses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridDisplayResponses.RowHeadersWidth = 51;
            this.metroGridDisplayResponses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridDisplayResponses.RowTemplate.Height = 24;
            this.metroGridDisplayResponses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridDisplayResponses.Size = new System.Drawing.Size(1159, 607);
            this.metroGridDisplayResponses.TabIndex = 0;
            this.metroGridDisplayResponses.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.metroGridDisplayResponses_DataBindingComplete);
            // 
            // dgvResponseID
            // 
            this.dgvResponseID.DataPropertyName = "ResponseID";
            this.dgvResponseID.HeaderText = "Response ID";
            this.dgvResponseID.MinimumWidth = 6;
            this.dgvResponseID.Name = "dgvResponseID";
            this.dgvResponseID.ReadOnly = true;
            // 
            // dgvRequestID
            // 
            this.dgvRequestID.DataPropertyName = "RequestID";
            this.dgvRequestID.HeaderText = "Request ID";
            this.dgvRequestID.MinimumWidth = 6;
            this.dgvRequestID.Name = "dgvRequestID";
            this.dgvRequestID.ReadOnly = true;
            // 
            // dgvDevID
            // 
            this.dgvDevID.DataPropertyName = "DevID";
            this.dgvDevID.HeaderText = "Dev ID";
            this.dgvDevID.MinimumWidth = 6;
            this.dgvDevID.Name = "dgvDevID";
            this.dgvDevID.ReadOnly = true;
            // 
            // dgvAdminID
            // 
            this.dgvAdminID.DataPropertyName = "AdminID";
            this.dgvAdminID.HeaderText = "Admin ID";
            this.dgvAdminID.MinimumWidth = 6;
            this.dgvAdminID.Name = "dgvAdminID";
            this.dgvAdminID.ReadOnly = true;
            // 
            // dgvProposalDate
            // 
            this.dgvProposalDate.DataPropertyName = "ProposalDate";
            this.dgvProposalDate.HeaderText = "Proposal Date";
            this.dgvProposalDate.MinimumWidth = 6;
            this.dgvProposalDate.Name = "dgvProposalDate";
            this.dgvProposalDate.ReadOnly = true;
            // 
            // dgvProposalAmount
            // 
            this.dgvProposalAmount.DataPropertyName = "ProposalAmount";
            this.dgvProposalAmount.HeaderText = "Proposal Amount";
            this.dgvProposalAmount.MinimumWidth = 6;
            this.dgvProposalAmount.Name = "dgvProposalAmount";
            this.dgvProposalAmount.ReadOnly = true;
            // 
            // dgvDeadLine
            // 
            this.dgvDeadLine.DataPropertyName = "Deadline";
            this.dgvDeadLine.HeaderText = "Dead-LIne";
            this.dgvDeadLine.MinimumWidth = 6;
            this.dgvDeadLine.Name = "dgvDeadLine";
            this.dgvDeadLine.ReadOnly = true;
            // 
            // dgvFeedBack
            // 
            this.dgvFeedBack.DataPropertyName = "Feedback";
            this.dgvFeedBack.HeaderText = "FeedBack";
            this.dgvFeedBack.MinimumWidth = 6;
            this.dgvFeedBack.Name = "dgvFeedBack";
            this.dgvFeedBack.ReadOnly = true;
            // 
            // dgvStatus
            // 
            this.dgvStatus.DataPropertyName = "StatusName";
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.MinimumWidth = 6;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Controls.Add(this.buttonSearch);
            this.panelTop.Controls.Add(this.buttonUpdate);
            this.panelTop.Controls.Add(this.buttonRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1161, 67);
            this.panelTop.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(667, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(551, 41);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(535, 7);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(124, 45);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Teal;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(179, 10);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 44);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Teal;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(23, 11);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(119, 44);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UserControlOurResponses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelOurResponses);
            this.Name = "UserControlOurResponses";
            this.Size = new System.Drawing.Size(1167, 688);
            this.Load += new System.EventHandler(this.UserControlOurResponses_Load);
            this.tableLayoutPanelOurResponses.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDisplayResponses)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOurResponses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private MetroFramework.Controls.MetroGrid metroGridDisplayResponses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResponseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDevID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAdminID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProposalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProposalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFeedBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
    }
}
