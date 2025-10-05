using MetroFramework.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class UserControlProjectRequestFromUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridForRequestProject = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanelProjectRequest = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanelForGrid = new MetroFramework.Controls.MetroPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonViewResponse = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.buttonNewRequest = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dgvRequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBudgetOffered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPostedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridForRequestProject)).BeginInit();
            this.tableLayoutPanelProjectRequest.SuspendLayout();
            this.metroPanelForGrid.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridForRequestProject
            // 
            this.metroGridForRequestProject.AllowUserToAddRows = false;
            this.metroGridForRequestProject.AllowUserToDeleteRows = false;
            this.metroGridForRequestProject.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.metroGridForRequestProject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridForRequestProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridForRequestProject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridForRequestProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridForRequestProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridForRequestProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridForRequestProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridForRequestProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridForRequestProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRequestId,
            this.dgvcategory,
            this.dgvLanguage,
            this.dgvTitle,
            this.dgvDescription,
            this.dgvBudgetOffered,
            this.dgvDeadLine,
            this.dgvStatus,
            this.dgvPostedDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridForRequestProject.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridForRequestProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridForRequestProject.EnableHeadersVisualStyles = false;
            this.metroGridForRequestProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridForRequestProject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridForRequestProject.Location = new System.Drawing.Point(0, 0);
            this.metroGridForRequestProject.MultiSelect = false;
            this.metroGridForRequestProject.Name = "metroGridForRequestProject";
            this.metroGridForRequestProject.ReadOnly = true;
            this.metroGridForRequestProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridForRequestProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridForRequestProject.RowHeadersWidth = 51;
            this.metroGridForRequestProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridForRequestProject.RowTemplate.Height = 24;
            this.metroGridForRequestProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridForRequestProject.Size = new System.Drawing.Size(1484, 593);
            this.metroGridForRequestProject.TabIndex = 3;
            this.metroGridForRequestProject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridForRequestProject_CellDoubleClick);
            // 
            // tableLayoutPanelProjectRequest
            // 
            this.tableLayoutPanelProjectRequest.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelProjectRequest.ColumnCount = 1;
            this.tableLayoutPanelProjectRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProjectRequest.Controls.Add(this.metroPanelForGrid, 0, 1);
            this.tableLayoutPanelProjectRequest.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanelProjectRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProjectRequest.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelProjectRequest.Name = "tableLayoutPanelProjectRequest";
            this.tableLayoutPanelProjectRequest.RowCount = 2;
            this.tableLayoutPanelProjectRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanelProjectRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProjectRequest.Size = new System.Drawing.Size(1490, 665);
            this.tableLayoutPanelProjectRequest.TabIndex = 0;
            // 
            // metroPanelForGrid
            // 
            this.metroPanelForGrid.Controls.Add(this.metroGridForRequestProject);
            this.metroPanelForGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelForGrid.HorizontalScrollbarBarColor = true;
            this.metroPanelForGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelForGrid.HorizontalScrollbarSize = 10;
            this.metroPanelForGrid.Location = new System.Drawing.Point(3, 69);
            this.metroPanelForGrid.Name = "metroPanelForGrid";
            this.metroPanelForGrid.Size = new System.Drawing.Size(1484, 593);
            this.metroPanelForGrid.TabIndex = 4;
            this.metroPanelForGrid.VerticalScrollbarBarColor = true;
            this.metroPanelForGrid.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelForGrid.VerticalScrollbarSize = 10;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.panelTop.Controls.Add(this.buttonViewResponse);
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Controls.Add(this.buttonSearch);
            this.panelTop.Controls.Add(this.ButtonDelete);
            this.panelTop.Controls.Add(this.buttonNewRequest);
            this.panelTop.Controls.Add(this.buttonRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1484, 60);
            this.panelTop.TabIndex = 5;
            // 
            // buttonViewResponse
            // 
            this.buttonViewResponse.BackColor = System.Drawing.Color.Transparent;
            this.buttonViewResponse.FlatAppearance.BorderSize = 0;
            this.buttonViewResponse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonViewResponse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonViewResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewResponse.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewResponse.ForeColor = System.Drawing.Color.Lime;
            this.buttonViewResponse.Location = new System.Drawing.Point(519, 7);
            this.buttonViewResponse.Name = "buttonViewResponse";
            this.buttonViewResponse.Size = new System.Drawing.Size(226, 46);
            this.buttonViewResponse.TabIndex = 14;
            this.buttonViewResponse.Text = "View Response";
            this.buttonViewResponse.UseVisualStyleBackColor = false;
            this.buttonViewResponse.Click += new System.EventHandler(this.buttonViewResponse_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(917, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(322, 39);
            this.textBoxSearch.TabIndex = 13;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(784, 7);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(124, 45);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Red;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.ButtonDelete.Location = new System.Drawing.Point(163, 6);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(107, 46);
            this.ButtonDelete.TabIndex = 11;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonNewRequest
            // 
            this.buttonNewRequest.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewRequest.FlatAppearance.BorderSize = 0;
            this.buttonNewRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonNewRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewRequest.Font = new System.Drawing.Font("Segoe UI Black", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRequest.ForeColor = System.Drawing.Color.White;
            this.buttonNewRequest.Location = new System.Drawing.Point(297, 6);
            this.buttonNewRequest.Name = "buttonNewRequest";
            this.buttonNewRequest.Size = new System.Drawing.Size(192, 46);
            this.buttonNewRequest.TabIndex = 10;
            this.buttonNewRequest.Text = "New Request";
            this.buttonNewRequest.UseVisualStyleBackColor = false;
            this.buttonNewRequest.Click += new System.EventHandler(this.buttonNewRequest_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Thistle;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(20, 7);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(123, 46);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dgvRequestId
            // 
            this.dgvRequestId.DataPropertyName = "RequestID";
            this.dgvRequestId.FillWeight = 59F;
            this.dgvRequestId.HeaderText = "Reference";
            this.dgvRequestId.MinimumWidth = 6;
            this.dgvRequestId.Name = "dgvRequestId";
            this.dgvRequestId.ReadOnly = true;
            // 
            // dgvcategory
            // 
            this.dgvcategory.DataPropertyName = "Category";
            this.dgvcategory.FillWeight = 70F;
            this.dgvcategory.HeaderText = "Category";
            this.dgvcategory.MinimumWidth = 6;
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.ReadOnly = true;
            // 
            // dgvLanguage
            // 
            this.dgvLanguage.DataPropertyName = "Languages";
            this.dgvLanguage.FillWeight = 80F;
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
            this.dgvDescription.FillWeight = 130F;
            this.dgvDescription.HeaderText = "Description";
            this.dgvDescription.MinimumWidth = 6;
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // dgvBudgetOffered
            // 
            this.dgvBudgetOffered.DataPropertyName = "Budget";
            this.dgvBudgetOffered.FillWeight = 50F;
            this.dgvBudgetOffered.HeaderText = "Budget";
            this.dgvBudgetOffered.MinimumWidth = 6;
            this.dgvBudgetOffered.Name = "dgvBudgetOffered";
            this.dgvBudgetOffered.ReadOnly = true;
            // 
            // dgvDeadLine
            // 
            this.dgvDeadLine.DataPropertyName = "Deadline";
            this.dgvDeadLine.FillWeight = 70F;
            this.dgvDeadLine.HeaderText = "Dead Line";
            this.dgvDeadLine.MinimumWidth = 6;
            this.dgvDeadLine.Name = "dgvDeadLine";
            this.dgvDeadLine.ReadOnly = true;
            // 
            // dgvStatus
            // 
            this.dgvStatus.DataPropertyName = "Status";
            this.dgvStatus.FillWeight = 60F;
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.MinimumWidth = 6;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            // 
            // dgvPostedDate
            // 
            this.dgvPostedDate.DataPropertyName = "PostedDate";
            this.dgvPostedDate.FillWeight = 70F;
            this.dgvPostedDate.HeaderText = "Posted Date";
            this.dgvPostedDate.MinimumWidth = 6;
            this.dgvPostedDate.Name = "dgvPostedDate";
            this.dgvPostedDate.ReadOnly = true;
            // 
            // UserControlProjectRequestFromUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelProjectRequest);
            this.Name = "UserControlProjectRequestFromUser";
            this.Size = new System.Drawing.Size(1490, 665);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridForRequestProject)).EndInit();
            this.tableLayoutPanelProjectRequest.ResumeLayout(false);
            this.metroPanelForGrid.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridForRequestProject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProjectRequest;
        private MetroFramework.Controls.MetroPanel metroPanelForGrid;
        private Panel panelTop;
        private Button buttonRefresh;
        private Button buttonNewRequest;
        private Button ButtonDelete;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonViewResponse;
        private DataGridViewTextBoxColumn dgvRequestId;
        private DataGridViewTextBoxColumn dgvcategory;
        private DataGridViewTextBoxColumn dgvLanguage;
        private DataGridViewTextBoxColumn dgvTitle;
        private DataGridViewTextBoxColumn dgvDescription;
        private DataGridViewTextBoxColumn dgvBudgetOffered;
        private DataGridViewTextBoxColumn dgvDeadLine;
        private DataGridViewTextBoxColumn dgvStatus;
        private DataGridViewTextBoxColumn dgvPostedDate;
    }
}
