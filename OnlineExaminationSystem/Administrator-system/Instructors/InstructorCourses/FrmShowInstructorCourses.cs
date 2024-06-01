using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Administrator.Instructors.UserControls;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Instructors.InstructorCourses
{
    public partial class FrmShowInstructorCourses : Form
    {
        private readonly int? _instructorID = null;

        private DataView _instructorCoursesDataView = null;

        public FrmShowInstructorCourses(int? instructorID)
        {
            InitializeComponent();
            _instructorID = instructorID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadInstructorCoursesList()
        {
            _instructorCoursesDataView = InstructorCourse.GetAllInstructorCourses(_instructorID).DefaultView;

            dgvInstructorCoursesList.DataSource = _instructorCoursesDataView;
        }

        private void FrmShowInstructorCourses_Load(object sender, EventArgs e)
        {
            if (!Instructor.DoesInstructorExist(_instructorID, Instructor.FindByOption.InstructorID))
            {
                FormUtilities.ShowMessage($"No instructor with ID = {_instructorID} was found in the system !", MessageBoxIcon.Error);
                Close();
                return;
            }
            ucInstructorCard1.LoadInstructorData(_instructorID, UcInstructorCard.LoadByOption.InstructorID);
            LoadInstructorCoursesList();
        }
    }
}
