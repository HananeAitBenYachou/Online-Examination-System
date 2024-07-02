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

namespace OnlineExaminationSystem.Administrator_system.Users.UserControls
{
    public partial class UcUserAccountCard : UserControl
    {
        public int? UserID { get; private set; } = null;
        public User User { get; private set; } = null;

        public UcUserAccountCard()
        {
            InitializeComponent();
        }

        public bool LoadUserAccountData(int? userID)
        {
            User = User.Find(userID);

            if (User == null)
            {
                FormUtilities.ShowMessage($"No user with ID = {userID} was found in the system !", MessageBoxIcon.Error);
                return false;
            }

            DisplayUserAccountData();
            return true;
        }

        private void DisplayUserAccountData()
        {
            UserID = User.UserID;

            txtUserID.Text = UserID.ToString();
            txtPersonID.Text = User.PersonID.ToString();
            txtUsername.Text = User.Username;
            txtPassword.Text = User.Password;
            lblAccountStatus.Text = User.IsActive ? "Active" : "InActive";

            _ = User.UserRule == User.Role.Admin ? rbAdmin.Checked = true
                                                 : (User.UserRule == User.Role.Instructor ? rbInstructor.Checked = true
                                                                                          : rbStudent.Checked = true);
        }
    }
}
