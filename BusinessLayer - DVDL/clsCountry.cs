using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsCountry
    {


        public int CountryID { get; private set; }
        public string CountryName { set; get; }




        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }


        public static clsCountry FindCountryByID(int CountryID)
        {
            string CountryName = "";

            if (clsCountryDataAccess.GetCountryInfoByCountryID(CountryID, ref CountryName))

                return new clsCountry(CountryID, CountryName);


            else

                return null;

        }



        public static clsCountry FindCountryByCountryName(string CountryName)
        {
           
            int CountryID = -1;


            if (clsCountryDataAccess.GetCountryInfoByCountryName(ref CountryID, CountryName))

                return new clsCountry(CountryID, CountryName);


            else

                return null;

        }



        public static DataTable ListCountries()
        {
            return (clsCountryDataAccess.ListCountries());
        }


    }
}
