using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OnlineExaminationSystem.Administrator.Students.UserControls.UcStudentCard;

namespace OnlineExaminationSystem.Administrator.Students
{
    public partial class FrmAddUpdateInstrcutor : Form
    {
        private DataView _studentsDataView = null;

        private enum ComboBoxType : byte { Track, Gender, Status };

        private ComboBoxType _selectedComboBoxType;

        public FrmAddUpdateInstrcutor()
        {
            InitializeComponent();
        }

        private void FrmListStudents_Load(object sender, EventArgs e)
        {
            RefreshStudentsList();
        }

        private void RefreshStudentsList()
        {
            _studentsDataView = Student.GetAllStudents().DefaultView;

            dgvStudentsList.DataSource = _studentsDataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterStudentsList()
        {
            string filterValue = txtFilterValue.Text.Trim();
            string filterOption = cbFilterByOptions.Text;

            _studentsDataView.RowFilter = string.IsNullOrWhiteSpace(filterValue)
                ? null
                : filterOption.EndsWith("ID")
                   ? $"[{filterOption}] = {filterValue}"
                   : $"[{filterOption}] LIKE '%{filterValue}%'";
        }

        private async Task PopulateComboBoxWithTracksAsync()
        {
            var trackNames = await Task.Run(() =>
               Track.GetAllTracks().AsEnumerable().Select(row => row["Track Name"]).ToArray());

            cbTemp.Invoke((Action)(() => cbTemp.Items.AddRange(trackNames)));
        }

        private async Task PopulateComboBoxWithDataAsync()
        {
            cbTemp.Items.Clear();
            cbTemp.Items.Add("All");

            switch (_selectedComboBoxType)
            {
                case ComboBoxType.Gender:
                    cbTemp.Items.AddRange(new string[] { "Male", "Female" });
                    break;

                case ComboBoxType.Status:
                    cbTemp.Items.AddRange(new string[] { "Active", "Marked For Delete" });
                    break;

                case ComboBoxType.Track:
                    await PopulateComboBoxWithTracksAsync();
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
                PopulateComboBoxWithDataAsync();
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

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterStudentsList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = cbFilterByOptions.Text.EndsWith("ID") && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnAddNewStudent_Click(object sender, EventArgs e)
        {
            FrmAddUpdateStudent form = new FrmAddUpdateStudent();
            form.ShowDialog();

            RefreshStudentsList();
        }

        private void AddNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewStudent.PerformClick();
        }

        private void UpdateStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateStudent form = new FrmAddUpdateStudent((int)dgvStudentsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            RefreshStudentsList();
        }

        private void ShowStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowStudentInfo form = new FrmShowStudentInfo((int)dgvStudentsList.CurrentRow.Cells[0].Value, LoadByOption.StudentID);
            form.ShowDialog();
        }

        private void DeleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? currentStudentID = (int)dgvStudentsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this student ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (Student.DeleteStudent(currentStudentID))
            {
                FormUtilities.ShowMessage($"Student with ID: {currentStudentID} deleted successfully.", MessageBoxIcon.Information);
                RefreshStudentsList();
            }

            else
                FormUtilities.ShowMessage($"Failed to delete student with ID: {currentStudentID}.", MessageBoxIcon.Error);
        }

        private void DgvStudentsList_SelectionChanged(object sender, EventArgs e)
        {
            cmsStudents.Enabled = dgvStudentsList.SelectedRows.Count > 0;
        }

        private void DgvStudentsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showStudentDetailsToolStripMenuItem.PerformClick();
        }

        private void CbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterOption = cbFilterByOptions.Text;
            string filterValue = cbTemp.Text;

            _studentsDataView.RowFilter = filterValue == "All" ? null : $"[{filterOption}] = '{filterValue}'";
        }

    }
}
