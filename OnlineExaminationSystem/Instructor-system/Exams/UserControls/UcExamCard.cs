using Guna.UI2.WinForms;
using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem.Instructor_system.Questions;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system.Exams.UserControls
{
    public partial class UcExamCard : UserControl
    {
        public int? ExamID { get; private set; } = null;
        public Exam Exam { get; private set; } = null;

        public UcExamCard()
        {
            InitializeComponent();
        }

        private void DisplayExamData()
        {
            ExamID = Exam.ExamID;

            txtExamID.Text = Exam.ExamID.ToString();
            txtCourse.Text = Exam.CourseInfo.Name;
            dtpExamDate.Value = Exam.ExaminationDate;
            nudExamDuration.Value = Exam.Duration;
            nudNoOfTFQuestions.Value = Exam.NumOfTrueFalseQuestions;
            nudNoOfMcqQuestions.Value = Exam.NumOfMCQQuestions;      
            dgvExamQuestionsList.DataSource = Exam.GetAllExamQuestions();

            if (Exam.IsCompleted)
                rbCompleted.Checked = true;
            else
                rbUpcoming.Checked = true;
        }

        public bool LoadExamData(int? examID)
        {
            Exam = Exam.Find(examID);

            if (Exam == null)
            {
                FormUtilities.ShowMessage($"No exam with ID = {examID} was found in the system !", MessageBoxIcon.Error);
                return false;
            }

            DisplayExamData();
            return true;
        }

        private void DgvExamQuestionsList_SelectionChanged(object sender, EventArgs e)
        {
            cmsQuestions.Enabled = dgvExamQuestionsList.SelectedRows.Count > 0;
        }

        private void ShowQuestionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowQuestionInfo form = new FrmShowQuestionInfo((int)dgvExamQuestionsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }
    }
}
