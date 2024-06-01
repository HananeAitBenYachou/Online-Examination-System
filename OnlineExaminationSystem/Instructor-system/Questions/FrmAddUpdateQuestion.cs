using Guna.UI2.WinForms;
using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system.Questions
{
    public partial class FrmAddUpdateQuestion : Form
    {
        private enum Mode : byte { AddNew, Update };
        private Mode _mode;

        private int? _questionID = null;
        private Question _question = null;

        private Dictionary<Guna2TextBox, string> _choiceMap = new Dictionary<Guna2TextBox, string>();

        private readonly int? _instructorID = null;

        public FrmAddUpdateQuestion(int? questionID, int? instructorID)
        {
            InitializeComponent();
            _questionID = questionID;
            _mode = Mode.Update;
            _instructorID = instructorID;
        }

        public FrmAddUpdateQuestion(int? instructorID)
        {
            InitializeComponent();
            _mode = Mode.AddNew;
            _instructorID = instructorID;
        }

        private void FrmAddUpdateQuestion_Load(object sender, EventArgs e)
        {
            InitializeForm();

            if (_mode == Mode.Update)
                LoadQuestionData();
        }

        private void LoadQuestionData()
        {
            _question = Question.Find(_questionID);

            if (_question == null)
            {
                FormUtilities.ShowMessage($"No question with ID = {_questionID} was found in the system !" ,MessageBoxIcon.Error);
                Close();
                return;
            }

            DisplayQuestionData();
        }

        private void PopulateCourses()
        {
            cbCourses.DataSource = InstructorCourse.GetAllInstructorCoursesNames(_instructorID);
            cbCourses.SelectedIndex = 0;
        }

        private void DisplayQuestionData()
        {
            txtQuestionText.Text = _question.QuestionText;
            cbCourses.SelectedIndex = cbCourses.FindStringExact(Course.Find(_question.CourseID).Name);
            cbQuestionTypes.SelectedIndex = cbQuestionTypes.FindStringExact(_question.QuestionType.ToString());
            cbQuestionComplexity.SelectedIndex = cbQuestionComplexity.FindStringExact(_question.DifficultyLevel.ToString());
            nudQuestionMark.Value = Convert.ToDecimal(_question.Mark);

            if (_question.QuestionType == Question.QuestionTypeOption.MCQ)
            {
                txtChoice1.Text = _question.QuestionChoices[0].ChoiceText;
                txtChoice2.Text = _question.QuestionChoices[1].ChoiceText;
                txtChoice3.Text = _question.QuestionChoices[2].ChoiceText;

                string selectedChoice = _choiceMap.FirstOrDefault(pair => pair.Key.Text == _question.ModelAnswer).Value;
                cbModelAnswer.SelectedIndex = cbModelAnswer.FindStringExact(selectedChoice);
            }

            else
            {
                cbModelAnswer.SelectedIndex = cbModelAnswer.FindStringExact(_question.ModelAnswer);
            }
        }

        private void PopulateModelAnswerChoices(Question.QuestionTypeOption questionType)
        {
            cbModelAnswer.Items.Clear();
            cbModelAnswer.Items.AddRange(questionType == Question.QuestionTypeOption.MCQ
                ? new[] { "Choice 1", "Choice 2", "Choice 3" }
                : new[] { "True", "False" });

            cbModelAnswer.SelectedIndex = 0;
        }

        private void InitializeChoiceMap()
        {
            _choiceMap.Add(txtChoice1, "Choice 1");
            _choiceMap.Add(txtChoice2, "Choice 2");
            _choiceMap.Add(txtChoice3, "Choice 3");
        }

        private void InitializeForm()
        {
            PopulateCourses();
            InitializeChoiceMap();

            if (_mode == Mode.AddNew)
                _question = new Question();

            cbQuestionTypes.SelectedIndex = 0;
            cbQuestionComplexity.SelectedIndex = 0;

            lblTitle.Text = _mode == Mode.AddNew ? "Add New Question" : "Update Question";
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                FormUtilities.ShowMessage("Some fields are not valid. Please check the red icon(s) for details.", MessageBoxIcon.Warning);
                return;
            }

            SaveQuestionData();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private bool SaveQuestionData()
        {
            UpdateQuestionData();

            if (!_question.Save())
            {
                FormUtilities.ShowMessage("Question data is not saved successfully.", MessageBoxIcon.Error);
                return false;
            }

            else
            {
                FormUtilities.ShowMessage("Question data saved successfully !" , MessageBoxIcon.Information);
                UpdateFormAfterSave();
                return true;
            }
        }

        private void UpdateFormAfterSave()
        {
            _mode = Mode.Update;
            _questionID = _question.CourseID;
        }

        private void UpdateQuestionData()
        {
            _question.CourseID = Course.Find(cbCourses.Text).CourseID.Value;
            _question.QuestionText = txtQuestionText.Text.Trim();
            _question.QuestionType = (Question.QuestionTypeOption)Enum.Parse(typeof(Question.QuestionTypeOption), cbQuestionTypes.Text);
            _question.DifficultyLevel = (Question.DifficultyLevelOption)Enum.Parse(typeof(Question.DifficultyLevelOption), cbQuestionComplexity.Text);
            _question.Mark = Convert.ToSingle(nudQuestionMark.Value);
            _question.IsMarkedForDelete = _mode == Mode.AddNew ? false : _question.IsMarkedForDelete;
            _question.ModelAnswer = _question.QuestionType == Question.QuestionTypeOption.MCQ
                ? _choiceMap.First(x => x.Value == cbModelAnswer.Text).Key.Text
                : cbModelAnswer.Text;

            var y = _question.QuestionChoices.Count;
            _question.QuestionChoices = _question.QuestionChoices
                    .Select((qChoice, index) =>
                    {
                        qChoice.ChoiceText = _choiceMap.Keys.ElementAt(index).Text;
                        return qChoice;

                    }).ToList();
        }

        private void SetValidationError(Control control, System.ComponentModel.CancelEventArgs e, string errorMessage)
        {
            e.Cancel = true;
            control.Focus();
            errorProvider1.SetError(control, errorMessage);
        }

        private void ClearValidationError(Control control, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider1.SetError(control, null);
        }

        private void CbQuestionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isMcq = cbQuestionTypes.SelectedIndex == 0;

            pnlQuestionChoices.Visible = isMcq;

            if (isMcq)
                AttachValidatingEventHandlers();
            else
                DetachValidatingEventHandlers();

            PopulateModelAnswerChoices(isMcq ? Question.QuestionTypeOption.MCQ : Question.QuestionTypeOption.TF);
        }

        private void AttachValidatingEventHandlers()
        {
            _choiceMap.Keys.ToList().ForEach(t => t.Validating += TextBox_Validating);
        }

        private void DetachValidatingEventHandlers()
        {
            _choiceMap.Keys.ToList().ForEach(t => t.Validating -= TextBox_Validating);
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
                SetValidationError(textBox, e, "This field is required !");
            else
                ClearValidationError(textBox, e);
        }

    }
}
