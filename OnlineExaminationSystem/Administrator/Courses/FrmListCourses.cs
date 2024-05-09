using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Administrator.Tracks;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Courses
{
    public partial class FrmListCourses : Form
    {
        private DataView _coursesDataView = null;

        public FrmListCourses()
        {
            InitializeComponent();
        }

        private void FrmListCourses_Load(object sender, EventArgs e)
        {
            RefreshCoursesList();
        }

        private void RefreshCoursesList()
        {
            cbFilterByOptions.SelectedIndex = 0;

            _coursesDataView = Course.GetAllCourses().DefaultView;

            dgvCoursesList.DataSource = _coursesDataView;
        }

        private void FilterCoursesList()
        {
            string filterValue = txtFilterValue.Text.Trim();

            if (string.IsNullOrWhiteSpace(filterValue))
            {
                _coursesDataView.RowFilter = null;
                return;
            }

            string filterOption = cbFilterByOptions.Text;

            if (filterOption != "Name" && filterOption != "Prerequisites")
            {
                if (filterOption == "Credits")
                    filterValue = txtFilterValue.Text.Replace(',', '.') + "0";

                _coursesDataView.RowFilter = $"[{filterOption}] = {filterValue}";

            }
            else
                _coursesDataView.RowFilter = $"[{filterOption}] LIKE '%{filterValue}%'";
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.ResetText();
            txtFilterValue.Select();
            txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterCoursesList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterByOptions.Text != "Name" && cbFilterByOptions.Text != "Prerequisites")
            { 
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

                if (cbFilterByOptions.Text == "Credits")
                    e.Handled = ValidateCreditsInput(e);
            }
        }

        private bool ValidateCreditsInput(KeyPressEventArgs e)
        {
            bool isDigitsEnteredFirst = !string.IsNullOrWhiteSpace(txtFilterValue.Text);

            return e.Handled && ! (isDigitsEnteredFirst && (e.KeyChar == ',' || e.KeyChar == '.'));
        }

        private void BtnAddNewCourse_Click(object sender, EventArgs e)
        {
            FrmAddUpdateCourse form = new FrmAddUpdateCourse();
            form.ShowDialog();

            RefreshCoursesList();
        }

        private void AddNewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewCourse.PerformClick();
        }

        private void UpdateCourseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateCourse form = new FrmAddUpdateCourse((int)dgvCoursesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            RefreshCoursesList();
        }

        private void ShowCourseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowCourseInfo form = new FrmShowCourseInfo((int)dgvCoursesList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DeleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? currentCourseID = (int)dgvCoursesList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this course ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (Course.DeleteCourse(currentCourseID))
            {
                ShowSuccessMessage($"Course with ID: {currentCourseID} deleted successfully.");
                RefreshCoursesList();
            }

            else
                ShowErrorMessage($"Failed to delete course with ID: {currentCourseID}.");
        }

        private void DgvCoursesList_SelectionChanged(object sender, EventArgs e)
        {
            cmsCourses.Enabled = dgvCoursesList.SelectedRows.Count > 0;
        }

        private void DgvCoursesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showCourseDetailsToolStripMenuItem.PerformClick();
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
