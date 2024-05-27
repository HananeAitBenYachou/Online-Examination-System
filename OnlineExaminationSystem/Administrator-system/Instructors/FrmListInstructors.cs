using OnlineExamination_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Instructors
{
    public partial class FrmListInstructors : Form
    {
        private DataView _instructorsDataView = null;

        private enum EnComboBoxTypes : byte { Gender, Status };

        private EnComboBoxTypes _selectedComboBoxType;

        public FrmListInstructors()
        {
            InitializeComponent();
        }

        private void FrmListInstructors_Load(object sender, EventArgs e)
        {
            RefreshInstructorsList();
        }

        private void RefreshInstructorsList()
        {
            _instructorsDataView = Instructor.GetAllInstructors().DefaultView;

            dgvInstructorsList.DataSource = _instructorsDataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterInstructorsList()
        {
            string filterValue = txtFilterValue.Text.Trim();
            string filterOption = cbFilterByOptions.Text;

            _instructorsDataView.RowFilter = string.IsNullOrWhiteSpace(filterValue)
                ? null
                : filterOption.EndsWith("ID")
                   ? $"[{filterOption}] = {filterValue}"
                   : $"[{filterOption}] LIKE '%{filterValue}%'";
        }

        private void PopulateComboBoxWithData()
        {
            cbTemp.Items.Clear();
            cbTemp.Items.Add("All");

            switch (_selectedComboBoxType)
            {
                case EnComboBoxTypes.Gender:
                    cbTemp.Items.AddRange(new string[] { "Male", "Female" });
                    break;

                case EnComboBoxTypes.Status:
                    cbTemp.Items.AddRange(new string[] { "Active", "Marked For Delete" });
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
                PopulateComboBoxWithData();
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

            _instructorsDataView.RowFilter = filterValue == "All" ? null : $"[{filterOption}] = '{filterValue}'";
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterInstructorsList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = cbFilterByOptions.Text.EndsWith("ID") && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnAddNewInstructor_Click(object sender, EventArgs e)
        {
            FrmAddUpdateInstructor form = new FrmAddUpdateInstructor();
            form.ShowDialog();

            RefreshInstructorsList();
        }

        private void AddNewInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewInstructor.PerformClick();
        }

        private void UpdateInstructorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateInstructor form = new FrmAddUpdateInstructor((int?)dgvInstructorsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            RefreshInstructorsList();
        }

        private void ShowInstructorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowInstructorInfo form = new FrmShowInstructorInfo((int?)dgvInstructorsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DeleteInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? currentInstructorID = (int)dgvInstructorsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this instructor ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (Instructor.DeleteInstructor(currentInstructorID))
            {
                ShowSuccessMessage($"Instructor with ID: {currentInstructorID} deleted successfully.");
                RefreshInstructorsList();
            }

            else
                ShowErrorMessage($"Failed to delete instructor with ID: {currentInstructorID}.");
        }

        private void DgvInstructorsList_SelectionChanged(object sender, EventArgs e)
        {
            cmsInstructors.Enabled = dgvInstructorsList.SelectedRows.Count > 0;
        }

        private void DgvInstructorsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showInstructorDetailsToolStripMenuItem.PerformClick();
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
