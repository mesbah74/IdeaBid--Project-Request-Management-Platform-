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
    public partial class UserControlProjectBoard : UserControl
    {
        public UserControlProjectBoard()
        {
            InitializeComponent();
        }



        public void LoadRequests(string search = null)
        {
            

            string sql = @"
        SELECT
            pr.RequestID,
            pr.UserID,
            c.CategoryName   AS Category,
            pr.Languages     AS Languages,   -- now coming directly from ProjectRequest
            pr.Title,
            pr.Description,
            pr.BudgetOffered AS Budget,
            pr.Deadline      AS Deadline,
            s.StatusName     AS Status,
            pr.PostedDate    AS PostedDate
        FROM ProjectRequest pr
        JOIN Category c ON pr.CategoryID = c.CategoryID
        JOIN ProjectStatus s ON pr.StatusID = s.StatusID
    ";

            SqlParameter[] pars = null;

            if (!string.IsNullOrWhiteSpace(search))
            {
                sql += @"
            AND (
                CAST(pr.RequestID AS NVARCHAR(50)) LIKE @s
                OR pr.Title LIKE @s
                OR c.CategoryName LIKE @s
                OR pr.UserID LIKE @s
            )";

                pars = DataBase.CreateParameters(("@s", $"%{search}%"));
            }

            sql += " ORDER BY pr.StatusID ASC";

            DataTable dt = (pars == null)
                ? DataBase.GetDataTable(sql)
                : DataBase.GetDataTable(sql, pars);

            dataGridViewProjectBoard.AutoGenerateColumns = false;
            dataGridViewProjectBoard.DataSource = dt;
            dataGridViewProjectBoard.ClearSelection();
            
        }

        private void UserControlProjectBoard_Load(object sender, EventArgs e)
        {
            this.LoadRequests();
        }

        private void buttonResponse_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectBoard.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int requestId = Convert.ToInt32(dataGridViewProjectBoard.SelectedRows[0].Cells["dgvRequestID"].Value);

            using (var form = new FormNewResponed(FormControlPortal.LoggedInUser, FormControlPortal.Role, requestId))
            {
                if (form.ShowDialog() == DialogResult.OK)  
                {
                    LoadRequests(); 
                }
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.LoadRequests();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.LoadRequests(textBoxSearch.Text.Trim());
        }

        private void dataGridViewProjectBoard_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewProjectBoard.ClearSelection();
            dataGridViewProjectBoard.CurrentCell = null;
        }
    }
}
