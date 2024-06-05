using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system.Exams
{
    public partial class FrmAddUpdateExam : Form
    {
        private enum Mode : byte { AddNew, Update };

        private Mode _mode;
        private int? _examID = null;
        private Exam _exam = null;
        private int? _instructorID = null;
        private int? _courseID = null;
        private bool _areExamQuestionsRegenerated = false;

        public FrmAddUpdateExam(int? examID , int? instructorID)
        {
            InitializeComponent();
            _examID = examID;
            _instructorID = instructorID;
            _mode = Mode.Update;
        }
        public FrmAddUpdateExam(int? instructorID)
        {
            InitializeComponent();
            _instructorID = instructorID;
            _mode = Mode.AddNew;
        }

        private void FrmAddUpdateExam_Load(object sender, EventArgs e)
        {
            InitializeForm();

            if (_mode == Mode.Update)
                LoadExamData();
        }

        private void InitializeForm()
        {
            PopulateCourses();

            _exam = _mode == Mode.AddNew ? new Exam() : null;

            lblTitle.Text = _mode == Mode.AddNew ? "Generate New Exam" : "Update Exam";

            dtpExamDate.Value = DateTime.Now;
        }

        private void LoadExamData()
        {           
            _exam = Exam.Find(_examID);

            if (_exam == null || _exam.IsCompleted)
            {
                string message = _exam == null ?
                    $"No exam with ID = {_examID} was found in the system!" :
                    "This exam has already been completed and cannot be updated.";

                FormUtilities.ShowMessage(message, MessageBoxIcon.Error);
                Close();
                return;
            }

            DisplayExamData();
        }

        private void PopulateCourses()
        {
            cbCourses.DataSource = InstructorCourse.GetAllInstructorCoursesNames(_instructorID);
            cbCourses.SelectedIndex = 0;
        }

        private void DisplayExamData()
        {
            txtExamID.Text = _exam.ExamID.ToString();
            cbCourses.SelectedIndex = cbCourses.FindStringExact(Course.Find(_exam.CourseID).Name);
            dtpExamDate.Value = _exam.ExaminationDate;
            nudExamDuration.Value = _exam.Duration;
            nudNoOfTFQuestions.Value = _exam.NumOfTrueFalseQuestions;
            nudNoOfMcqQuestions.Value = _exam.NumOfMCQQuestions;
            dgvGeneratedQuestionsList.DataSource = _exam.GetAllExamQuestions();
        }

        private bool SaveExamData(List<int> examQuestions)
        {
            UpdateExamData();

            if (!_exam.Save(examQuestions , _areExamQuestionsRegenerated))
            {
                FormUtilities.ShowMessage("Exam data is not saved successfully.", MessageBoxIcon.Error);
                return false;
            }

            FormUtilities.ShowMessage("Exam data saved successfully !", MessageBoxIcon.Information);
            UpdateFormAfterSave();
            return true;
        }

        private void UpdateFormAfterSave()
        {
            _mode = Mode.Update;
            _examID = _exam.CourseID;
        }

        private void UpdateExamData()
        {
            _exam.CourseID = _courseID.Value;
            _exam.Duration = (byte)nudExamDuration.Value;
            _exam.ExaminationDate = dtpExamDate.Value;
            _exam.NumOfTrueFalseQuestions = (byte)nudNoOfTFQuestions.Value;
            _exam.NumOfMCQQuestions = (byte)nudNoOfMcqQuestions.Value;
            _exam.IsMarkedForDelete = _mode == Mode.AddNew ? false : _exam.IsMarkedForDelete;
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                FormUtilities.ShowMessage("Some fields are not valid. Please check the red icon(s) for details.", MessageBoxIcon.Warning);
                return;
            }

            List<int> examQuestions = dgvGeneratedQuestionsList.Rows.Cast<DataGridViewRow>()
                                            .Select(row => (int)row.Cells[0].Value)
                                            .ToList();
            if(examQuestions.Count == 0)
            {
                FormUtilities.ShowMessage("Please generate the exam questions first !", MessageBoxIcon.Warning);
                return;
            }

            SaveExamData(examQuestions);
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BtnGenerateQuestions_Click(object sender, EventArgs e)
        {
            _areExamQuestionsRegenerated = _mode == Mode.Update;
            dgvGeneratedQuestionsList.DataSource = Question.GetRandomQuestions(_courseID.Value, (byte)nudNoOfTFQuestions.Value, (byte)nudNoOfMcqQuestions.Value);
        }

        private void CbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _courseID = Course.Find(cbCourses.Text).CourseID;
            nudNoOfTFQuestions.Maximum = Question.GetNumberOfQuestionsByQuestionType(_courseID.Value , Question.QuestionTypeOption.TF);
            nudNoOfMcqQuestions.Maximum = Question.GetNumberOfQuestionsByQuestionType(_courseID.Value, Question.QuestionTypeOption.MCQ);
        }

    }
}
