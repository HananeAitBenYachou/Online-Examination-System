﻿using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Administrator_system.Users;
using OnlineExaminationSystem.Global;
using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Instructors
{
    public partial class FrmListInstructors : Form
    {
        private DataView _instructorsDataView = null;

        private enum ComboBoxType : byte { Gender, Status };

        private ComboBoxType _selectedComboBoxType;

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

        private void PopulateFilterComboBox()
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
                FormUtilities.ShowMessage($"Instructor with ID: {currentInstructorID} deleted successfully.", MessageBoxIcon.Information);
                RefreshInstructorsList();
            }

            else
                FormUtilities.ShowMessage($"Failed to delete instructor with ID: {currentInstructorID}.", MessageBoxIcon.Error);
        }

        private void DgvInstructorsList_SelectionChanged(object sender, EventArgs e)
        {
            cmsInstructors.Enabled = dgvInstructorsList.SelectedRows.Count > 0;
        }

        private void DgvInstructorsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showInstructorDetailsToolStripMenuItem.PerformClick();
        }

        private void CreateInstructorAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUserAccount form = new FrmAddUpdateUserAccount((int?)dgvInstructorsList.CurrentRow.Cells[1].Value , User.Role.Instructor);
            form.ShowDialog();
        }

        private void DeactivateInstructorAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructor currentInstructor = Instructor.Find((int)dgvInstructorsList.CurrentRow.Cells[0].Value, Instructor.FindByOption.InstructorID);

            if (MessageBox.Show("Are you sure you want to deactivate this instructor's user account ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (currentInstructor.DeactivateInstructorUserAccount())
            {
                FormUtilities.ShowMessage($"Instructor with ID: {currentInstructor.InstructorID}'s user account deactivated successfully.", MessageBoxIcon.Information);
                RefreshInstructorsList();
            }

            else
                FormUtilities.ShowMessage($"Failed to deactivate instructor with ID : {currentInstructor.InstructorID}'s user account.", MessageBoxIcon.Error);

        }

        private void ActivateInstructorAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructor currentInstructor = Instructor.Find((int)dgvInstructorsList.CurrentRow.Cells[0].Value, Instructor.FindByOption.InstructorID);

            if (MessageBox.Show("Are you sure you want to activate this instructor's user account ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (currentInstructor.ActivateInstructorUserAccount())
            {
                FormUtilities.ShowMessage($"Instructor with ID: {currentInstructor.InstructorID}'s user account activated successfully.", MessageBoxIcon.Information);
                RefreshInstructorsList();
            }

            else
                FormUtilities.ShowMessage($"Failed to activate instructor with ID : {currentInstructor.InstructorID}'s user account.", MessageBoxIcon.Error);
        }

        private void CmsInstructors_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Instructor currentInstructor = Instructor.Find((int)dgvInstructorsList.CurrentRow.Cells[0].Value, Instructor.FindByOption.InstructorID);

            createInstructorAccountToolStripMenuItem.Enabled = !currentInstructor.HasUserAccount;
            deactivateInstructorAccountToolStripMenuItem.Enabled = currentInstructor.HasUserAccount && currentInstructor.UserAccountInfo.IsActive;
            activateInstructorAccountToolStripMenuItem.Enabled = currentInstructor.HasUserAccount && !currentInstructor.UserAccountInfo.IsActive;
        }

    }
}
