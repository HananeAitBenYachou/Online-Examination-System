using OnlineExamination_DataAccessLayer;
using System.Data;

namespace OnlineExamination_BusinessLayer
{
    public class Administrator
    {
        private enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public int? AdminID { get; private set; }
        public int PersonID { get; set; }

        public Administrator()
        {
            _mode = Mode.AddNew;
            AdminID = null;
            PersonID = default;
        }
        private Administrator(int? adminID, int personID)
        {
            _mode = Mode.Update;
            this.AdminID = adminID;
            this.PersonID = personID;
        }

        public static Administrator Find(int? adminID)
        {
            int personID = default;

            bool isFound = AdministratorData.GetAdministratorInfoByID(adminID, ref personID);

            if (isFound)
                return new Administrator(adminID, personID);
            else
                return null;
        }

        public static bool DoesAdministratorExist(int? adminID)
        {
            return AdministratorData.DoesAdministratorExist(adminID);
        }

        private bool AddNewAdministrator()
        {
            AdminID = AdministratorData.AddNewAdministrator(PersonID);
            return AdminID.HasValue;
        }

        private bool UpdateAdministrator()
        {
            return AdministratorData.UpdateAdministratorInfo(AdminID, PersonID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (AddNewAdministrator())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    return false;

                case Mode.Update:
                    return UpdateAdministrator();

            }
            return false;
        }

        public static bool DeleteAdministrator(int? adminID)
        {
            return AdministratorData.DeleteAdministrator(adminID);
        }

        public static DataTable GetAllAdministrators()
        {
            return AdministratorData.GetAllAdministrators();
        }

    }
}