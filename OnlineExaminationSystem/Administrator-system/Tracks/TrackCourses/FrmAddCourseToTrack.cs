using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.TrackCourses
{
    public partial class FrmAddCourseToTrack : Form
    {
        private readonly int? _trackID = null;

        private Track _track = null;

        private Dictionary<string, int> _availableCourses = new Dictionary<string, int>();

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
                FormUtilities.ShowMessage($"No track with ID = {_trackID} was found in the system !", MessageBoxIcon.Error);
                return false;
            }

            DisplayTrackData();
            LoadAvailableCourses();
            return true;
        }

        private void LoadAvailableCourses()
        {
            _availableCourses = TrackCourse.GetAvailableCoursesForTrack(_trackID);

            if (_availableCourses.Count > 0)
                cbCourses.DataSource = _availableCourses.Keys.ToList();

            else
            {
                FormUtilities.ShowMessage("No available courses to add to this track !", MessageBoxIcon.Error);
                btnClose.PerformClick();
            }

        }

        private void DisplayTrackData()
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
                FormUtilities.ShowMessage($"Failed to add course {courseName} with ID {courseID} to the track !", MessageBoxIcon.Error);

            else
            {
                FormUtilities.ShowMessage($"Course {courseName} with ID {courseID} added to the track successfully.", MessageBoxIcon.Information);
                LoadAvailableCourses();
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddCourseToTrack_Load(object sender, EventArgs e)
        {
            if (!LoadTrackData())
            {
                btnClose.PerformClick();
                return;
            }
        }

    }
}
