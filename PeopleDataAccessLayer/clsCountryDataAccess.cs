using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsCountryDataAccess
    {

        public static bool GetCountryInfoByCountryID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@CountryID", CountryID);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    CountryName = (string)Reader["CountryName"];
                }
                else
                {
                    IsFound = false;
                }



                Reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }





            return IsFound;
        }



        public static bool GetCountryInfoByCountryName(ref int CountryID, string CountryName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@CountryName", CountryName);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    CountryID = (int)Reader["CountryID"];

                }
                else
                {
                    IsFound = false;
                }



                Reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }





            return IsFound;
        }





        public static DataTable ListCountries()
        {
            DataTable dtCountries = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Countries";

            SqlCommand Command = new SqlCommand(Query, Connection);



            try
            {
                Connection.Open();


                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtCountries.Load(Reader);
                }

            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }





            return dtCountries;
        }

    }
}
