using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsApplicationTypesDataAccess
    {
        public static DataTable GetAllApplicationTpyes()
        {
            DataTable dtAllApplicationType = new DataTable();


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM ApplicationTypes order by ApplicationTypeTitle";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtAllApplicationType.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return dtAllApplicationType;
        }


        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, double ApplicationFees)
        {
            int RowsAffectived = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update ApplicationTypes
                                SET ApplicationTypeTitle = @ApplicationTypeTitle,
                                    ApplicationFees = @ApplicationFees
                                WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand Command = new SqlCommand(Query,Connection);

            Command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();

                RowsAffectived = Command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return (RowsAffectived > 0);
        }


        public static bool GetApplicationTpyesInfoByID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref double ApplicationFees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(Query,Connection);
            
            
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

           try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToDouble(Reader["ApplicationFees"]);
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
