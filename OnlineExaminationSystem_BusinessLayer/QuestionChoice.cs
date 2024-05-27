using OnlineExaminationSystem_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationSystem_BusinessLayer
{
    public class QuestionChoice
    {

        private enum EnMode { AddNew = 0, Update = 1 };
        private EnMode _mode;
        public int? QuestionChoiceID { get; private set; }
        public int QuestionID { get; set; }
        public string ChoiceText { get; set; }

        public QuestionChoice()
        {
            _mode = EnMode.AddNew;
            QuestionChoiceID = null;
            QuestionID = default;
            ChoiceText = default;
        }
        private QuestionChoice(int? questionChoiceID, int questionID, string choiceText)
        {
            _mode = EnMode.Update;
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
                case EnMode.AddNew:
                    if (AddNewQuestionChoice())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
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

            foreach(var choice in QuestionChoiceData.GetAllQuestionChoices(questionID))                      
            {
                questionChoices.Add(Find(choice.Item1));
            }

            return questionChoices;
        }

    }
}
