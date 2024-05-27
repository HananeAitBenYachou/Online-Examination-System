using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Administrator.Instructors.UserControls;
using OnlineExaminationSystem.Administrator.Tracks.UserControls;
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
    public partial class FrmShowInstructorCourses : Form
    {
        private readonly int? _instructorID = null;

        private DataView _instructorCoursesDataView = null;

        public FrmShowInstructorCourses(int? trackID)
        {
            InitializeComponent();
            _instructorID = trackID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadInstructorCoursesList()
        {
            _instructorCoursesDataView = InstructorCourse.GetAllInstructorCourses(_instructorID).DefaultView;

            dgvInstructorCoursesList.DataSource = _instructorCoursesDataView;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmShowInstructorCourses_Load(object sender, EventArgs e)
        {
            if (!Instructor.DoesInstructorExist(_instructorID , Instructor.EnFilterBy.InstructorID))
            {
                ShowErrorMessage($"No instructor with ID = {_instructorID} was found in the system !");
                this.Close();
                return;
            }
            ucInstructorCard1.LoadInstructorData(_instructorID , UcInstructorCard.EnLoadBy.InstructorID);
            LoadInstructorCoursesList();
        }
    }
}
