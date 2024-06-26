using OnlineExamination_BusinessLayer;
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
using System.Xml.Linq;

namespace OnlineExaminationSystem.Administrator_system.Users
{
    public partial class FrmAddUpdateUserAccount : Form
    {
        private enum Mode : byte { AddNew, Update };
        private Mode _mode;

        private int? _userID = null;
        private User _user = null;

        private int? _personID = null;
        private User.Role _userRole;

        public FrmAddUpdateUserAccount(int? personID , User.Role userRole)
        {
            InitializeComponent();
            _personID = personID;
            _userRole = userRole;
            _mode = Mode.AddNew;
        }

        public FrmAddUpdateUserAccount(int? userID)
        {
            InitializeComponent();
            _userID = userID;
            _mode = Mode.Update;
        }

        private void FrmAddUpdateUserAccount_Load(object sender, EventArgs e)
        {
            InitializeForm();

            if (_mode == Mode.Update)
                LoadUserAccountData();
        }

        private bool SaveUserAccountData()
        {
            UpdateUserAccountData();

            if (!_user.Save())
            {
                FormUtilities.ShowMessage("User account data is not saved successfully.", MessageBoxIcon.Error);
                return false;
            }

            else
            {
                FormUtilities.ShowMessage("User account data saved successfully !", MessageBoxIcon.Information);
                UpdateFormAfterSave();
                return true;
            }
        }

        private void UpdateFormAfterSave()
        {
            _mode = Mode.Update;
            _userID = _user.UserID;
            txtUserID.Text = _userID.ToString();
        }

        private void UpdateUserAccountData()
        {
            _user.PersonID = _personID.Value;
            _user.UserRule = (_mode == Mode.AddNew) ? _userRole : _user.UserRule;
            _user.IsActive = (_mode == Mode.AddNew) ? true : _user.IsActive;
            _user.Username = txtUsername.Text.Trim();
            _user.Password = txtPassword.Text.Trim();
        }

        private void LoadUserAccountData()
        {
            _user = User.Find(_userID);

            if (_user == null)
            {
                FormUtilities.ShowMessage($"No user account with ID = {_user} was found in the system !", MessageBoxIcon.Error);
                Close();
                return;
            }

            DisplayUserAccountData();
        }

        private void DisplayUserAccountData()
        {
            _personID = _user.PersonID;

            txtUserID.Text = _userID.ToString();
            txtPersonID.Text = _personID.ToString();
            txtUsername.Text = _user.Username;
            txtPassword.Text = _user.Password;
        }

        private void InitializeForm()
        {
            if (_mode == Mode.AddNew)
            {
                _user = new User();
                txtPersonID.Text = _personID.ToString();
            }

            lblTitle.Text = _mode == Mode.AddNew ? "Add New User Account" : "Update User Account";
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                FormUtilities.ShowMessage("Some fields are not valid. Please check the red icon(s) for details.", MessageBoxIcon.Warning);
                return;
            }

            SaveUserAccountData();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TxtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                SetValidationError(txtUsername, e, "This field is required !");

            else if (_user.Username != txtUsername.Text && User.DoesUserExist(txtUsername.Text))
                SetValidationError(txtUsername, e, "An user account with the same username already exists!");

            else
                ClearValidationError(txtUsername, e);
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                SetValidationError(txtPassword, e, "This field is required !");

            else if (txtPassword.Text.Trim().Length <= 6)
                SetValidationError(txtPassword, e, "The password is too weak!");

            else
                ClearValidationError(txtPassword, e);
        }

        private void SetValidationError(Control control, System.ComponentModel.CancelEventArgs e, string errorMessage)
        {
            e.Cancel = true;
            control.Focus();
            errorProvider1.SetError(control, errorMessage);
        }

        private void ClearValidationError(Control control, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider1.SetError(control, null);
        }

    }
}
