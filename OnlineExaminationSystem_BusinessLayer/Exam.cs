using OnlineExaminationSystem_DataAccessLayer;
using System;
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
        }
        private Exam(int? examID, int courseID, byte duration, DateTime examinationDate, byte numOfTrueFalseQuestions, byte numOfMCQQuestions, bool isMarkedForDelete)
        {
            _mode = Mode.Update;
            this.ExamID = examID;
            this.CourseID = courseID;
            this.Duration = duration;
            this.ExaminationDate = examinationDate;
            this.NumOfTrueFalseQuestions = numOfTrueFalseQuestions;
            this.NumOfMCQQuestions = numOfMCQQuestions;
            this.IsMarkedForDelete = isMarkedForDelete;
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

        private bool AddNewExam()
        {
            ExamID = ExamData.AddNewExam(CourseID, Duration, ExaminationDate, NumOfTrueFalseQuestions, NumOfMCQQuestions, IsMarkedForDelete);
            return ExamID.HasValue;
        }

        private bool UpdateExam()
        {
            return ExamData.UpdateExamInfo(ExamID, CourseID, Duration, ExaminationDate, NumOfTrueFalseQuestions, NumOfMCQQuestions, IsMarkedForDelete);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (AddNewExam())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
                    return UpdateExam();

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
    }
}
