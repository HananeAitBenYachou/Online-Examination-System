using OnlineExaminationSystem_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineExaminationSystem_BusinessLayer
{
    public class Exam
    {
        private enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public int? ExamID { get; private set; }
        public int CourseID { get; set; }
        public byte Duration { get; set; }
        public DateTime ExaminationDate { get; set; }
        public byte NumOfTrueFalseQuestions { get; set; }
        public byte NumOfMCQQuestions { get; set; }
        public bool IsMarkedForDelete { get; set; }
        public List<ExamQuestion> ExamQuestions { get; private set; }
        public bool IsCompleted => ExaminationDate <= DateTime.Now;

        public Exam()
        {
            _mode = Mode.AddNew;
            ExamID = null;
            CourseID = default;
            Duration = default;
            ExaminationDate = default;
            NumOfTrueFalseQuestions = default;
            NumOfMCQQuestions = default;
            IsMarkedForDelete = default;
            ExamQuestions = new List<ExamQuestion>();
        }
        private Exam(int? examID, int courseID, byte duration, DateTime examinationDate, 
                     byte numOfTrueFalseQuestions, byte numOfMCQQuestions, bool isMarkedForDelete)
        {
            _mode = Mode.Update;
            this.ExamID = examID;
            this.CourseID = courseID;
            this.Duration = duration;
            this.ExaminationDate = examinationDate;
            this.NumOfTrueFalseQuestions = numOfTrueFalseQuestions;
            this.NumOfMCQQuestions = numOfMCQQuestions;
            this.IsMarkedForDelete = isMarkedForDelete;
            this.ExamQuestions = ExamQuestion.GetAllExamQuestionsList(examID.Value);
        }

        public static Exam Find(int? examID)
        {
            int courseID = default;
            byte duration = default;
            DateTime examinationDate = default;
            byte numOfTrueFalseQuestions = default;
            byte numOfMCQQuestions = default;
            bool isMarkedForDelete = default;

            bool isFound = ExamData.GetExamInfoByID(examID, ref courseID, ref duration, ref examinationDate, ref numOfTrueFalseQuestions, ref numOfMCQQuestions, ref isMarkedForDelete);

            if (isFound)
                return new Exam(examID, courseID, duration, examinationDate, numOfTrueFalseQuestions, numOfMCQQuestions, isMarkedForDelete);
            else
                return null;
        }

        public static bool DoesExamExist(int? examID)
        {
            return ExamData.DoesExamExist(examID);
        }

        private bool AddNewExam(List<int> examQuestions)
        {
            ExamID = ExamData.AddNewExam(CourseID, Duration, ExaminationDate, NumOfTrueFalseQuestions, NumOfMCQQuestions, IsMarkedForDelete);
            
            if(!ExamID.HasValue)
                return false;

            return SaveExamQuestions(examQuestions);
        }

        private bool SaveExamQuestions(List<int> examQuestions)
        {
            foreach(int questionID in examQuestions)
            {
                ExamQuestion examQuestion = new ExamQuestion();

                examQuestion.QuestionID = questionID;
                examQuestion.ExamID = this.ExamID.Value;

                if(!examQuestion.Save())
                    return false;
            }

            return true;
        }

        private bool UpdateExam(List<int> examQuestions , bool areExamQuestionsRegenerated)
        {
            bool isUpdatedSuccessfully  = ExamData.UpdateExamInfo(ExamID, CourseID, Duration, ExaminationDate, NumOfTrueFalseQuestions, NumOfMCQQuestions, IsMarkedForDelete , areExamQuestionsRegenerated);

            if (!isUpdatedSuccessfully)
                return false;

            return areExamQuestionsRegenerated ? SaveExamQuestions(examQuestions) : true;
        }

        public bool Save(List<int> examQuestions , bool areExamQuestionsRegenerated)
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (AddNewExam(examQuestions))
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
                    return UpdateExam(examQuestions , areExamQuestionsRegenerated);

            }
            return false;
        }

        public static bool DeleteExam(int? examID)
        {
            return ExamData.DeleteExam(examID);
        }

        public static DataTable GetAllExams()
        {
            return ExamData.GetAllExams();
        }

        public DataTable GetAllExamQuestions()
        {
            return ExamQuestion.GetAllExamQuestions(this.ExamID.Value);
        }
    }
}
