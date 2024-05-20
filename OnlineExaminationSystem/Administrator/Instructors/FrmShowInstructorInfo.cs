using OnlineExaminationSystem.Administrator.Instructors.UserControls;
using OnlineExaminationSystem.Administrator.Students.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if(!ucInstructorCard1.LoadInstructorData(instructorID, UcInstructorCard.EnLoadBy.InstructorID))
                    btnClose.PerformClick();
            };

        }

        public FrmShowInstructorInfo(int personID)
        {
            InitializeComponent();

            this.Load += (sender, e) =>
            {
                if (!ucInstructorCard1.LoadInstructorData(personID, UcInstructorCard.EnLoadBy.PersonID))
                    btnClose.PerformClick();
            };

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
