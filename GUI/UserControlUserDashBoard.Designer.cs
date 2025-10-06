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
            this.chartPro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPro)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPro
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPro.ChartAreas.Add(chartArea1);
            this.chartPro.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartPro.Legends.Add(legend1);
            this.chartPro.Location = new System.Drawing.Point(0, 0);
            this.chartPro.Name = "chartPro";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPro.Series.Add(series1);
            this.chartPro.Size = new System.Drawing.Size(1400, 661);
            this.chartPro.TabIndex = 0;
            this.chartPro.Text = "chart1";
            // 
            // UserControlUserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartPro);
            this.Name = "UserControlUserDashBoard";
            this.Size = new System.Drawing.Size(1400, 661);
            ((System.ComponentModel.ISupportInitialize)(this.chartPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPro;
    }
}
