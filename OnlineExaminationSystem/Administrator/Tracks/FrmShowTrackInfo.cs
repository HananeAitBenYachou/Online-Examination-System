using OnlineExamination_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Tracks
{
    public partial class FrmShowTrackInfo : Form
    {
        private readonly int? _trackID = null;
        private Track _track = null;

        public FrmShowTrackInfo(int? trackID)
        {
            InitializeComponent();
            _trackID = trackID;
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

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowTrackInfo_Load(object sender, EventArgs e)
        {
            LoadTrackData();
        }
    
    }
}
