using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem_DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace OnlineExaminationSystem_BusinessLayer
{
    public class Question
    {
        private enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public enum QuestionTypeOption : byte { MCQ = 1, TF = 2 };
        public enum DifficultyLevelOption : byte { Easy = 1, Medium = 2, Hard = 3 };

        public int? QuestionID { get; private set; }
        public string QuestionText { get; set; }
        public int CourseID { get; set; }
        public QuestionTypeOption QuestionType { get; set; }
        public DifficultyLevelOption DifficultyLevel { get; set; }
        public float Mark { get; set; }
        public string ModelAnswer { get; set; }
        public bool IsMarkedForDelete { get; set; }
        public Course CourseInfo { get; }
        public List<QuestionChoice> QuestionChoices { get; set; }

        public Question()
        {
            _mode = Mode.AddNew;
            QuestionID = null;
            QuestionText = default;
            QuestionType = default;
            CourseID = default;
            DifficultyLevel = default;
            Mark = default;
            ModelAnswer = default;
            IsMarkedForDelete = default;
            QuestionChoices = new List<QuestionChoice>() { new QuestionChoice(), new QuestionChoice(), new QuestionChoice() };
        }

        private Question(int? questionID, string questionText, QuestionTypeOption questionType,
                         int courseID, DifficultyLevelOption difficultyLevel, float mark,
                         string modelAnswer, bool isMarkedForDelete)
        {
            _mode = Mode.Update;
            this.QuestionID = questionID;
            this.QuestionText = questionText;
            this.QuestionType = questionType;
            this.CourseID = courseID;
            this.DifficultyLevel = difficultyLevel;
            this.Mark = mark;
            this.ModelAnswer = modelAnswer;
            this.IsMarkedForDelete = isMarkedForDelete;
            CourseInfo = Course.Find(courseID);

            QuestionChoices = QuestionChoice.GetAllQuestionChoices(this.QuestionID.Value);
        }

        public static Question Find(int? questionID)
        {
            string questionText = default;
            byte questionType = default;
            int courseID = default;
            byte difficultyLevel = default;
            float mark = default;
            string modelAnswer = default;
            bool isMarkedForDelete = default;

            bool isFound = QuestionData.GetQuestionInfoByID(questionID, ref questionText, ref questionType, ref courseID, ref difficultyLevel, ref mark, ref modelAnswer, ref isMarkedForDelete);

            if (isFound)
                return new Question(questionID, questionText, (QuestionTypeOption)questionType, courseID, (DifficultyLevelOption)difficultyLevel, mark, modelAnswer, isMarkedForDelete);
            else
                return null;
        }

        public static bool DoesQuestionExist(int? questionID)
        {
            return QuestionData.DoesQuestionExist(questionID);
        }

        private bool SaveQuestionChoices()
        {
            foreach (QuestionChoice choice in QuestionChoices)
            {
                choice.QuestionID = QuestionID.Value;

                if (!choice.Save())
                    return false;
            }
            return true;
        }

        private bool AddNewQuestion()
        {
            QuestionID = QuestionData.AddNewQuestion(QuestionText, (byte)QuestionType, CourseID, (byte)DifficultyLevel, Mark, ModelAnswer, IsMarkedForDelete);

            if (!QuestionID.HasValue)
                return false;

            return SaveQuestionChoices();
        }

        private bool UpdateQuestion()
        {
            bool isUpdatedSuccessfully = QuestionData.UpdateQuestionInfo(QuestionID, QuestionText, (byte)QuestionType, CourseID, (byte)DifficultyLevel, Mark, ModelAnswer, IsMarkedForDelete);

            if (!isUpdatedSuccessfully)
                return false;

            return SaveQuestionChoices();
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (AddNewQuestion())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
                    return UpdateQuestion();

            }
            return false;
        }

        public static bool DeleteQuestion(int? questionID)
        {
            return QuestionData.DeleteQuestion(questionID);
        }

        public static DataTable GetAllQuestions(int? instructorID)
        {
            return QuestionData.GetAllQuestions(instructorID);
        }

        public static DataTable GetRandomQuestions(int courseID , byte numberOfTFQuestions , byte numberOfMcqQuestions)
        {
            return QuestionData.GetRandomQuestions(courseID , numberOfTFQuestions , numberOfMcqQuestions);
        }
    
        public static short GetNumberOfQuestionsByQuestionType(int courseID , QuestionTypeOption questionType)
        {
            return QuestionData.GetNumberOfQuestionsByQuestionType(courseID, (byte)questionType);
        }
    }
}
