using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;

namespace DVLDBusinessLayer
{
    public class clsUsers
    {

        public enum _enMode { AddNew = 0, Update = 1 };
        public _enMode Mode = _enMode.AddNew;



        public int PersonID { get; set; }
        public int UserID { private set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public clsPeople PersonInfo;


        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;

            Mode = _enMode.AddNew;
        }


        public clsUsers(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonInfo = clsPeople.Find(PersonID);

            Mode = _enMode.Update;
        }



        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);


            return (UserID != -1);
        }


        private bool _UpdateUserInfo()
        {
            return (clsUserDataAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive));
        }


        public bool Save()
        {
            switch (this.Mode)
            {
                case _enMode.AddNew:
                    {
                        if (_AddNewUser())
                        {
                            Mode = _enMode.Update;

                            return true;
                        }
                    }
                    break;

                case _enMode.Update:
                    

                    return _UpdateUserInfo();

                    break;

            }

            return false;

        }


        public static bool DeleteUser(int UserID)
        {

            return (clsUserDataAccess.DeleteUser(UserID));


        }


        public static clsUsers FindByUserID(int UserID)
        {
            string UserName = "", Password = "";
            bool IsActive = true;
            int PersonID = -1;


            if (clsUserDataAccess.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
                                           

                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);


            else

                return null;

        }


        public static clsUsers FindByPersonID(int PersonID)
        {
            string UserName = "", Password = "";
            bool IsActive = true;
            int UserID = -1;


            if (clsUserDataAccess.GetUserInfoByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive))


                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);


            else

                return null;

        }



        public static clsUsers FindByPasswordAndUserName(string Password, string UserName)
        {
            bool IsActive = true;
            int PersonID = -1, UserID = -1;


            if (clsUserDataAccess.GetUserInfoByPasswordAndUserName(ref UserID, ref PersonID, UserName, Password, ref IsActive))


                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);


            else

                return null;

        }




        public static DataTable ListUsers()
        {

            return clsUserDataAccess.ListUsers();
        }


        public static bool IsUserExist(int UserID)
        {
            return clsUserDataAccess.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserDataAccess.IsUserExist(UserName);
        }


        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserDataAccess.IsUserExistForPersonID(PersonID);
        }




    }
}
