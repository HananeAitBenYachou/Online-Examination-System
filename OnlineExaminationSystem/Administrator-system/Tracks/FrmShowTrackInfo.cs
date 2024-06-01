using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Tracks
{
    public partial class FrmShowTrackInfo : Form
    {
        private readonly int? _trackID = null;

        public FrmShowTrackInfo(int? trackID)
        {
            InitializeComponent();
            _trackID = trackID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShowTrackInfo_Load(object sender, EventArgs e)
        {
            if (ucTrackCard1.LoadTrackData(_trackID))
                btnClose.PerformClick();
        }

    }
}
