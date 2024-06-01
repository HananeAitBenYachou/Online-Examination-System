using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Tracks
{
    public partial class FrmAddUpdateTrack : Form
    {
        private enum Mode : byte { AddNew, Update };
        private Mode _mode;

        private int? _trackID = null;
        private Track _track = null;

        public FrmAddUpdateTrack(int? trackID)
        {
            InitializeComponent();
            _trackID = trackID;
            _mode = Mode.Update;
        }
        public FrmAddUpdateTrack()
        {
            InitializeComponent();
            _mode = Mode.AddNew;
        }

        private void FrmAddUpdateTrack_Load(object sender, EventArgs e)
        {
            InitializeForm();

            if (_mode == Mode.Update)
                LoadTrackData();
        }

        private bool SaveTrackData()
        {
            UpdateTrackData();

            if (!_track.Save())
            {
                FormUtilities.ShowMessage("Track data is not saved successfully." , MessageBoxIcon.Error);
                return false;
            }

            else
            {
                FormUtilities.ShowMessage("Track data saved successfully !" , MessageBoxIcon.Information);
                UpdateFormAfterSave();
                return true;
            }
        }

        private void UpdateFormAfterSave()
        {
            _mode = Mode.Update;
            _trackID = _track.TrackID;
            txtTrackID.Text = _trackID.ToString();
        }

        private void UpdateTrackData()
        {
            _track.Name = txtName.Text.Trim();
            _track.Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text.Trim();
        }

        private void LoadTrackData()
        {
            _track = Track.Find(_trackID);

            if (_track == null)
            {
                FormUtilities.ShowMessage($"No track with ID = {_trackID} was found in the system !", MessageBoxIcon.Error);
                Close();
                return;
            }

            DisplayTrackData();
        }

        private void DisplayTrackData()
        {
            txtTrackID.Text = _trackID.ToString();
            txtName.Text = _track.Name;
            txtDescription.Text = _track.Description ?? string.Empty;
        }

        private void InitializeForm()
        {
            if (_mode == Mode.AddNew)
                _track = new Track();

            lblTitle.Text = _mode == Mode.AddNew ? "Add New Track" : "Update Track";
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                FormUtilities.ShowMessage("Some fields are not valid. Please check the red icon(s) for details.", MessageBoxIcon.Warning);
                return;
            }

            SaveTrackData();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                SetValidationError(txtName, e, "This field is required !");

            else if (_track.Name != txtName.Text && Track.DoesTrackExist(txtName.Text))
                SetValidationError(txtName, e, "A track with the same name already exists!");

            else
                ClearValidationError(txtName, e);
        }

        private void SetValidationError(Control control, System.ComponentModel.CancelEventArgs e, string errorMessage)
        {
            e.Cancel = true;
            control.Focus();
            errorProvider1.SetError(control, errorMessage);
        }

        private void ClearValidationError(Control control, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider1.SetError(control, null);
        }

    }
}
