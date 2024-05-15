using OnlineExamination_BusinessLayer;
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
using static OnlineExaminationSystem.Administrator.Students.UserControls.UcStudentCard;

namespace OnlineExaminationSystem.Administrator.Students
{
    public partial class FrmShowStudentInfo : Form
    {
        private readonly int? _value;
        private readonly UcStudentCard.EnLoadBy _loadBy;

        public FrmShowStudentInfo(int? value, UcStudentCard.EnLoadBy loadBy)
        {
            InitializeComponent();
            _value = value;
            _loadBy = loadBy;
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
            switch (_loadBy)
            {
                case UcStudentCard.EnLoadBy.PersonID:
                    return LoadStudentDataByPersonID();
                case UcStudentCard.EnLoadBy.StudentID:
                    return LoadStudentDataByStudentID();
                default:
                    return false;
            }
        }

        private bool LoadStudentDataByPersonID()
        {
            return ucStudentCard1.LoadStudentData(_value, UcStudentCard.EnLoadBy.PersonID);
        }

        private bool LoadStudentDataByStudentID()
        {
            return ucStudentCard1.LoadStudentData(_value, UcStudentCard.EnLoadBy.StudentID);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
