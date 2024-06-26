using OnlineExamination_DataAccessLayer;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class User
    {
        private enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;

        public enum Role { Admin = 0 , Instructor = 1 , Student = 3};
        public int? UserID { get; private set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role UserRule { get; set; }
        public bool IsActive { get; set; }

        public User()
        {
            _mode = Mode.AddNew;
            UserID = null;
            PersonID = default;
            Username = default;
            Password = default;
            UserRule = default;
            IsActive = default;
        }
        private User(int? userID, int personID, string username, string password, Role userRule, bool isActive)
        {
            _mode = Mode.Update;
            this.UserID = userID;
            this.PersonID = personID;
            this.Username = username;
            this.Password = password;
            this.UserRule = userRule;
            this.IsActive = isActive;
        }

        public static User Find(int? userID)
        {
            int personID = default;
            string username = default;
            string password = default;
            byte userRule = default;
            bool isActive = default;

            bool isFound = UserData.GetUserInfoByID(userID, ref personID, ref username, ref password, ref userRule, ref isActive);

            if (isFound)
                return new User(userID, personID, username, password, (Role)userRule, isActive);
            else
                return null;
        }

        public static User Find(int? personID, Role userRule)
        {
            int? userID = default;
            string username = default;
            string password = default;
            bool isActive = default;

            bool isFound = UserData.GetUserInfoByPersonIDAndRule(personID , (byte)userRule, ref userID, ref username, ref password, ref isActive);

            if (isFound)
                return new User(userID, personID.Value, username, password, userRule, isActive);
            else
                return null;
        }

        public static bool DoesUserExist(int? userID)
        {
            return UserData.DoesUserExist(userID);
        }

        public static bool DoesUserExist(string username)
        {
            return UserData.DoesUserExist(username);
        }

        public static bool DoesUserExist(int? personID , Role userRule)
        {
            return UserData.DoesUserExist(personID , (byte)userRule);
        }

        private bool AddNewUser()
        {
            UserID = UserData.AddNewUser(PersonID, Username, Password, (byte)UserRule, IsActive);
            return UserID.HasValue;
        }

        private bool UpdateUser()
        {
            return UserData.UpdateUserInfo(UserID, PersonID, Username, Password, (byte)UserRule, IsActive);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (AddNewUser())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
                    return UpdateUser();

            }
            return false;
        }

        public static bool DeleteUser(int? userID)
        {
            return UserData.DeleteUser(userID);
        }

        public static bool DeactivateUser(int? userID)
        {
            return DeleteUser(userID);
        }

        public static bool ActivateUser(int? userID)
        {
            return UserData.ActivateUser(userID);
        }

        public static DataTable GetAllUsers()
        {
            return UserData.GetAllUsers();
        }

    }
}