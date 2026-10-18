using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsCountry
    {


        public int ID { set; get; }
        public string CountryName { set; get; }

        public clsCountry()

        {
            this.ID = -1;
            this.CountryName = "";

        }

        private clsCountry(int ID, string CountryName)

        {
            this.ID = ID;
            this.CountryName = CountryName;
        }

        public static clsCountry Find(int ID)
        {
            string CountryName = "";

            if (clsCountryDataAccess.GetCountryInfoByID(ID, ref CountryName))

                return new clsCountry(ID, CountryName);
            else
                return null;

        }

        public static clsCountry Find(string CountryName)
        {

            int ID = -1;

            if (clsCountryDataAccess.GetCountryInfoByName(ref ID, CountryName))

                return new clsCountry(ID, CountryName);
            else
                return null;

        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.ListCountries();

        }


    }
}
