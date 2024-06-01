using OnlineExaminationSystem_DataAccessLayer;
using System.Collections.Generic;

namespace OnlineExaminationSystem_BusinessLayer
{
    public class QuestionChoice
    {

        private enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public int? QuestionChoiceID { get; private set; }
        public int QuestionID { get; set; }
        public string ChoiceText { get; set; }

        public QuestionChoice()
        {
            _mode = Mode.AddNew;
            QuestionChoiceID = null;
            QuestionID = default;
            ChoiceText = default;
        }
        private QuestionChoice(int? questionChoiceID, int questionID, string choiceText)
        {
            _mode = Mode.Update;
            this.QuestionChoiceID = questionChoiceID;
            this.QuestionID = questionID;
            this.ChoiceText = choiceText;
        }

        public static QuestionChoice Find(int? questionChoiceID)
        {
            int questionID = default;
            string choiceText = default;

            bool isFound = QuestionChoiceData.GetQuestionChoiceInfoByID(questionChoiceID, ref questionID, ref choiceText);

            if (isFound)
                return new QuestionChoice(questionChoiceID, questionID, choiceText);
            else
                return null;
        }

        public static bool DoesQuestionChoiceExist(int? questionChoiceID)
        {
            return QuestionChoiceData.DoesQuestionChoiceExist(questionChoiceID);
        }

        private bool AddNewQuestionChoice()
        {
            QuestionChoiceID = QuestionChoiceData.AddNewQuestionChoice(QuestionID, ChoiceText);
            return QuestionChoiceID.HasValue;
        }

        private bool UpdateQuestionChoice()
        {
            return QuestionChoiceData.UpdateQuestionChoiceInfo(QuestionChoiceID, QuestionID, ChoiceText);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (AddNewQuestionChoice())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
                    return UpdateQuestionChoice();

            }
            return false;
        }

        public static bool DeleteQuestionChoice(int? questionChoiceID)
        {
            return QuestionChoiceData.DeleteQuestionChoice(questionChoiceID);
        }

        public static List<QuestionChoice> GetAllQuestionChoices(int questionID)
        {
            List<QuestionChoice> questionChoices = new List<QuestionChoice>();

            foreach (var choice in QuestionChoiceData.GetAllQuestionChoices(questionID))
            {
                questionChoices.Add(Find(choice.Item1));
            }

            return questionChoices;
        }

    }
}
