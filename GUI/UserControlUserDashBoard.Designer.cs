namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    partial class UserControlUserDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartUser)).BeginInit();
            this.SuspendLayout();
            // 
            // chartUser
            // 
            this.chartUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.chartUser.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUser.Legends.Add(legend1);
            this.chartUser.Location = new System.Drawing.Point(139, 154);
            this.chartUser.Name = "chartUser";
            this.chartUser.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartUser.Series.Add(series1);
            this.chartUser.Size = new System.Drawing.Size(300, 300);
            this.chartUser.TabIndex = 0;
            this.chartUser.Text = "chartuser";
            // 
            // UserControlUserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartUser);
            this.Name = "UserControlUserDashBoard";
            this.Size = new System.Drawing.Size(1400, 661);
            ((System.ComponentModel.ISupportInitialize)(this.chartUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUser;
    }
}
