namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class FormNewResponed
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewResponed));
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelResponseID = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.labelExpectedDeadline = new System.Windows.Forms.Label();
            this.labelProposalAmount = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxResponseID = new System.Windows.Forms.TextBox();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.textBoxProposalAmount = new System.Windows.Forms.TextBox();
            this.metroDateTimeExpectedDate = new MetroFramework.Controls.MetroDateTime();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelRequestID = new System.Windows.Forms.Label();
            this.textBoxRequestID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(36, 731);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(141, 50);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Location = new System.Drawing.Point(343, 731);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 50);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Teal;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(539, 731);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(141, 50);
            this.buttonSend.TabIndex = 22;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(221, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(256, 45);
            this.labelTitle.TabIndex = 25;
            this.labelTitle.Text = "Response Form";
            // 
            // labelResponseID
            // 
            this.labelResponseID.AutoSize = true;
            this.labelResponseID.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponseID.Location = new System.Drawing.Point(35, 106);
            this.labelResponseID.Name = "labelResponseID";
            this.labelResponseID.Size = new System.Drawing.Size(142, 31);
            this.labelResponseID.TabIndex = 26;
            this.labelResponseID.Text = "Response ID";
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedback.Location = new System.Drawing.Point(35, 273);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(113, 31);
            this.labelFeedback.TabIndex = 27;
            this.labelFeedback.Text = "Feedback";
            // 
            // labelExpectedDeadline
            // 
            this.labelExpectedDeadline.AutoSize = true;
            this.labelExpectedDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpectedDeadline.Location = new System.Drawing.Point(35, 456);
            this.labelExpectedDeadline.Name = "labelExpectedDeadline";
            this.labelExpectedDeadline.Size = new System.Drawing.Size(207, 31);
            this.labelExpectedDeadline.TabIndex = 28;
            this.labelExpectedDeadline.Text = "Expected Deadline";
            // 
            // labelProposalAmount
            // 
            this.labelProposalAmount.AutoSize = true;
            this.labelProposalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProposalAmount.Location = new System.Drawing.Point(35, 389);
            this.labelProposalAmount.Name = "labelProposalAmount";
            this.labelProposalAmount.Size = new System.Drawing.Size(195, 31);
            this.labelProposalAmount.TabIndex = 29;
            this.labelProposalAmount.Text = "Proposal Amount";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(35, 523);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(77, 31);
            this.labelStatus.TabIndex = 30;
            this.labelStatus.Text = "Status";
            // 
            // textBoxResponseID
            // 
            this.textBoxResponseID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResponseID.Location = new System.Drawing.Point(269, 108);
            this.textBoxResponseID.Name = "textBoxResponseID";
            this.textBoxResponseID.ReadOnly = true;
            this.textBoxResponseID.Size = new System.Drawing.Size(411, 34);
            this.textBoxResponseID.TabIndex = 31;
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFeedback.Location = new System.Drawing.Point(269, 232);
            this.textBoxFeedback.Multiline = true;
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(411, 116);
            this.textBoxFeedback.TabIndex = 32;
            // 
            // textBoxProposalAmount
            // 
            this.textBoxProposalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProposalAmount.Location = new System.Drawing.Point(269, 389);
            this.textBoxProposalAmount.Name = "textBoxProposalAmount";
            this.textBoxProposalAmount.Size = new System.Drawing.Size(411, 34);
            this.textBoxProposalAmount.TabIndex = 33;
            // 
            // metroDateTimeExpectedDate
            // 
            this.metroDateTimeExpectedDate.Location = new System.Drawing.Point(269, 464);
            this.metroDateTimeExpectedDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimeExpectedDate.Name = "metroDateTimeExpectedDate";
            this.metroDateTimeExpectedDate.Size = new System.Drawing.Size(411, 30);
            this.metroDateTimeExpectedDate.TabIndex = 34;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(269, 529);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(411, 36);
            this.comboBoxStatus.TabIndex = 35;
            // 
            // labelRequestID
            // 
            this.labelRequestID.AutoSize = true;
            this.labelRequestID.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestID.Location = new System.Drawing.Point(35, 177);
            this.labelRequestID.Name = "labelRequestID";
            this.labelRequestID.Size = new System.Drawing.Size(126, 31);
            this.labelRequestID.TabIndex = 36;
            this.labelRequestID.Text = "Request ID";
            // 
            // textBoxRequestID
            // 
            this.textBoxRequestID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestID.Location = new System.Drawing.Point(269, 177);
            this.textBoxRequestID.Name = "textBoxRequestID";
            this.textBoxRequestID.ReadOnly = true;
            this.textBoxRequestID.Size = new System.Drawing.Size(411, 34);
            this.textBoxRequestID.TabIndex = 37;
            // 
            // FormNewResponed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 836);
            this.Controls.Add(this.textBoxRequestID);
            this.Controls.Add(this.labelRequestID);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.metroDateTimeExpectedDate);
            this.Controls.Add(this.textBoxProposalAmount);
            this.Controls.Add(this.textBoxFeedback);
            this.Controls.Add(this.textBoxResponseID);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelProposalAmount);
            this.Controls.Add(this.labelExpectedDeadline);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelResponseID);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewResponed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewResponed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewResponed_FormClosing);
            this.Load += new System.EventHandler(this.FormNewResponed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelResponseID;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Label labelExpectedDeadline;
        private System.Windows.Forms.Label labelProposalAmount;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxResponseID;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.TextBox textBoxProposalAmount;
        private MetroFramework.Controls.MetroDateTime metroDateTimeExpectedDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelRequestID;
        private System.Windows.Forms.TextBox textBoxRequestID;
    }
}