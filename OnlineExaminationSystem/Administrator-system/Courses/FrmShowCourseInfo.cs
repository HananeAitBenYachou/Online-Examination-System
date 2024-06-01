using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Courses
{
    public partial class FrmShowCourseInfo : Form
    {
        private readonly int? _courseID = null;

        public FrmShowCourseInfo(int? courseID)
        {
            InitializeComponent();
            this._courseID = courseID;
        }

        private void FrmShowCourseInfo_Load(object sender, EventArgs e)
        {
            if (!ucCourseCard1.LoadCourseData(_courseID))
                btnClose.PerformClick();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
