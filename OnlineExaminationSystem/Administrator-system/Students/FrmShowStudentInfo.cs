using OnlineExaminationSystem.Administrator.Students.UserControls;
using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Students
{
    public partial class FrmShowStudentInfo : Form
    {
        private readonly int? _id;
        private readonly UcStudentCard.LoadByOption _loadByOption;

        public FrmShowStudentInfo(int? id, UcStudentCard.LoadByOption loadByOption)
        {
            InitializeComponent();
            _id = id;
            _loadByOption = loadByOption;
        }

        private void FrmShowStudentInfo_Load(object sender, EventArgs e)
        {
            if (!LoadStudentData())
            {
                btnClose.PerformClick();
            }
        }

        private bool LoadStudentData()
        {
            switch (_loadByOption)
            {
                case UcStudentCard.LoadByOption.PersonID:
                    return LoadStudentDataByPersonID();
                case UcStudentCard.LoadByOption.StudentID:
                    return LoadStudentDataByStudentID();
                default:
                    return false;
            }
        }

        private bool LoadStudentDataByPersonID()
        {
            return ucStudentCard1.LoadStudentData(_id, UcStudentCard.LoadByOption.PersonID);
        }

        private bool LoadStudentDataByStudentID()
        {
            return ucStudentCard1.LoadStudentData(_id, UcStudentCard.LoadByOption.StudentID);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
