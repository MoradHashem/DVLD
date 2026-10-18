using System;
using System.Data;
using System.IO;
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
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string NationalNo { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gendor { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string Address { set; get; }
        public string ImagePath 
        {
            set { _ImagePath = value; }
            get { return _ImagePath; }
        }

        public clsCountry CountryInfo;

        private string _ImagePath;




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
            this.NationalityCountryID = -1;
            this.Address = "";
            this.ImagePath = "";

            this.Mode = _enMode.AddNew;
        }



        private clsPeople(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
                         DateTime DateOfBirth, byte Gendor, string Phone, string Email, int NationalityCountryID, string Address, string ImagePath)
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
            this.NationalityCountryID = NationalityCountryID;
            this.Address = Address;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);

            Mode = _enMode.Update;
        }





        private bool _AddNewPerson()
        {
             this.PersonID = clsPeopleDataAccess.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo,
                                                              this.DateOfBirth, this.Gendor, this.Phone, this.Email, this.NationalityCountryID, this.Address,
                                                              this.ImagePath);

            return (PersonID != -1);
        }



        private bool _UpdateInfo()
        {
            return (clsPeopleDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, 
                                                      this.NationalNo, this.DateOfBirth, this.Gendor, this.Phone, this.Email, this.NationalityCountryID,
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

            clsPeople Person = clsPeople.Find(PersonID);

            if (Person == null)
                return false;

            string ImagePath = Person.ImagePath;

            if (clsPeopleDataAccess.DeletePerson(PersonID))
            {
                if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
                {
                    try
                    {
                        File.Delete(ImagePath);
                    }
                    catch (IOException ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }
                }

                return true;
            }

            return false;



        }



        public static clsPeople Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Phone = "",
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int NationalityCountryID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByPersonID(PersonID, ref FirstName, ref SecondName, ref ThirdName,
                                           ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                            ref NationalityCountryID, ref Address, ref ImagePath))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, NationalityCountryID, Address, ImagePath);


            else

                return null;

        }



        public static clsPeople Find(string NationalNo)
        {
            string SecondName = "", FirstName = "", LastName = "", ThirdName = "", Phone = "",
                   Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int Country = -1, PersonID = -1;


            if (clsPeopleDataAccess.GetPersonInfoByNationalNo(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                                           ref LastName,  NationalNo, ref DateOfBirth, ref Gendor, ref Phone, ref Email,
                                            ref Country, ref Address, ref ImagePath))

                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                                 DateOfBirth, Gendor, Phone, Email, Country, Address, ImagePath);


            else

                return null;

        }


        public static DataTable ListPeople()
        {
            
            return clsPeopleDataAccess.ListPeople();
        }


        public static bool IsPersonExist(string NationalNo)
        {
            return clsPeopleDataAccess.IsPersonExist(NationalNo);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPeopleDataAccess.IsPersonExist(PersonID);
        }

    }
}
