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

namespace OnlineExaminationSystem.Administrator.TrackCourses
{
    public partial class FrmAddCourseToTrack : Form
    {
        private readonly int? _trackID = null;

        private Track _track = null;

        private Dictionary<string,int> _availableCourses = new Dictionary<string,int>();

        public FrmAddCourseToTrack(int? trackID)
        {
            InitializeComponent();
            _trackID = trackID;
        }

        private bool LoadTrackData()
        {
            _track = Track.Find(_trackID);

            if (_track == null)
            {
                ShowErrorMessage($"No track with ID = {_trackID} was found in the system !");
                return false;
            }

            PopulateFormFieldsWithTrackData();
            LoadAvailableCourses();
            return true;
        }

        private void LoadAvailableCourses()
        {
            _availableCourses = TrackCourse.GetAvailableCoursesForTrack(_trackID);

            if(_availableCourses.Count > 0)
                cbCourses.DataSource = _availableCourses.Keys.ToList();

            else
            {
                ShowErrorMessage("No available courses to add to this track !");
                btnClose.PerformClick();
            }

        }

        private void PopulateFormFieldsWithTrackData()
        {
            txtTrackName.Text = _track.Name;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TrackCourse trackCourse = new TrackCourse();

            string courseName = cbCourses.Text;
            int courseID = _availableCourses[courseName];

            trackCourse.TrackID = _trackID.Value;
            trackCourse.CourseID = courseID;


            if (!trackCourse.Save())                        
                ShowErrorMessage($"Failed to add course {courseName} with ID {courseID} to the track !");
            
            else
            {
                ShowSuccessMessage($"Course {courseName} with ID {courseID} added to the track successfully.");
                LoadAvailableCourses();
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddCourseToTrack_Load(object sender, EventArgs e)
        {
            if(!LoadTrackData())
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
