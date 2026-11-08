using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsTestTypesDataAccess
    {

        public static DataTable GetAllTestTypes()
        {
            DataTable dtTestTypes = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM TestTypes order by TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.HasRows)
                    dtTestTypes.Load(Reader);

                Reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return dtTestTypes;
        }


        public static bool UpdateTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, double TestTypeFees)
        {
            int RowsAffectived = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update TestTypes
                                SET TestTypeTitle = @TestTypeTitle,
                                    TestTypeDescription = @TestTypeDescription,
                                    TestTypeFees = @TestTypeFees
                                WHERE TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query,Connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            Command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            Command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

            try
            {
                Connection.Open();

                RowsAffectived = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection?.Close();
            }


            return (RowsAffectived > 0);

        }


        public static bool GetTestTypesInfoByID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref double TestTypeFees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    TestTypeTitle = (string)Reader["TestTypeTitle"];
                    TestTypeDescription = (string)Reader["TestTypeDescription"];
                    TestTypeFees = Convert.ToDouble(Reader["TestTypeFees"]);
                }
                else
                    IsFound = false;

                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }


            return IsFound;
        }
    }
}
