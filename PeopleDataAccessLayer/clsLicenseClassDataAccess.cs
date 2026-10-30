using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsLicenseClassDataAccess
    {

        public static bool GetLicenseClassInfoByClassName(ref int LicenseClassID, string ClassName, ref string ClassDescription,
                                                          ref short MinimumAllowedAge, ref short DefaultValidityLength, ref double ClassFees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from LicenseClasses WHERE ClassName = @ClassName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ClassName", ClassName);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    LicenseClassID = (int)Reader["LicenseClassID"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToInt16(Reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToInt16(Reader["MinimumAllowedAge"]);
                    ClassFees = Convert.ToDouble(Reader["ClassFees"]);

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



        public static bool GetLicenseClassInfoByID(int LicenseClassID, ref string ClassName, ref string ClassDescription,
                                                          ref short MinimumAllowedAge, ref short DefaultValidityLength, ref double ClassFees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    LicenseClassID = (int)Reader["LicenseClassID"];
                    ClassName = (string)Reader["ClassName"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToInt16(Reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToInt16(Reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToDouble(Reader["ClassFees"]);

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


        public static DataTable ListAllLicenseClass()
        {
            DataTable dtLicenseClass = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM LicenseClasses;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtLicenseClass.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return dtLicenseClass;
        }
    }
}
