using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.TrackCourses
{
    public partial class FrmShowTrackCourses : Form
    {
        private readonly int? _trackID = null;

        private DataView _trackCoursesDataView = null;

        public FrmShowTrackCourses(int? trackID)
        {
            InitializeComponent();
            _trackID = trackID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshTrackCoursesList()
        {
            _trackCoursesDataView = TrackCourse.GetAllTrackCourses(_trackID).DefaultView;

            dgvTrackCoursesList.DataSource = _trackCoursesDataView;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmShowTrackCourses_Load(object sender, EventArgs e)
        {
            if (!Track.DoesTrackExist(_trackID))
            {
                ShowErrorMessage($"No track with ID = {_trackID} was found in the system !");
                this.Close();
                return;
            }
            ucTrackCard1.LoadTrackData(_trackID);
            RefreshTrackCoursesList();
        }

    }
}
