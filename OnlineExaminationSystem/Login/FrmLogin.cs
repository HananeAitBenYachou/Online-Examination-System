using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem_UtilityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static OnlineExaminationSystem.Global.Global;

namespace OnlineExaminationSystem.Login
{
    public partial class FrmLogin : Form
    {
        private Dictionary<User.Role, Func<Form>> _formMapping;        

        public FrmLogin()
        {
            InitializeComponent();
            InitializeFormMappings();
        }

        private void InitializeFormMappings()
        {
            _formMapping = new Dictionary<User.Role, Func<Form>>
            {
                { User.Role.Admin, () => new FrmHome(this) },
                { User.Role.Instructor, () => new OnlineExaminationSystem.Instructor_system.FrmHome(this) },
                { User.Role.Student, () => new OnlineExaminationSystem.Student_system.FrmHome(this) }
            };
        }
      
        private void Reset()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();

            txtUsername.Select();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                SetValidationError(txtUsername, e, "Please enter your username !");

            else
                ClearValidationError(txtUsername, e);
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                SetValidationError(txtPassword, e, "Please enter your password !");

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

        private void HandleRememberMeFunctionality()
        {
            if (ckbRememberMe.Checked)
                Utility.StoreUserCredintialsToRegistery(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            else
            {
                Utility.StoreUserCredintialsToRegistery(string.Empty, string.Empty);
                Reset();
            }
        }

        private bool Login()
        {
            CurrentUser = User.Find(txtUsername.Text.Trim(), CryptoUtility.ComputeHash(txtPassword.Text.Trim()));

            if (CurrentUser == null)
            {
                FormUtilities.ShowMessage($"Invalid Email or Password ! please try again.", MessageBoxIcon.Error);
                return false;
            }

            if (!CurrentUser.IsActive)
            {
                FormUtilities.ShowMessage($"This account is not active ! please contact your admin.",MessageBoxIcon.Error);
                return false;
            }

            HandleRememberMeFunctionality();

            this.Hide();
            Form home = _formMapping[CurrentUser.UserRule]();
            home.Show();

            return true;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                FormUtilities.ShowMessage("Please fill out all required fields !", MessageBoxIcon.Warning);
                return;
            }

            if (!Login())
                Reset();
        }

        private void LoadUserCredentials()
        {
            string username = string.Empty;
            string password = string.Empty;

            if (!Utility.GetUserCredintialsFromRegistery(ref username, ref password))
            {
                ckbRememberMe.Checked = false;
                Reset();
                return;
            }

            txtUsername.Text = username;
            txtPassword.Text = password;
            ckbRememberMe.Checked = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadUserCredentials();          
        }

    }
}
