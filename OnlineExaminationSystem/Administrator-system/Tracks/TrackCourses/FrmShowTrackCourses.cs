using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
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
            Close();
        }

        private void RefreshTrackCoursesList()
        {
            _trackCoursesDataView = TrackCourse.GetAllTrackCourses(_trackID).DefaultView;

            dgvTrackCoursesList.DataSource = _trackCoursesDataView;
        }

        private void FrmShowTrackCourses_Load(object sender, EventArgs e)
        {
            if (!Track.DoesTrackExist(_trackID))
            {
                FormUtilities.ShowMessage($"No track with ID = {_trackID} was found in the system !" , MessageBoxIcon.Error);
                Close();
                return;
            }
            ucTrackCard1.LoadTrackData(_trackID);
            RefreshTrackCoursesList();
        }

    }
}
