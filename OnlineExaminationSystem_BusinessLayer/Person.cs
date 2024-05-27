using OnlineExamination_DataAccessLayer;
using System;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Person
    {
        private enum EnMode : byte
        { AddNew = 0, Update = 1 };
        public enum EnFilterBy : byte
        {
            PersonID, NationalNo, Email
        }
        public enum EnGender : byte
        {
            Male, Female
        }

        private EnMode _mode;
        public int? PersonID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public char Gender { get; set; }
        public EnGender GenderText => (Gender == 'M' ? EnGender.Male : EnGender.Female);
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonalImagePath { get; set; }

        public Person()
        {
            _mode = EnMode.AddNew;
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
        private Person(int? personID, string firstName, string lastName, string nationalNo, char gender, DateTime birthDate, string email, string address, string phoneNumber, string personalImagePath)
        {
            _mode = EnMode.Update;
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

        public static bool DoesPersonExist<T>(T filterValue, EnFilterBy filterBy)
        {
            if (filterValue == null)
                return false;

            switch (filterBy)
            {
                case EnFilterBy.PersonID:
                    return PersonData.DoesPersonExistByID(Convert.ToInt32(filterValue));

                case EnFilterBy.NationalNo:
                    return PersonData.DoesPersonExistByNationalNo(Convert.ToString(filterValue));

                case EnFilterBy.Email:
                    return PersonData.DoesPersonExistByEmail(Convert.ToString(filterValue));

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
                case EnMode.AddNew:
                    if (AddNewPerson())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
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