using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsPeople
    {

        public enum _enMode { AddNew = 0, Update = 1 };
        public _enMode Mode = _enMode.AddNew;



        public int PersonID { get; private set; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string NationalNo { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gendor { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int Country { set; get; }
        public string Address { set; get; }
        public string ImagePath { set; get; }




        public clsPeople()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.NationalNo = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Phone = "";
            this.Email = "";
            this.Country = -1;
            this.Address = "";
            this.ImagePath = "";

            this.Mode = _enMode.AddNew;
        }



        private clsPeople(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
                         DateTime DateOfBirth, byte Gendor, string Phone, string Email, int Country, string Address, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Phone = Phone;
            this.Email = Email;
            this.Country = Country;
            this.Address = Address;
            this.ImagePath = ImagePath;

            Mode = _enMode.Update;
        }





        private bool _AddNewPerson()
        {
             this.PersonID = clsPeopleDataAccess.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo,
                                                              this.DateOfBirth, this.Gendor, this.Phone, this.Email, this.Country, this.Address,
                                                              this.ImagePath);

            return (PersonID != -1);
        }



        private bool _UpdateInfo()
        {
            return (clsPeopleDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, 
                                                      this.NationalNo, this.DateOfBirth, this.Gendor, this.Phone, this.Email, this.Country,
                                                      this.Address, this.ImagePath));
        }



        public bool Save()
        {
            switch (this.Mode)
            {
                case _enMode.AddNew:
                    {
                        if (_AddNewPerson())
                        {
                            Mode = _enMode.Update;

                            return true;
                        }
                    }
                    break;

                case _enMode.Update:
                    {
                        if (_UpdateInfo())

                            return true;
                    }
                    break;

            }

            return false;

        }



        public static bool DeletePerson(int PersonID)
        {

            return (clsPeopleDataAccess.DeletePerson(PersonID));


        }



        public static clsPeople FindPersonByID(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Phone = "", 
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1;


            if (clsPeopleDataAccess.GetPersonInfoByPersonID(PersonID, ref FirstName, ref SecondName, ref ThirdName,
                                           ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                            ref Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);
                                            

            else

                return null;
                                      
        }



        public static clsPeople FindPersonByFirstName(string FirstName)
        {
            string SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Phone = "",
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1, PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByFirstName(ref PersonID,  FirstName, ref SecondName, ref ThirdName,
                                           ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                            ref Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }


        public static clsPeople FindPersonBySecondName(string SecondName)
        {
            string FirstName = "", ThirdName = "", LastName = "", NationalNo = "", Phone = "",
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1, PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoBySecondName(ref PersonID, ref FirstName, SecondName, ref ThirdName,
                                           ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                            ref Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }


        public static clsPeople FindPersonByThirdName(string ThirdName)
        {
            string SecondName = "", FirstName = "", LastName = "", NationalNo = "", Phone = "",
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1, PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByThirdName(ref PersonID, ref FirstName, ref SecondName, ThirdName,
                                           ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                            ref Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }



        public static clsPeople FindPersonByLastName(string LastName)
        {
            string SecondName = "", FirstName = "", ThirdName = "", NationalNo = "", Phone = "",
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1, PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByLastName(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                                           LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                            ref Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }



        public static clsPeople FindPersonByNationalNo(string NationalNo)
        {
            string SecondName = "", FirstName = "", LastName = "", ThirdName = "", Phone = "",
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1, PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByNationalNo(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                                           ref LastName,  NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                            ref Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }



        public static clsPeople FindPersonByPhone(string Phone)
        {
            string SecondName = "", FirstName = "", LastName = "", NationalNo = "", ThirdName = "",
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1, PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByPhone(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                                           ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor,  Phone, ref Email,
                                            ref Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }



        public static clsPeople FindPersonByEmail(string Email)
        {
            string SecondName = "", FirstName = "", LastName = "", NationalNo = "", Phone = "",
                   ThirdName = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1, PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByEmail(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                                           ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Phone,  Email,
                                            ref Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }



        public static clsPeople FindPersonByCountry(int Country)
        {
            string SecondName = "", FirstName = "", LastName = "", NationalNo = "", Phone = "",
                   Email = "", Address = "", ImagePath = "", ThirdName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByCountry(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                                           ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                             Country))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }




        public static DataTable ListPeople()
        {
            return (clsPeopleDataAccess.ListPeople());
        }



    }
}
