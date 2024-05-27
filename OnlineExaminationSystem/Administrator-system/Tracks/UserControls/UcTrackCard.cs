using OnlineExamination_BusinessLayer;
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
                ShowErrorMessage($"No track with ID = {trackID} was found in the system !");
                return false;
            }

            PopulateFormFieldsWithTrackData();
            return true;
        }

        private void PopulateFormFieldsWithTrackData()
        {
            TrackID = Track.TrackID;

            txtTrackID.Text = TrackID.ToString();
            txtName.Text = Track.Name;
            txtDescription.Text = Track.Description ?? string.Empty;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
