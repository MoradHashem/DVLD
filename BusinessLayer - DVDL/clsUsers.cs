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
        public int UserID { set; private get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public Byte IsActive { set; get; }


        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = 0;

            Mode = _enMode.AddNew;
        }


        public clsUsers(int UserID, int PersonID, string UserName, string Password, byte IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = _enMode.Update;
        }



        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);


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
                    {
                        if (_UpdateUserInfo())

                            return true;
                    }
                    break;

            }

            return false;

        }


        public static bool DeleteUser(int UserID)
        {

            return (clsUserDataAccess.DeleteUser(UserID));


        }


        public static clsUsers FindUserByID(int UserID)
        {
            string UserName = "", Password = "";
            byte IsActive = 0;
            int PersonID = -1;


            if (clsUserDataAccess.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password,ref IsActive))
                                           

                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);


            else

                return null;

        }



        public static DataTable ListUsers()
        {

            DataTable dtUsers = clsUserDataAccess.ListUsers();

            DataTable dtNew = new DataTable();


            dtNew.Columns.Add("User ID", typeof(int));
            dtNew.Columns.Add("Person ID", typeof(int));
            dtNew.Columns.Add("Full Name");
            dtNew.Columns.Add("User Name");
            dtNew.Columns.Add("Is Active", typeof(bool));


            foreach (DataRow Row in dtUsers.Rows)
            {
                DataRow NewRow = dtNew.NewRow();

                NewRow["User ID"] = Row["UserID"];
                NewRow["Person ID"] = Row["PersonID"];
                NewRow["Full Name"] = Row["FirstName"] + " " + Row["SecondName"] + " " + Row["ThirdName"] + " " + Row["LastName"];
                NewRow["User Name"] = Row["UserName"];
                NewRow["Is Active"] = Convert.ToBoolean(Row["IsActive"]);


                dtNew.Rows.Add(NewRow);

            }





            return dtNew;
        }



    }
}
