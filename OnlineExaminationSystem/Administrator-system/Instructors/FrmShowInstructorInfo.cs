using OnlineExaminationSystem.Administrator.Instructors.UserControls;
using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Instructors
{
    public partial class FrmShowInstructorInfo : Form
    {
        public FrmShowInstructorInfo(int? instructorID)
        {
            InitializeComponent();

            this.Load += (sender, e) =>
            {
                if (!ucInstructorCard1.LoadInstructorData(instructorID, UcInstructorCard.LoadByOption.InstructorID))
                    btnClose.PerformClick();
            };

        }

        public FrmShowInstructorInfo(int personID)
        {
            InitializeComponent();

            this.Load += (sender, e) =>
            {
                if (!ucInstructorCard1.LoadInstructorData(personID, UcInstructorCard.LoadByOption.PersonID))
                    btnClose.PerformClick();
            };

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
