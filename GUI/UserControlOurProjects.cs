using IdeaBid__Project_Request___Management_Platform.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    public partial class UserControlOurProjects : UserControl
    {
        public UserControlOurProjects()
        {
            InitializeComponent();
        }

        public void LoadOurProjects(string search = null)
        {
            string query = @"
        SELECT 
            pr.RequestID,
              c.CategoryName,
            pr.Title,
            pr.BudgetOffered,
            s.StatusName
        FROM ProjectRequest pr
        LEFT JOIN Category c ON pr.CategoryID = c.CategoryID
        LEFT JOIN ProjectStatus s ON pr.StatusID = s.StatusID
        WHERE 1=1
          AND s.StatusName = @statusName
    ";

            SqlParameter[] pars;

            if (!string.IsNullOrWhiteSpace(search))
            {
                query += @"
            AND (
                CAST(pr.RequestID AS NVARCHAR(50)) LIKE @s
                OR pr.Title LIKE @s
            )";

                pars = DataBase.CreateParameters(
                    ("@statusName", "Completed"),   // filter for Completed projects (change value if needed)
                    ("@s", "%" + search + "%")
                );
            }
            else
            {
                pars = DataBase.CreateParameters(
                    ("@statusName", "Completed")
                );
            }

            query += " ORDER BY pr.RequestID DESC";

            DataTable dt = DataBase.GetDataTable(query, pars);

            dataGridViewOurProjects.AutoGenerateColumns = false;
            dataGridViewOurProjects.DataSource = dt;
            dataGridViewOurProjects.ClearSelection();
        }

        private void UserControlOurProjects_Load(object sender, EventArgs e)
        {
            this.LoadOurProjects();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.LoadOurProjects();
        }

        private void dataGridViewOurProjects_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewOurProjects.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.LoadOurProjects(textBoxSearch.Text.Trim());

        }

        private void dataGridViewOurProjects_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewOurProjects.ClearSelection();
            dataGridViewOurProjects.CurrentCell = null;
        }
    }
}
