using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Tracks.UserControls
{
    public partial class UcTrackCard : UserControl
    {
        public int? TrackID { get; private set; } = null;
        public Track Track { get; private set; } = null;

        public UcTrackCard()
        {
            InitializeComponent();
        }

        public bool LoadTrackData(int? trackID)
        {
            Track = Track.Find(trackID);

            if (Track == null)
            {
                FormUtilities.ShowMessage($"No track with ID = {trackID} was found in the system !" , MessageBoxIcon.Error);
                return false;
            }

            DisplayTrackData();
            return true;
        }

        private void DisplayTrackData()
        {
            TrackID = Track.TrackID;

            txtTrackID.Text = TrackID.ToString();
            txtName.Text = Track.Name;
            txtDescription.Text = Track.Description ?? string.Empty;
        }

    }
}
