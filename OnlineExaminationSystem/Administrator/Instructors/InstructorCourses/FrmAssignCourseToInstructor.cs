using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private bool LoadInstructorData()
        {
            _instructor = Instructor.Find(_instructorID  , Instructor.EnFilterBy.InstructorID);

            if (_instructor == null)
            {
                ShowErrorMessage($"No instructor with ID = {_instructorID} was found in the system !");
                return false;
            }

            PopulateFormFieldsWithInstructorData();
            LoadAvailableCourses();
            return true;
        }

        private void LoadAvailableCourses()
        {
            _availableCourses = InstructorCourse.GetAvailableCoursesForInstructor(_instructorID);

            if (_availableCourses.Count > 0)
                cbCourses.DataSource = _availableCourses.Keys.ToList();

            else
            {
                ShowErrorMessage("No available courses to assign to this instructor !");
                btnClose.PerformClick();
            }

        }

        private void PopulateFormFieldsWithInstructorData()
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
                ShowErrorMessage($"Failed to assign course {courseName} with ID {courseID} to this instructor !");

            else
            {
                ShowSuccessMessage($"Course {courseName} with ID {courseID} assigned to the instructor successfully.");
                LoadAvailableCourses();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAssignCourseToInstructor_Load(object sender, EventArgs e)
        {
            if (!LoadInstructorData())
            {
                btnClose.PerformClick();
                return;
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
