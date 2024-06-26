using OnlineExamination_DataAccessLayer;
using System;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Instructor
    {
        private enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;

        public enum FindByOption { InstructorID = 0, PersonID = 1 }
        public int? InstructorID { get; private set; }
        public int PersonID { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public float MonthlySalary { get; set; }
        public bool IsMarkedForDelete { get; set; }
        public bool HasUserAccount { get; }
        public User UserAccountInfo { get; }
        
        public Instructor()
        {
            _mode = Mode.AddNew;
            InstructorID = null;
            PersonID = default;
            HireDate = default;
            ExitDate = null;
            MonthlySalary = default;
            IsMarkedForDelete = default;
            HasUserAccount = default;
            UserAccountInfo = default;
        }
        private Instructor(int? instructorID, int personID, DateTime hireDate, DateTime? exitDate, float monthlySalary, bool isMarkedForDelete)
        {
            _mode = Mode.Update;
            this.InstructorID = instructorID;
            this.PersonID = personID;
            this.HireDate = hireDate;
            this.ExitDate = exitDate;
            this.MonthlySalary = monthlySalary;
            this.IsMarkedForDelete = isMarkedForDelete;
            this.HasUserAccount = User.DoesUserExist(personID, User.Role.Instructor);
            this.UserAccountInfo = User.Find(personID, User.Role.Instructor);
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

            bool isFound = InstructorData.GetInstructorInfoByPersonID(personID, ref instructorID, ref hireDate, ref exitDate, ref monthlySalary, ref isMarkedForDelete);

            if (isFound)
                return new Instructor(instructorID, personID, hireDate, exitDate, monthlySalary, isMarkedForDelete);
            else
                return null;
        }

        public static Instructor Find<T>(T id, FindByOption findByOption)
        {
            switch (findByOption)
            {
                case FindByOption.PersonID:
                    return FindByPersonID(Convert.ToInt32(id));

                case FindByOption.InstructorID:
                    return FindByInstructorID(Convert.ToInt32(id));

                default:
                    return null;
            }
        }

        public static bool DoesInstructorExist<T>(T id, FindByOption findByOption)
        {
            if (id == null)
                return false;

            switch (findByOption)
            {
                case FindByOption.PersonID:
                    return InstructorData.DoesInstructorExistByPersonID(Convert.ToInt32(id));

                case FindByOption.InstructorID:
                    return InstructorData.DoesInstructorExistByInstructorID(Convert.ToInt32(id));

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
                case Mode.AddNew:
                    if (AddNewInstructor())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
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

        public bool DeactivateInstructorUserAccount()
        {
            return User.DeactivateUser(UserAccountInfo.UserID);
        }

        public bool ActivateInstructorUserAccount()
        {
            return User.ActivateUser(UserAccountInfo.UserID);
        }

    }
}