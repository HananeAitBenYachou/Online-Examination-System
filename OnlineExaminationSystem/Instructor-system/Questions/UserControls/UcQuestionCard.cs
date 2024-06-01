using Guna.UI2.WinForms;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Instructor_system.Questions.UserControls
{
    public partial class UcQuestionCard : UserControl
    {
        public int? QuestionID { get; private set; } = null;
        public Question Question { get; private set; } = null;

        private Dictionary<Guna2TextBox, string> _choiceMap = new Dictionary<Guna2TextBox, string>();

        public UcQuestionCard()
        {
            InitializeComponent();
            InitializeChoiceMap();
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

        private void CbQuestionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isMcq = cbQuestionTypes.SelectedIndex == 0;

            pnlQuestionChoices.Visible = isMcq;

            PopulateModelAnswerChoices(isMcq ? Question.QuestionTypeOption.MCQ : Question.QuestionTypeOption.TF);
        }

        private void DisplayQuestionData()
        {
            QuestionID = Question.CourseID;

            txtQuestionID.Text = QuestionID.ToString();
            txtCourseID.Text = Question.QuestionID.ToString();
            txtQuestionText.Text = Question.QuestionText;
            cbQuestionTypes.SelectedIndex = cbQuestionTypes.FindStringExact(Question.QuestionType.ToString());
            cbQuestionComplexity.SelectedIndex = cbQuestionComplexity.FindStringExact(Question.DifficultyLevel.ToString());
            nudQuestionMark.Value = Convert.ToDecimal(Question.Mark);

            if (Question.QuestionType == Question.QuestionTypeOption.MCQ)
            {
                txtChoice1.Text = Question.QuestionChoices[0].ChoiceText;
                txtChoice2.Text = Question.QuestionChoices[1].ChoiceText;
                txtChoice3.Text = Question.QuestionChoices[2].ChoiceText;

                string selectedChoice = _choiceMap.FirstOrDefault(pair => pair.Key.Text == Question.ModelAnswer).Value;
                cbModelAnswer.SelectedIndex = cbModelAnswer.FindStringExact(selectedChoice);
            }

            else
            {
                cbModelAnswer.SelectedIndex = cbModelAnswer.FindStringExact(Question.ModelAnswer);
            }
        }

        public bool LoadQuestionData(int? questionID)
        {
            Question = Question.Find(questionID);

            if (Question == null)
            {
                FormUtilities.ShowMessage($"No question with ID = {questionID} was found in the system !" , MessageBoxIcon.Error);
                return false;
            }

            DisplayQuestionData();
            return true;
        }

    }
}
