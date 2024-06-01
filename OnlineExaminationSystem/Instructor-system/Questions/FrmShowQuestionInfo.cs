using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system.Questions
{
    public partial class FrmShowQuestionInfo : Form
    {
        private readonly int? _questionID = null;

        public FrmShowQuestionInfo(int? questionID)
        {
            InitializeComponent();
            this._questionID = questionID;
        }

        private void FrmShowQuestionInfo_Load(object sender, EventArgs e)
        {
            if (!ucQuestionCard1.LoadQuestionData(_questionID))
                btnClose.PerformClick();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
