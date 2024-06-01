using Guna.UI2.WinForms;
using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem.Properties;
using System;
using System.Linq;
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

        private void Reset()
        {
            ClearTextBoxes();

            PersonID = null;
            Person = null;

            dtpBirthDate.Value = DateTime.Now;

            rbMale.Checked = true;
        }

        private void ClearTextBoxes()
        {
            foreach (var textBox in groupBox.Controls.OfType<Guna2TextBox>())
                textBox.Text = string.Empty;

            txtPersonID.Text = "N/A";
        }

        private void DisplayPersonData()
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

            rbMale.Checked = Person.GenderText == Person.GenderType.Male;

            rbFemale.Checked = !rbMale.Checked;

            if (Person.PersonalImagePath != null)
                pbPersonalImage.ImageLocation = Person.PersonalImagePath;

        }

        public bool LoadPersonData(int? personID)
        {
            Person = Person.Find(personID);

            if (Person == null)
            {
                FormUtilities.ShowMessage($"No person with ID = {personID} was found in the system !", MessageBoxIcon.Error);
                Reset();
                return false;
            }

            DisplayPersonData();
            return true;
        }

        public bool LoadPersonData(string NationalNo)
        {
            Person = Person.Find(NationalNo);

            if (Person == null)
            {
                FormUtilities.ShowMessage($"No person with NationalNo = {NationalNo} was found in the system !", MessageBoxIcon.Error);
                Reset();
                return false;
            }

            DisplayPersonData();
            return true;
        }

        private void RbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonalImage.ImageLocation == null)
            {
                pbPersonalImage.Image = rbMale.Checked ? Resources.man : Resources.woman;
            }
        }
    }
}
