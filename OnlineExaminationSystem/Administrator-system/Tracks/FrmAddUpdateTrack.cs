using OnlineExamination_BusinessLayer;
using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Tracks
{
    public partial class FrmAddUpdateTrack : Form
    {
        private enum EnMode : byte { AddNew, Update };
        private EnMode _mode;

        private int? _trackID = null;
        private Track _track = null;

        public FrmAddUpdateTrack(int? trackID)
        {
            InitializeComponent();
            _trackID = trackID;
            _mode = EnMode.Update;
        }
        public FrmAddUpdateTrack()
        {
            InitializeComponent();
            _mode = EnMode.AddNew;
        }

        private void FrmAddUpdateTrack_Load(object sender, EventArgs e)
        {
            Reset();

            if (_mode == EnMode.Update)
                LoadTrackData();
        }

        private bool SaveTrackData()
        {
            UpdateTrackData();

            if (!_track.Save())
            {
                ShowErrorMessage("Track data is not saved successfully.");
                return false;
            }

            else
            {
                ShowSuccessMessage("Track data saved successfully !");
                UpdateFormForSavedTrack();
                return true;
            }
        }

        private void UpdateFormForSavedTrack()
        {
            _mode = EnMode.Update;
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
                ShowErrorMessage($"No track with ID = {_trackID} was found in the system !");
                this.Close();
                return;
            }

            PopulateFormFieldsWithTrackData();
        }

        private void PopulateFormFieldsWithTrackData()
        {
            txtTrackID.Text = _trackID.ToString();
            txtName.Text = _track.Name;
            txtDescription.Text = _track.Description ?? string.Empty;
        }

        private void Reset()
        {
            if (_mode == EnMode.AddNew)
                _track = new Track();

            lblTitle.Text = _mode == EnMode.AddNew ? "Add New Track" : "Update Track";
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                ShowErrorMessage("Some fields are not valid. Please check the red icon(s) for details.");
                return;
            }

            SaveTrackData();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
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

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
