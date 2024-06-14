using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem.Instructor_system.Questions;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system.Exams
{
    public partial class FrmListExams : Form
    {
        private DataView _examsDataView = null;

        private readonly int? _instructorID = null;
        private enum ComboBoxType : byte { State, Status };

        private ComboBoxType _selectedComboBoxType;

        public FrmListExams(int? instructorID)
        {
            InitializeComponent();
            _instructorID = instructorID;
        }

        private void FrmListExams_Load(object sender, EventArgs e)
        {
            RefreshExamsList();
        }

        private void RefreshExamsList()
        {
            _examsDataView = Exam.GetAllExams(_instructorID).DefaultView;

            dgvExamsList.DataSource = _examsDataView;

            cbFilterByExams.SelectedIndex = 0;
        }

        private void FilterExamsList()
        {
            string filterValue = txtFilterValue.Text.Trim();
            string filterOption = cbFilterByExams.Text;

            _examsDataView.RowFilter = string.IsNullOrWhiteSpace(filterValue)
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
                case ComboBoxType.State:
                    cbTemp.Items.AddRange(new string[] { "Completed", "Upcoming" });
                    break;

                case ComboBoxType.Status:
                    cbTemp.Items.AddRange(new string[] { "Active", "Marked For Delete" });
                    break;
            }

            cbTemp.SelectedIndex = 0;
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbFilterByExams.Text, out _selectedComboBoxType))
            {
                txtFilterValue.Visible = false;
                cbTemp.Visible = true;
                PopulateFilterComboBox();
            }

            else
            {
                cbTemp.Visible = false;
                txtFilterValue.Visible = (cbFilterByExams.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Select();
                TxtFilterValue_TextChanged(null, null);
            }
        }

        private void CbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterOption = cbFilterByExams.Text;
            string filterValue = cbTemp.Text;

            _examsDataView.RowFilter = filterValue == "All" ? null : $"[{filterOption}] = '{filterValue}'";
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterExamsList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = cbFilterByExams.Text.EndsWith("ID") && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnAddNewExam_Click(object sender, EventArgs e)
        {
            FrmAddUpdateExam form = new FrmAddUpdateExam(_instructorID);
            form.ShowDialog();

            RefreshExamsList();
        }

        private void AddNewExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewExam.PerformClick();
        }

        private void UpdateExamInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateExam form = new FrmAddUpdateExam((int)dgvExamsList.CurrentRow.Cells[0].Value, _instructorID);
            form.ShowDialog();
            RefreshExamsList();
        }

        private void ShowExamDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowExamInfo form = new FrmShowExamInfo((int)dgvExamsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DeleteExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? currentExamID = (int)dgvExamsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this exam ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (Exam.DeleteExam(currentExamID))
            {
                FormUtilities.ShowMessage($"Exam with ID: {currentExamID} deleted successfully.", MessageBoxIcon.Information);
                RefreshExamsList();
            }

            else
                FormUtilities.ShowMessage($"Failed to delete exam with ID: {currentExamID}.", MessageBoxIcon.Error);
        }

        private void DgvExamsList_SelectionChanged(object sender, EventArgs e)
        {
            cmsExams.Enabled = dgvExamsList.SelectedRows.Count > 0;
        }

        private void DgvExamsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showExamDetailsToolStripMenuItem.PerformClick();
        }

    }
}
