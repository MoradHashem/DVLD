using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsPeopleDataAccess
    {   
        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
                                       DateTime DateOfBirth, byte Gendor, string Phone, string Email, int NationalityCountryID,
                                       string Address, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO People(FirstName, SecondName, ThirdName, LastName,
                                                NationalNo, DateOfBirth, Gendor, Phone, Email,
                                                NationalityCountryID, Address, ImagePath)
                            VALUES(@FirstName, @SecondName, @ThirdName, @LastName, @NationalNo, @DateOfBirth,
                                    @Gendor, @Phone, @Email, @NationalityCountryID, @Address, @ImagePath);
                            SELECT SCOPE_IDENTITY();";


            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != null && ThirdName != "")
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                Command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Phone", Phone); 
            
            if (Email != null && Email != "")
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            Command.Parameters.AddWithValue("@Address", Address);

            if(ImagePath != null && ImagePath != "")
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int personID))
                {
                    PersonID = personID;
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Connection.Close();
            }



            return PersonID;
        }



        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
                                       DateTime DateOfBirth, byte Gendor, string Phone, string Email, int NationalityCountryID,
                                       string Address, string ImagePath)
        {
            int RowsAffectived = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE People 
                             SET FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName,
                                 LastName = @LastName,
                                 NationalNo = @NationalNo,
                                 DateOfBirth = @DateOfBirth,
                                 Gendor = @Gendor,
                                 Phone = @Phone,
                                 Email = @Email,
                                 NationalityCountryID = @NationalityCountryID,
                                 Address = @Address,
                                 ImagePath = @ImagePath
                             WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != null && ThirdName != "")
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                Command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != null && Email != "")
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            Command.Parameters.AddWithValue("@Address", Address);

            if (ImagePath != null && ImagePath != "")
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }



            try
            {
                Connection.Open();

                RowsAffectived = Command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }


            return (RowsAffectived > 0);

        }



        public static bool GetPersonInfoByPersonID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                            ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                            ref int NationalityCountryID, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];

                    if (Reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)Reader["ThirdName"];
                    else
                        ThirdName = "";

                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];

                    if (Reader["Email"] != DBNull.Value)
                        Email = (string)Reader["Email"];
                    else
                        Email = "";

                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Address = (string)Reader["Address"];

                    if (Reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)Reader["ImagePath"];
                    else
                        ImagePath = "";


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


        public static bool GetPersonInfoByNationalNo(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int NationalityCountryID, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];

                    if (Reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)Reader["ThirdName"];
                    else
                        ThirdName = "";

                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];

                    if (Reader["Email"] != DBNull.Value)
                        Email = (string)Reader["Email"];
                    else
                        Email = "";

                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Address = (string)Reader["Address"];

                    if (Reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)Reader["ImagePath"];
                    else
                        ImagePath = "";


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
        
        
        
        public static DataTable ListPeople()
        {
            DataTable dtPeople = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT 
                                People.PersonID,
                                People.NationalNo,
                                People.FirstName,
                                People.SecondName,
                                People.ThirdName,
                                People.LastName,
                                People.DateOfBirth,
                                People.Gendor,

                                CASE
                                    WHEN People.Gendor = 0 THEN 'Male'
                                    ELSE 'Female'
                                END AS GendorCaption,

                                People.Address,
                                People.Phone,
                                People.Email,
                                People.NationalityCountryID,
                                Countries.CountryName,
                                People.ImagePath

                            FROM People
                            INNER JOIN Countries
                                ON People.NationalityCountryID = Countries.CountryID

                            ORDER BY People.FirstName; ";

            SqlCommand Command = new SqlCommand(Query, Connection);



            try
            {
                Connection.Open();


                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.HasRows)
                {
                    dtPeople.Load(Reader);
                }

            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }





            return dtPeople;
        }
        
        
        public static bool DeletePerson(int PersonID)
        {
            int RowsAffectived = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "DELETE FROM People Where PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                Connection.Open();

                RowsAffectived = Command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }


            return (RowsAffectived > 0);

        }



        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                IsFound = Reader.HasRows;

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


        public static bool IsPersonExist(string NationalNo)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                IsFound = Reader.HasRows;

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



    }
}
