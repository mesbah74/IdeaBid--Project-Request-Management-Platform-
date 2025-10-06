using IdeaBid__Project_Request___Management_Platform.DataBaseConnection;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    public partial class UserControlUserDashBoard : UserControl
    {
        public UserControlUserDashBoard()
        {
            InitializeComponent();
        }

        public void LoadProjectStatesChart(int userId)
        {
            string query = @"
                SELECT c.CategoryName, ps.StatusName, ps.StatusID, COUNT(pr.RequestID) AS Count
                FROM ProjectRequest pr
                INNER JOIN ProjectStatus ps ON pr.StatusID = ps.StatusID
                INNER JOIN Category c ON pr.CategoryID = c.CategoryID
                WHERE pr.UserID = @UserId
                GROUP BY c.CategoryName, ps.StatusName, ps.StatusID
                ORDER BY ps.StatusID, c.CategoryName";

            var parameters = DataBase.CreateParameters(("@UserId", userId));
            DataTable dt = DataBase.GetDataTable(query, parameters);

            chartPro.Series.Clear();
            chartPro.ChartAreas.Clear();
            chartPro.Legends.Clear();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No projects found for this user.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Chart Area
            ChartArea chartArea = new ChartArea("ChartArea1")
            {
                AxisX = { MajorGrid = { LineColor = Color.LightGray }, LabelStyle = { Font = new Font("Arial", 11, FontStyle.Regular) } },
                AxisY = { MajorGrid = { LineColor = Color.LightGray }, LabelStyle = { Font = new Font("Arial", 14, FontStyle.Bold) }, Interval = 1 }
            };

            chartArea.AxisX.Title = "";
            chartArea.AxisY.Title = "Project Status";
            chartPro.ChartAreas.Add(chartArea);

            var statuses = dt.AsEnumerable()
                             .OrderBy(r => Convert.ToInt32(r["StatusID"]))
                             .Select(r => r["StatusName"].ToString())
                             .Distinct()
                             .ToList();

            var categories = dt.AsEnumerable()
                               .Select(r => r["CategoryName"].ToString())
                               .Distinct()
                               .ToList();

            Color[] colors = { Color.Blue, Color.Red, Color.Green, Color.Orange, Color.Purple, Color.Brown, Color.Cyan, Color.Magenta };
            var categoryColors = categories.Select((c, i) => new { Name = c, Color = colors[i % colors.Length] })
                                           .ToDictionary(x => x.Name, x => x.Color);

            foreach (var category in categories)
            {
                Series series = new Series(category)
                {
                    ChartType = SeriesChartType.StackedBar,
                    IsValueShownAsLabel = true,
                    Color = categoryColors[category],
                    Font = new Font("Arial", 12, FontStyle.Bold) // Bar label font
                };

                foreach (var status in statuses)
                {
                    var row = dt.AsEnumerable()
                                .FirstOrDefault(r => r["StatusName"].ToString() == status &&
                                                     r["CategoryName"].ToString() == category);

                    int count = row != null ? Convert.ToInt32(row["Count"]) : 0;

                    int pointIndex = series.Points.AddXY(status, count);

                    if (count > 0)
                    {
                        series.Points[pointIndex].Label = category;
                        series.Points[pointIndex].LabelForeColor = Color.White;
                    }
                }

                chartPro.Series.Add(series);
            }

            chartPro.ChartAreas[0].RecalculateAxesScale();
            chartPro.Legends.Clear(); // remove legend
        }
    }
}
