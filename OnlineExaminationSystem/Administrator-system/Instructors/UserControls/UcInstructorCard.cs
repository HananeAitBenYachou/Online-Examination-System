using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Instructors.UserControls
{
    public partial class UcInstructorCard : UserControl
    {
        public enum LoadByOption : byte { PersonID, InstructorID }
        public int? PersonID => ucPersonCard1.PersonID;
        public Person Person => ucPersonCard1.Person;

        public int? InstructorID { get; private set; } = null;
        public Instructor Instructor { get; private set; } = null;

        public UcInstructorCard()
        {
            InitializeComponent();
        }

        private void DisplayInstructorData()
        {
            InstructorID = Instructor.InstructorID;

            ucPersonCard1.LoadPersonData(Instructor.PersonID);

            txtInstructorID.Text = InstructorID.ToString();
            txtMonthlySalary.Text = Instructor.MonthlySalary.ToString();
            dtpHireDate.Value = Instructor.HireDate;
            dtpExitDate.Value = Instructor.ExitDate ?? DateTime.Now;

            pnlExitInformation.Visible = Instructor.ExitDate.HasValue;
        }

        public bool LoadInstructorData(int? id, LoadByOption loadByOption)
        {
            switch (loadByOption)
            {
                case LoadByOption.PersonID:
                    Instructor = Instructor.Find(id, Instructor.FindByOption.PersonID);
                    break;

                case LoadByOption.InstructorID:
                    Instructor = Instructor.Find(id, Instructor.FindByOption.InstructorID);
                    break;
            }

            if (Instructor == null)
            {
                FormUtilities.ShowMessage($"No instructor with ID = {id} was found in the system !", MessageBoxIcon.Error);
                return false;
            }

            DisplayInstructorData();
            return true;
        }
    }
}
