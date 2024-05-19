using OnlineExamination_DataAccessLayer;
using System;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Instructor
    {
        private enum EnMode { AddNew = 0, Update = 1 };
        private EnMode _mode;

        public enum EnFilterBy { InstructorID = 0, PersonID = 1 }
        public int? InstructorID { get; private set; }
        public int PersonID { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public float MonthlySalary { get; set; }
        public bool IsMarkedForDelete { get; set; }

        public Instructor()
        {
            _mode = EnMode.AddNew;
            InstructorID = null;
            PersonID = default;
            HireDate = default;
            ExitDate = null;
            MonthlySalary = default;
            IsMarkedForDelete = default;
        }
        private Instructor(int? instructorID, int personID, DateTime hireDate, DateTime? exitDate, float monthlySalary, bool isMarkedForDelete)
        {
            _mode = EnMode.Update;
            this.InstructorID = instructorID;
            this.PersonID = personID;
            this.HireDate = hireDate;
            this.ExitDate = exitDate;
            this.MonthlySalary = monthlySalary;
            this.IsMarkedForDelete = isMarkedForDelete;
        }

        private static Instructor FindByInstructorID(int? instructorID)
        {
            int personID = default;
            DateTime hireDate = default;
            DateTime? exitDate = default;
            float monthlySalary = default;
            bool isMarkedForDelete = default;

            bool isFound = InstructorData.GetInstructorInfoByInstructorID(instructorID, ref personID, ref hireDate, ref exitDate, ref monthlySalary, ref isMarkedForDelete);

            if (isFound)
                return new Instructor(instructorID, personID, hireDate, exitDate, monthlySalary, isMarkedForDelete);
            else
                return null;
        }

        private static Instructor FindByPersonID(int personID)
        {
            int? instructorID = default;
            DateTime hireDate = default;
            DateTime? exitDate = default;
            float monthlySalary = default;
            bool isMarkedForDelete = default;

            bool isFound = InstructorData.GetInstructorInfoByPersonID(personID , ref instructorID, ref hireDate, ref exitDate, ref monthlySalary, ref isMarkedForDelete);

            if (isFound)
                return new Instructor(instructorID, personID, hireDate, exitDate, monthlySalary, isMarkedForDelete);
            else
                return null;
        }

        public static Instructor Find<T>(T filterValue, EnFilterBy filterBy)
        {
            switch (filterBy)
            {
                case EnFilterBy.PersonID:
                    return FindByPersonID(Convert.ToInt32(filterValue));

                case EnFilterBy.InstructorID:
                    return FindByInstructorID(Convert.ToInt32(filterValue));

                default:
                    return null;
            }
        }

        public static bool DoesInstructorExist<T>(T filterValue, EnFilterBy filterBy)
        {
            if (filterValue == null)
                return false;

            switch (filterBy)
            {
                case EnFilterBy.PersonID:
                    return InstructorData.DoesInstructorExistByPersonID(Convert.ToInt32(filterValue));

                case EnFilterBy.InstructorID:
                    return InstructorData.DoesInstructorExistByInstructorID(Convert.ToInt32(filterValue));

                default:
                    return false;
            }
        }

        private bool AddNewInstructor()
        {
            InstructorID = InstructorData.AddNewInstructor(PersonID, HireDate, ExitDate, MonthlySalary, IsMarkedForDelete);
            return InstructorID.HasValue;
        }

        private bool UpdateInstructor()
        {
            return InstructorData.UpdateInstructorInfo(InstructorID, PersonID, HireDate, ExitDate, MonthlySalary, IsMarkedForDelete);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case EnMode.AddNew:
                    if (AddNewInstructor())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateInstructor();

            }
            return false;
        }

        public static bool DeleteInstructor(int? instructorID)
        {
            return InstructorData.DeleteInstructor(instructorID);
        }

        public static DataTable GetAllInstructors()
        {
            return InstructorData.GetAllInstructors();
        }

    }
}