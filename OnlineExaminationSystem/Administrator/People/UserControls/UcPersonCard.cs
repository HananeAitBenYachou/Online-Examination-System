using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.People.UserControls
{
    public partial class UcPersonCard : UserControl
    {
        public int? PersonID { get; private set; } = null;
        public Person Person { get; private set; } = null;

        public UcPersonCard()
        {
            InitializeComponent();
        }

        private void LoadPersonData()
        {
            PersonID = Person.PersonID;

            txtPersonID.Text = PersonID.ToString();
            txtFirstName.Text = Person.FirstName;
            txtLastName.Text = Person.LastName;
            txtNationalNo.Text = Person.NationalNo;
            txtEmail.Text = Person.Email;
            txtPhone.Text = Person.PhoneNumber;
            txtAddress.Text = Person.Address ?? string.Empty;

            dtpBirthDate.Value = Person.BirthDate;

            rbMale.Checked = Person.GenderText == Person.EnGender.Male;

            rbFemale.Checked = !rbMale.Checked;

            if (Person.PersonalImagePath != null)
                pbPersonalImage.ImageLocation = Person.PersonalImagePath;

        }

        public bool LoadPersonData(int? personID)
        {
            Person = Person.Find(personID); 

            if (Person == null)
            {
                ShowErrorMessage($"No person with ID = {personID} was found in the system !");
                return false;
            }

            LoadPersonData();
            return true;
        }

        public bool LoadPersonData(string NationalNo)
        {
            Person Person = Person.Find(NationalNo);

            if (Person == null)
            {
                ShowErrorMessage($"No person with NationalNo = {NationalNo} was found in the system !");
                return false;
            }

            LoadPersonData();
            return true;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked && pbPersonalImage.ImageLocation == null)
                pbPersonalImage.Image = Resources.man;
        }

        private void RbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked && pbPersonalImage.ImageLocation == null)
                pbPersonalImage.Image = Resources.woman;
        }
    }
}
