using OnlineExaminationSystem_DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace OnlineExaminationSystem_BusinessLayer
{
    public class ExamQuestion
    {
        private enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public int? ExamQuestionID { get; private set; }
        public int ExamID { get; set; }
        public int QuestionID { get; set; }
        public Question QuestionInfo { get; }
        public ExamQuestion()
        {
            _mode = Mode.AddNew;
            ExamQuestionID = null;
            ExamID = default;
            QuestionID = default;

        }

        private ExamQuestion(int? examQuestionID, int examID, int questionID)
        {
            _mode = Mode.Update;
            this.ExamQuestionID = examQuestionID;
            this.ExamID = examID;
            this.QuestionID = questionID;
            this.QuestionInfo = Question.Find(questionID);
        }

        public static ExamQuestion Find(int? examQuestionID)
        {
            int examID = default;
            int questionID = default;

            bool isFound = ExamQuestionData.GetExamQuestionInfoByID(examQuestionID, ref examID, ref questionID);

            if (isFound)
                return new ExamQuestion(examQuestionID, examID, questionID);
            else
                return null;
        }

        public static bool DoesExamQuestionExist(int? examQuestionID)
        {
            return ExamQuestionData.DoesExamQuestionExist(examQuestionID);
        }

        private bool AddNewExamQuestion()
        {
            ExamQuestionID = ExamQuestionData.AddNewExamQuestion(ExamID, QuestionID);
            return ExamQuestionID.HasValue;
        }

        private bool UpdateExamQuestion()
        {
            return ExamQuestionData.UpdateExamQuestionInfo(ExamQuestionID, ExamID, QuestionID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (AddNewExamQuestion())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
                    return UpdateExamQuestion();

            }
            return false;
        }

        public static bool DeleteExamQuestion(int? examQuestionID)
        {
            return ExamQuestionData.DeleteExamQuestion(examQuestionID);
        }

        public static DataTable GetAllExamQuestions(int examID)
        {
            return ExamQuestionData.GetAllExamQuestions(examID);
        }

        public static List<ExamQuestion> GetAllExamQuestionsList(int examID)
        {
            List<ExamQuestion> examQuestions = new List<ExamQuestion>();

            foreach (DataRow row in GetAllExamQuestions(examID).Rows)
            {
                examQuestions.Add(Find((int?)row["Question ID"]));
            }

            return examQuestions;
        }

    }
}
