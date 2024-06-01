using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Courses.UserControls
{
    public partial class UcCourseCard : UserControl
    {
        public int? CourseID { get; private set; } = null;
        public Course Course { get; private set; } = null;

        public UcCourseCard()
        {
            InitializeComponent();
        }

        private void DisplayCourseData()
        {
            CourseID = Course.CourseID;

            txtCourseID.Text = CourseID.ToString();
            txtName.Text = Course.Name;
            txtDescription.Text = Course.Description ?? string.Empty;
            txtPrerequisites.Text = Course.Prerequisites ?? string.Empty;
            txtCredits.Text = Course.Credits.ToString();
            txtDuration.Text = Course.Duration.ToString();
        }

        public bool LoadCourseData(int? courseID)
        {
            Course = Course.Find(courseID);

            if (Course == null)
            {
                FormUtilities.ShowMessage($"No course with ID = {courseID} was found in the system !", MessageBoxIcon.Error);
                return false;
            }

            DisplayCourseData();
            return true;
        }
    }
}
