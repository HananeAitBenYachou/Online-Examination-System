using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Instructors.InstructorCourses
{
    public partial class FrmAssignCourseToInstructor : Form
    {
        private readonly int? _instructorID = null;

        private Instructor _instructor = null;

        private Dictionary<string, int> _availableCourses = new Dictionary<string, int>();

        public FrmAssignCourseToInstructor(int? instructorID)
        {
            InitializeComponent();
            _instructorID = instructorID;
        }

        private void FrmAssignCourseToInstructor_Load(object sender, EventArgs e)
        {
            if (!LoadInstructorData())
            {
                btnClose.PerformClick();
                return;
            }
        }

        private bool LoadInstructorData()
        {
            _instructor = Instructor.Find(_instructorID, Instructor.FindByOption.InstructorID);

            if (_instructor == null)
            {
                FormUtilities.ShowMessage($"No instructor with ID = {_instructorID} was found in the system !", MessageBoxIcon.Error);
                return false;
            }

            DisplayInstructorData();
            PopulateComboBoxWithInstructorAvailableCourses();
            return true;
        }

        private void PopulateComboBoxWithInstructorAvailableCourses()
        {
            _availableCourses = InstructorCourse.GetAvailableCoursesForInstructor(_instructorID);

            if (_availableCourses.Count > 0)
                cbCourses.DataSource = _availableCourses.Keys.ToList();

            else
            {
                FormUtilities.ShowMessage("No available courses to assign to this instructor !", MessageBoxIcon.Error);
                btnClose.PerformClick();
            }
        }

        private void DisplayInstructorData()
        {
            txtInstructorID.Text = _instructor.InstructorID.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            InstructorCourse instructorCourse = new InstructorCourse();

            string courseName = cbCourses.Text;
            int courseID = _availableCourses[courseName];

            instructorCourse.InstructorID = _instructorID.Value;
            instructorCourse.CourseID = courseID;


            if (!instructorCourse.Save())
                FormUtilities.ShowMessage($"Failed to assign course {courseName} with ID {courseID} to this instructor !", MessageBoxIcon.Error);

            else
            {
                FormUtilities.ShowMessage($"Course {courseName} with ID {courseID} assigned to the instructor successfully.", MessageBoxIcon.Information);
                PopulateComboBoxWithInstructorAvailableCourses();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
