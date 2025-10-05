using IdeaBid__Project_Request___Management_Platform.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    public partial class UserControlDashBoard : UserControl
    {
        public UserControlDashBoard()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserTypeChart(); // তোমার chart function টা এখানে কল করো
        }





        private void LoadUserTypeChart()
        {
            try
            {
                // 🔹 SQL Query: প্রতিটি UserType অনুযায়ী user সংখ্যা
                string query = @"SELECT UserType, COUNT(*) AS TotalUsers 
                                 FROM UserInfo
                                 GROUP BY UserType";

                // 🔹 Data আনো database helper class থেকে
                DataTable dt = DataBase.GetDataTable(query);

                // 🔹 Chart পরিষ্কার করো
                chart1.Series.Clear();
                chart1.Titles.Clear();

                // 🔹 Series তৈরি করো
                Series series = new Series("User Type Count");
                series.ChartType = SeriesChartType.Bar; // Horizontal bar chart
                series.IsValueShownAsLabel = true;
                series.Color = System.Drawing.Color.CornflowerBlue;

                // 🔹 Data chart এ যোগ করো
                foreach (DataRow row in dt.Rows)
                {
                    string userType = row["UserType"].ToString();
                    int count = Convert.ToInt32(row["TotalUsers"]);
                    series.Points.AddXY(userType, count);
                }

                // 🔹 Chart সেটআপ করো
                chart1.Series.Add(series);
                chart1.Titles.Add("Users by Type");
                chart1.ChartAreas[0].AxisX.Title = "User Type";
                chart1.ChartAreas[0].AxisY.Title = "Number of Users";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message, "Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
