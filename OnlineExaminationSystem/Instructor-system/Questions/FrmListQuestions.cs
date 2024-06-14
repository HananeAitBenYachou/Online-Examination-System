using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system.Questions
{
    public partial class FrmListQuestions : Form
    {
        private DataView _questionsDataView = null;

        private readonly int? _instructorID = null;
        private enum ComboBoxType : byte { Type, Level, Status };

        private ComboBoxType _selectedComboBoxType;

        public FrmListQuestions(int? instructorID)
        {
            InitializeComponent();
            _instructorID = instructorID;
        }

        private void FrmListQuestions_Load(object sender, EventArgs e)
        {
            RefreshQuestionsList();
        }

        private void RefreshQuestionsList()
        {
            _questionsDataView = Question.GetAllQuestions(_instructorID).DefaultView;

            dgvQuestionsList.DataSource = _questionsDataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterQuestionsList()
        {
            string filterValue = txtFilterValue.Text.Trim();
            string filterOption = cbFilterByOptions.Text;

            _questionsDataView.RowFilter = string.IsNullOrWhiteSpace(filterValue)
                ? null
                : filterOption.EndsWith("ID")
                   ? $"[{filterOption}] = {filterValue}"
                   : $"[{filterOption}] LIKE '%{filterValue}%'";
        }

        private void PopulateFilterComboBox()
        {
            cbTemp.Items.Clear();
            cbTemp.Items.Add("All");

            switch (_selectedComboBoxType)
            {
                case ComboBoxType.Type:
                    cbTemp.Items.AddRange(new string[] { "MCQ", "True/False" });
                    break;

                case ComboBoxType.Status:
                    cbTemp.Items.AddRange(new string[] { "Active", "Marked For Delete" });
                    break;

                case ComboBoxType.Level:
                    cbTemp.Items.AddRange(new string[] { "Easy", "Medium", "Hard" });
                    break;
            }

            cbTemp.SelectedIndex = 0;
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByOptions.Text, out _selectedComboBoxType))
            {
                txtFilterValue.Visible = false;
                cbTemp.Visible = true;
                PopulateFilterComboBox();
            }

            else
            {
                cbTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Select();
                TxtFilterValue_TextChanged(null, null);
            }
        }

        private void CbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterOption = cbFilterByOptions.Text;
            string filterValue = cbTemp.Text;

            _questionsDataView.RowFilter = filterValue == "All" ? null : $"[{filterOption}] = '{filterValue}'";
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterQuestionsList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = cbFilterByOptions.Text.EndsWith("ID") && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnAddNewQuestion_Click(object sender, EventArgs e)
        {
            FrmAddUpdateQuestion form = new FrmAddUpdateQuestion(_instructorID);
            form.ShowDialog();

            RefreshQuestionsList();
        }

        private void AddNewQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewQuestion.PerformClick();
        }

        private void UpdateQuestionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateQuestion form = new FrmAddUpdateQuestion((int)dgvQuestionsList.CurrentRow.Cells[0].Value, _instructorID);
            form.ShowDialog();
            RefreshQuestionsList();
        }

        private void ShowQuestionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowQuestionInfo form = new FrmShowQuestionInfo((int)dgvQuestionsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DeleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? currentQuestionID = (int)dgvQuestionsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this question ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (Question.DeleteQuestion(currentQuestionID))
            {
                FormUtilities.ShowMessage($"Question with ID: {currentQuestionID} deleted successfully." , MessageBoxIcon.Information);
                RefreshQuestionsList();
            }

            else
                FormUtilities.ShowMessage($"Failed to delete question with ID: {currentQuestionID}.", MessageBoxIcon.Error);
        }

        private void DgvQuestionsList_SelectionChanged(object sender, EventArgs e)
        {
            cmsQuestions.Enabled = dgvQuestionsList.SelectedRows.Count > 0;
        }

        private void DgvQuestionsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showQuestionDetailsToolStripMenuItem.PerformClick();
        }
    }
}
