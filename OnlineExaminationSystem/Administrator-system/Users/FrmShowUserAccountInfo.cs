using OnlineExaminationSystem.Administrator.Tracks.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator_system.Users
{
    public partial class FrmShowUserAccountInfo : Form
    {
        private readonly int? _userID = null;

        public FrmShowUserAccountInfo(int? userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShowUserAccountInfo_Load(object sender, EventArgs e)
        {
            if (!ucUserAccountCard1.LoadUserAccountData(_userID))
                btnClose.PerformClick();
        }

    }
}
