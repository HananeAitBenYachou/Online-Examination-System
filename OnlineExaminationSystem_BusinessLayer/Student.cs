using OnlineExamination_DataAccessLayer;
using System;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Student
    {
        private enum EnMode { AddNew = 0, Update = 1 };
        private EnMode _mode;

        public enum EnFilterBy { StudentID = 0, PersonID = 1 }
        public int? StudentID { get; private set; }
        public int PersonID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool IsMarkedForDelete { get; set; }
        public int? TrackID { get; set; }
        public Track TrackInfo { get; }

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
        private Student(int? studentID, int personID, DateTime startDate,
                        DateTime graduationDate, bool isMarkedForDelete, int? trackID)
        {
            _mode = EnMode.Update;
            this.StudentID = studentID;
            this.PersonID = personID;
            this.StartDate = startDate;
            this.GraduationDate = graduationDate;
            this.IsMarkedForDelete = isMarkedForDelete;
            this.TrackID = trackID;
            this.TrackInfo = Track.Find(trackID);
        }

        private static Student FindByStudentID(int? studentID)
        {
            int personID = default;
            DateTime startDate = default;
            DateTime graduationDate = default;
            bool isMarkedForDelete = default;
            int? trackID = default;

            bool isFound = StudentData.GetStudentInfoByStudentID(studentID, ref personID, ref startDate, ref graduationDate, ref isMarkedForDelete, ref trackID);

            if (isFound)
                return new Student(studentID, personID, startDate, graduationDate, isMarkedForDelete, trackID);
            else
                return null;
        }

        private static Student FindByPersonID(int personID)
        {
            int? studentID = default;
            DateTime startDate = default;
            DateTime graduationDate = default;
            bool isMarkedForDelete = default;
            int? trackID = default;

            bool isFound = StudentData.GetStudentInfoByPersonID(personID, ref studentID, ref startDate, ref graduationDate, ref isMarkedForDelete, ref trackID);

            if (isFound)
                return new Student(studentID, personID, startDate, graduationDate, isMarkedForDelete, trackID);
            else
                return null;
        }

        public static Student Find<T>(T filterValue, EnFilterBy filterBy)
        {
            switch (filterBy)
            {
                case EnFilterBy.PersonID:
                    return FindByPersonID(Convert.ToInt32(filterValue));

                case EnFilterBy.StudentID:
                    return FindByStudentID(Convert.ToInt32(filterValue));

                default:
                    return null;
            }
        }

        public static bool DoesStudentExist<T>(T filterValue, EnFilterBy filterBy)
        {
            if (filterValue == null)
                return false;

            switch (filterBy)
            {
                case EnFilterBy.PersonID:
                    return StudentData.DoesStudentExistByPersonID(Convert.ToInt32(filterValue));

                case EnFilterBy.StudentID:
                    return StudentData.DoesStudentExistByStudentID(Convert.ToInt32(filterValue));

                default:
                    return false;
            }
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