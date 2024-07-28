using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Administrator.Students;
using OnlineExaminationSystem.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator_system.Users
{
    public partial class FrmListUserAccounts : Form
    {
        private DataView _userAccountsDataView = null;

        private enum ComboBoxType : byte { Role, Status };

        private ComboBoxType _selectedComboBoxType;

        public FrmListUserAccounts()
        {
            InitializeComponent();
        }

        private void FrmListUserAccounts_Load(object sender, EventArgs e)
        {
            RefreshUserAccountsList();
        }

        private void RefreshUserAccountsList()
        {
            _userAccountsDataView = User.GetAllUsers().DefaultView;

            dgvUserAccountsList.DataSource = _userAccountsDataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void FilterUserAccountsList()
        {
            string filterValue = txtFilterValue.Text.Trim();
            string filterOption = cbFilterByOptions.Text;

            _userAccountsDataView.RowFilter = string.IsNullOrWhiteSpace(filterValue)
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
                case ComboBoxType.Status:
                    cbTemp.Items.AddRange(new string[] { "Active", "Inactive" });
                    break;

                case ComboBoxType.Role:
                    cbTemp.Items.AddRange(new string[] { "Admin", "Instructor" , "Student" });
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

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterUserAccountsList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = cbFilterByOptions.Text.EndsWith("ID") && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UpdateUserAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUserAccount form = new FrmAddUpdateUserAccount((int)dgvUserAccountsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            RefreshUserAccountsList();
        }

        private void ShowUserAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowUserAccountInfo form = new FrmShowUserAccountInfo((int)dgvUserAccountsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DgvUserAccountsList_SelectionChanged(object sender, EventArgs e)
        {
            cmsUserAccounts.Enabled = dgvUserAccountsList.SelectedRows.Count > 0;
        }

        private void DgvUserAccountsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showUserAccountDetailsToolStripMenuItem.PerformClick();
        }

        private void CbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterOption = cbFilterByOptions.Text;
            string filterValue = cbTemp.Text;

            _userAccountsDataView.RowFilter = filterValue == "All" ? null : $"[{filterOption}] = '{filterValue}'";
        }

        private void ActivateUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? currentUserAccountID = (int)dgvUserAccountsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to activate this user account ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (User.ActivateUser(currentUserAccountID))
            {
                FormUtilities.ShowMessage($"User account with ID: {currentUserAccountID} activated successfully.", MessageBoxIcon.Information);
                RefreshUserAccountsList();
            }

            else
                FormUtilities.ShowMessage($"Failed to activate user account with ID: {currentUserAccountID}.", MessageBoxIcon.Error);
        }

        private void DeactivateUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? currentUserAccountID = (int)dgvUserAccountsList.CurrentRow.Cells[0].Value;
            bool isAdmin = (string)dgvUserAccountsList.CurrentRow.Cells["Role"].Value == "Admin";

            if (isAdmin)
            {
                FormUtilities.ShowMessage($"You can't deactivate the admin user account", MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to deactivate this user account ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (User.DeactivateUser(currentUserAccountID))
            {
                FormUtilities.ShowMessage($"User account with ID: {currentUserAccountID} deactivated successfully.", MessageBoxIcon.Information);
                RefreshUserAccountsList();
            }

            else
                FormUtilities.ShowMessage($"Failed to deactivate user account with ID: {currentUserAccountID}.", MessageBoxIcon.Error);
        }

        private void CmsUserAccounts_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            User currentUser = User.Find((int)dgvUserAccountsList.CurrentRow.Cells[0].Value);

            deactivateUserAccountToolStripMenuItem.Enabled = currentUser.IsActive;
            activateUserAccountToolStripMenuItem.Enabled =  !currentUser.IsActive;
        }
    }
}
