using OnlineExamination_BusinessLayer;
using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Instructors.UserControls
{
    public partial class UcInstructorCard : UserControl
    {
        public enum EnLoadBy : byte { PersonID, InstructorID }
        public int? PersonID => ucPersonCard1.PersonID;
        public Person Person => ucPersonCard1.Person;

        public int? InstructorID { get; private set; } = null;
        public Instructor Instructor { get; private set; } = null;

        public UcInstructorCard()
        {
            InitializeComponent();
        }

        private void LoadInstructorData()
        {
            InstructorID = Instructor.InstructorID;

            ucPersonCard1.LoadPersonData(Instructor.PersonID);

            txtInstructorID.Text = InstructorID.ToString();
            txtMonthlySalary.Text = Instructor.MonthlySalary.ToString();
            dtpHireDate.Value = Instructor.HireDate;
            dtpExitDate.Value = Instructor.ExitDate ?? DateTime.Now;

            pnlExitInformation.Visible = Instructor.ExitDate.HasValue;
        }

        public bool LoadInstructorData(int? value, EnLoadBy loadBy)
        {
            switch (loadBy)
            {
                case EnLoadBy.PersonID:
                    Instructor = Instructor.Find(value, Instructor.EnFilterBy.PersonID);
                    break;

                case EnLoadBy.InstructorID:
                    Instructor = Instructor.Find(value, Instructor.EnFilterBy.InstructorID);
                    break;
            }

            if (Instructor == null)
            {
                ShowErrorMessage($"No instructor with ID = {value} was found in the system !");
                return false;
            }

            LoadInstructorData();
            return true;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
