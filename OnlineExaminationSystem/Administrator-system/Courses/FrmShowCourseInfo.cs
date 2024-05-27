using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Courses
{
    public partial class FrmShowCourseInfo : Form
    {
        private readonly int? courseID = null;

        public FrmShowCourseInfo(int? courseID)
        {
            InitializeComponent();
            this.courseID = courseID;
        }

        private void FrmShowCourseInfo_Load(object sender, EventArgs e)
        {
            if (!ucCourseCard1.LoadCourseData(courseID))
                btnClose.PerformClick();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
