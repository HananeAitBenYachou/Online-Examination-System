using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Students.UserControls
{
    public partial class UcStudentCard : UserControl
    {
        public enum LoadByOption : byte { PersonID, StudentID }
        public int? PersonID => ucPersonCard1.PersonID;
        public Person Person => ucPersonCard1.Person;
        public int? StudentID { get; private set; } = null;
        public Student Student { get; private set; } = null;

        public UcStudentCard()
        {
            InitializeComponent();
        }

        private void DisplayStudentData()
        {
            StudentID = Student.StudentID;

            ucPersonCard1.LoadPersonData(Student.PersonID);

            txtStudentID.Text = StudentID.ToString();
            txtTrackName.Text = Student.TrackInfo.Name;
            dtpStartDate.Value = Student.GraduationDate;
            dtpGraduationDate.Value = Student.GraduationDate;
        }

        public bool LoadStudentData(int? id, LoadByOption loadByOption)
        {
            switch (loadByOption)
            {
                case LoadByOption.PersonID:
                    Student = Student.Find(id, Student.FindByOption.PersonID);
                    break;

                case LoadByOption.StudentID:
                    Student = Student.Find(id, Student.FindByOption.StudentID);
                    break;
            }

            if (Student == null)
            {
                FormUtilities.ShowMessage($"No student with ID = {id} was found in the system !", MessageBoxIcon.Error);
                return false;
            }

            DisplayStudentData();
            return true;
        }

    }
}
