using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Administrator.TrackCourses;
using OnlineExaminationSystem.Global;
using System;
using System.Data;
using System.Windows.Forms;


namespace OnlineExaminationSystem.Administrator.Tracks
{
    public partial class FrmListTracks : Form
    {
        private DataView _tracksDataView = null;

        public FrmListTracks()
        {
            InitializeComponent();
        }

        private void FrmListTracks_Load(object sender, EventArgs e)
        {
            RefreshTracksList();
        }

        private void RefreshTracksList()
        {
            cbFilterByOptions.SelectedIndex = 0;

            _tracksDataView = Track.GetAllTracks().DefaultView;

            dgvTracksList.DataSource = _tracksDataView;
        }

        private void FilterTracksList()
        {
            string filterValue = txtFilterValue.Text.Trim();

            if (string.IsNullOrWhiteSpace(filterValue))
            {
                _tracksDataView.RowFilter = null;
                return;
            }

            string filterOption = cbFilterByOptions.Text;

            if (filterOption == "Track ID")
                _tracksDataView.RowFilter = $"[{filterOption}] = {filterValue}";
            else
                _tracksDataView.RowFilter = $"[{filterOption}] LIKE '%{filterValue}%'";
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.ResetText();
            txtFilterValue.Select();
            txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterTracksList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = cbFilterByOptions.Text == "Track ID" && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnAddNewTrack_Click(object sender, EventArgs e)
        {
            FrmAddUpdateTrack form = new FrmAddUpdateTrack();
            form.ShowDialog();

            RefreshTracksList();
        }

        private void AddNewTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewTrack.PerformClick();
        }

        private void UpdateTrackInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateTrack form = new FrmAddUpdateTrack((int)dgvTracksList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            RefreshTracksList();
        }

        private void ShowTrackDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTrackInfo form = new FrmShowTrackInfo((int)dgvTracksList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DeleteTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? currentTrackID = (int)dgvTracksList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this track ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (Track.DeleteTrack(currentTrackID))
            {
                FormUtilities.ShowMessage($"Track with ID: {currentTrackID} deleted successfully." , MessageBoxIcon.Information);
                RefreshTracksList();
            }

            else
                FormUtilities.ShowMessage($"Failed to delete track with ID: {currentTrackID}." , MessageBoxIcon.Error);
        }

        private void ShowTrackCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTrackCourses form = new FrmShowTrackCourses((int)dgvTracksList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void AddCourseToTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCourseToTrack form = new FrmAddCourseToTrack((int)dgvTracksList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DgvTracksList_SelectionChanged(object sender, EventArgs e)
        {
            cmsTracks.Enabled = dgvTracksList.SelectedRows.Count > 0;
        }

        private void DgvTracksList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showTrackDetailsToolStripMenuItem.PerformClick();
        }

    }
}
