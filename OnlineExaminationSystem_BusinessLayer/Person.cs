using OnlineExamination_DataAccessLayer;
using System;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Person
    {
        private enum Mode : byte
        { AddNew = 0, Update = 1 };
        public enum FindByOption : byte
        {
            PersonID, NationalNo, Email
        }
        public enum GenderType : byte
        {
            Male, Female
        }

        private Mode _mode;
        public int? PersonID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public char Gender { get; set; }
        public GenderType GenderText => (Gender == 'M' ? GenderType.Male : GenderType.Female);
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonalImagePath { get; set; }

        public Person()
        {
            _mode = Mode.AddNew;
            PersonID = null;
            FirstName = default;
            LastName = default;
            NationalNo = default;
            Gender = default;
            BirthDate = default;
            Email = default;
            Address = null;
            PhoneNumber = null;
            PersonalImagePath = null;
        }
        private Person(int? personID, string firstName, string lastName,
                       string nationalNo, char gender, DateTime birthDate,
                       string email, string address, string phoneNumber, string personalImagePath)
        {
            _mode = Mode.Update;
            this.PersonID = personID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.NationalNo = nationalNo;
            this.Gender = gender;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.PersonalImagePath = personalImagePath;
        }

        public static Person Find(int? personID)
        {
            string firstName = default;
            string lastName = default;
            string nationalNo = default;
            char gender = default;
            DateTime birthDate = default;
            string email = default;
            string address = default;
            string phoneNumber = default;
            string personalImagePath = default;

            bool isFound = PersonData.GetPersonInfoByID(personID, ref firstName, ref lastName,
                                                        ref nationalNo, ref gender, ref birthDate,
                                                        ref email, ref address, ref phoneNumber, ref personalImagePath);

            if (isFound)
                return new Person(personID, firstName, lastName,
                                  nationalNo, gender, birthDate,
                                  email, address, phoneNumber, personalImagePath);
            else
                return null;
        }

        public static Person Find(string nationalNo)
        {
            int? personID = default;
            string firstName = default;
            string lastName = default;
            char gender = default;
            DateTime birthDate = default;
            string email = default;
            string address = default;
            string phoneNumber = default;
            string personalImagePath = default;

            bool isFound = PersonData.GetPersonInfoByNationalNo(nationalNo, ref personID, ref firstName,
                                                                ref lastName, ref gender, ref birthDate,
                                                                ref email, ref address, ref phoneNumber, ref personalImagePath);
            if (isFound)
                return new Person(personID, firstName, lastName,
                                  nationalNo, gender, birthDate,
                                  email, address, phoneNumber, personalImagePath);
            else
                return null;
        }

        public static bool DoesPersonExist<T>(T value, FindByOption findByOption)
        {
            if (value == null)
                return false;

            switch (findByOption)
            {
                case FindByOption.PersonID:
                    return PersonData.DoesPersonExistByID(Convert.ToInt32(value));

                case FindByOption.NationalNo:
                    return PersonData.DoesPersonExistByNationalNo(Convert.ToString(value));

                case FindByOption.Email:
                    return PersonData.DoesPersonExistByEmail(Convert.ToString(value));

                default:
                    return false;
            }
        }

        private bool AddNewPerson()
        {
            PersonID = PersonData.AddNewPerson(FirstName, LastName, NationalNo,
                                               Gender, BirthDate, Email,
                                               Address, PhoneNumber, PersonalImagePath);
            return PersonID.HasValue;
        }

        private bool UpdatePerson()
        {
            return PersonData.UpdatePersonInfo(PersonID, FirstName, LastName,
                                               NationalNo, Gender, BirthDate,
                                               Email, Address, PhoneNumber, PersonalImagePath);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (AddNewPerson())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
                    return UpdatePerson();

            }
            return false;
        }

        public static bool DeletePerson(int? personID)
        {
            return PersonData.DeletePerson(personID);
        }

        public static DataTable GetAllPeople()
        {
            return PersonData.GetAllPeople();
        }

    }
}