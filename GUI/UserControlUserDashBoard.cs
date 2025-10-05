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
   public partial class UserControlUserDashBoard : UserControl
{
    private int currentUserId;

    public UserControlUserDashBoard(int userId) // <-- parameter
    {
        InitializeComponent();
        currentUserId = userId; // এখন ঠিক আছে
        this.Load += UserControlDashBoard_Load;
    }

        private void UserControlDashBoard_Load(object sender, EventArgs e)
        {
            LoadUserProjectsChart(currentUserId);
        }

        private void LoadUserProjectsChart(int userId)
        {
            try
            {
                string query = @"
                    SELECT pl.LanguageName, COUNT(pr.RequestID) AS TotalProjects
                    FROM ProjectRequest pr
                    LEFT JOIN ProjectLanguage pl ON pr.LanguageID = pl.LanguageID
                    WHERE pr.UserID = @UserID
                    GROUP BY pl.LanguageName
                ";

                var parameters = DataBase.CreateParameters(("@UserID", userId));
                DataTable dt = DataBase.GetDataTable(query, parameters);

                chartUser.Series.Clear();
                chartUser.Titles.Clear();

                Series series = new Series("User Projects");
                series.ChartType = SeriesChartType.Pie; // Pie Chart
                series.IsValueShownAsLabel = true;

                Color[] sliceColors = { Color.CornflowerBlue, Color.Orange, Color.MediumSeaGreen, Color.Goldenrod, Color.Tomato };
                int colorIndex = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string language = row["LanguageName"].ToString();
                    int count = Convert.ToInt32(row["TotalProjects"]);

                    DataPoint point = new DataPoint();
                    point.AxisLabel = language;
                    point.YValues = new double[] { count };
                    point.Label = count.ToString();
                    point.Color = sliceColors[colorIndex % sliceColors.Length];

                    series.Points.Add(point);
                    colorIndex++;
                }

                chartUser.Series.Add(series);
                chartUser.Titles.Add("Your Projects by Language");
                chartUser.Legends[0].Docking = Docking.Right;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user projects chart: " + ex.Message, "Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
