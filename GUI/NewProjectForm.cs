using IdeaBid__Project_Request___Management_Platform.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaBid__Project_Request___Management_Platform.GUI
{
    public partial class NewProjectForm : Form
    {
        private readonly int _currentUserId;
        private readonly bool _isEdit;
        private readonly int _requestId;

        public NewProjectForm(int currentUserId)
        {
            InitializeComponent();
            _currentUserId = currentUserId;
            _isEdit = false;
        }

        public NewProjectForm(int currentUserId, int requestId) : this(currentUserId)
        {
            _isEdit = true;
            _requestId = requestId;
        }

        private void NewProjectForm_Load(object sender, EventArgs e)
        {
            if (!_isEdit)
                textBoxRequestID.Text = "Auto Generated";

            // Category load
            string sql = "SELECT CategoryID, CategoryName FROM Category ORDER BY CategoryName";
            DataTable dt = DataBase.GetDataTable(sql);
            if (dt != null)
            {
                comboBoxCategory.DisplayMember = "CategoryName";
                comboBoxCategory.ValueMember = "CategoryID";
                comboBoxCategory.DataSource = dt;
                comboBoxCategory.SelectedIndex = -1;
            }

            // Deadline
            metroDateTimeDeadLIne.Format = DateTimePickerFormat.Custom;
            metroDateTimeDeadLIne.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            metroDateTimeDeadLIne.ShowCheckBox = true;
            metroDateTimeDeadLIne.Checked = false;
            metroDateTimeDeadLIne.Value = DateTime.Now.AddDays(7);

            if (_isEdit)
                LoadRequestData(_requestId);
        }

        private void LoadRequestData(int requestId)
        {
            string sql = @"SELECT * FROM ProjectRequest WHERE RequestID = @RequestID";
            var prms = DataBase.CreateParameters(("@RequestID", requestId));
            DataTable dt = DataBase.GetDataTable(sql, prms);
            if (dt == null || dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            textBoxRequestID.Text = r["RequestID"].ToString();
            comboBoxCategory.SelectedValue = r["CategoryID"];
            textBoxLanguages.Text = r["Languages"]?.ToString();
            textBoxTitle.Text = r["Title"]?.ToString();
            textBoxDescribe.Text = r["Description"]?.ToString();
            textBoxBudget.Text = r["BudgetOffered"]?.ToString();

            if (r["Deadline"] != DBNull.Value)
            {
                metroDateTimeDeadLIne.Value = Convert.ToDateTime(r["Deadline"]);
                metroDateTimeDeadLIne.Checked = true;
            }
            else
            {
                metroDateTimeDeadLIne.Checked = false;
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            // Validation
            if (comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Please enter a title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDescribe.Text))
            {
                MessageBox.Show("Please enter a description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);
            string languages = string.IsNullOrWhiteSpace(textBoxLanguages.Text) ? null : textBoxLanguages.Text.Trim();
            string title = textBoxTitle.Text.Trim();
            string description = textBoxDescribe.Text.Trim();
            //decimal? budget = decimal.TryParse(textBoxBudget.Text, out decimal b) ? b : (decimal?)null;
            decimal? budget = null;

            if (!string.IsNullOrWhiteSpace(textBoxBudget.Text))
            {
                if (decimal.TryParse(textBoxBudget.Text, out decimal b))
                {
                    budget = b;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Budget.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxBudget.Focus();
                    return; // stop saving
                }
            }

            DateTime? deadline = metroDateTimeDeadLIne.Checked ? metroDateTimeDeadLIne.Value : (DateTime?)null;

            try
            {
                // INSERT
                if (textBoxRequestID.Text == "Auto Generated" || !int.TryParse(textBoxRequestID.Text, out int requestId))
                {
                    string insertSql = @"
INSERT INTO ProjectRequest (UserID, CategoryID, Languages, Title, Description, BudgetOffered, Deadline)
VALUES (@UserID, @CategoryID, @Languages, @Title, @Description, @BudgetOffered, @Deadline); // Status ID dafault 1 (Open)
SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    var prms = DataBase.CreateParameters(
                        ("UserID", _currentUserId),
                        ("CategoryID", categoryId),
                        ("Languages", (object)languages ?? DBNull.Value),
                        ("Title", title),
                        ("Description", description),
                        ("BudgetOffered", budget.HasValue ? (object)budget.Value : DBNull.Value),
                        ("Deadline", deadline.HasValue ? (object)deadline.Value : DBNull.Value)
                    );

                    object res = DataBase.ExecuteScalar(insertSql, prms);
                    if (res != null && int.TryParse(res.ToString(), out int newId))
                    {
                        textBoxRequestID.Text = newId.ToString();
                        MessageBox.Show($"Request created (ID: {newId}).", "Success");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else // UPDATE
                {
                    string updateSql = @"
UPDATE ProjectRequest
SET CategoryID=@CategoryID, Languages=@Languages, Title=@Title, Description=@Description,
    BudgetOffered=@BudgetOffered, Deadline=@Deadline, StatusID = 1,PostedDate = GETDATE() 
WHERE RequestID=@RequestID";

                    var prms = DataBase.CreateParameters(
                        ("CategoryID", categoryId),
                        ("Languages", (object)languages ?? DBNull.Value),
                        ("Title", title),
                        ("Description", description),
                        ("BudgetOffered", budget.HasValue ? (object)budget.Value : DBNull.Value),
                        ("Deadline", deadline.HasValue ? (object)deadline.Value : DBNull.Value),
                        ("RequestID", requestId)
                    );

                    int affected = DataBase.ExecuteNonQuery(updateSql, prms);
                    if (affected > 0)
                    {
                        MessageBox.Show("Request updated.", "Success");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving request:\n" + ex.Message, "Error");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel? Unsaved changes will be lost.",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRequestID.Text = "Auto Generated";

            comboBoxCategory.SelectedIndex = -1;

            textBoxLanguages.Clear();
            textBoxTitle.Clear();
            textBoxDescribe.Clear();
            textBoxBudget.Clear();

            metroDateTimeDeadLIne.Value = DateTime.Now.AddDays(7);
            metroDateTimeDeadLIne.Checked = false;
        }

        private void NewProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }






    }
}
