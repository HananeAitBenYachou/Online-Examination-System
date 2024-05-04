using OnlineExamination_DataAccessLayer;
using System;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Student
    {
        private enum EnMode { AddNew = 0, Update = 1 };
        private EnMode _mode;
        public int? StudentID { get; private set; }
        public int PersonID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool IsMarkedForDelete { get; set; }
        public int? TrackID { get; set; }

        public Student()
        {
            _mode = EnMode.AddNew;
            StudentID = null;
            PersonID = default;
            StartDate = default;
            GraduationDate = default;
            IsMarkedForDelete = default;
            TrackID = null;
        }
        private Student(int? studentID, int personID, DateTime startDate, DateTime graduationDate, bool isMarkedForDelete, int? trackID)
        {
            _mode = EnMode.Update;
            this.StudentID = studentID;
            this.PersonID = personID;
            this.StartDate = startDate;
            this.GraduationDate = graduationDate;
            this.IsMarkedForDelete = isMarkedForDelete;
            this.TrackID = trackID;
        }

        public static Student Find(int? studentID)
        {
            int personID = default;
            DateTime startDate = default;
            DateTime graduationDate = default;
            bool isMarkedForDelete = default;
            int? trackID = default;

            bool isFound = StudentData.GetStudentInfoByID(studentID, ref personID, ref startDate, ref graduationDate, ref isMarkedForDelete, ref trackID);

            if (isFound)
                return new Student(studentID, personID, startDate, graduationDate, isMarkedForDelete, trackID);
            else
                return null;
        }

        public static bool DoesStudentExist(int? studentID)
        {
            return StudentData.DoesStudentExist(studentID);
        }

        private bool AddNewStudent()
        {
            StudentID = StudentData.AddNewStudent(PersonID, StartDate, GraduationDate, IsMarkedForDelete, TrackID);
            return StudentID.HasValue;
        }

        private bool UpdateStudent()
        {
            return StudentData.UpdateStudentInfo(StudentID, PersonID, StartDate, GraduationDate, IsMarkedForDelete, TrackID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case EnMode.AddNew:
                    if (AddNewStudent())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateStudent();

            }
            return false;
        }

        public static bool DeleteStudent(int? studentID)
        {
            return StudentData.DeleteStudent(studentID);
        }

        public static DataTable GetAllStudents()
        {
            return StudentData.GetAllStudents();
        }

    }
}