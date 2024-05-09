using Guna.UI2.WinForms;
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
using TheArtOfDevHtmlRenderer.Adapters;

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

        private void PopulateControlsWithCourseData()
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
                ShowErrorMessage($"No course with ID = {courseID} was found in the system !");
                return false;
            }

            PopulateControlsWithCourseData();
            return true;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
