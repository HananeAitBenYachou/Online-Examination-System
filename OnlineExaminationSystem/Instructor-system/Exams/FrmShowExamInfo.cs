using OnlineExaminationSystem.Instructor_system.Questions.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system.Exams
{
    public partial class FrmShowExamInfo : Form
    {
        private readonly int? _examID = null;

        public FrmShowExamInfo(int? examID)
        {
            InitializeComponent();
            _examID = examID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShowExamInfo_Load(object sender, EventArgs e)
        {
            if (!ucExamCard1.LoadExamData(_examID))
                btnClose.PerformClick();
        }
    }
}
