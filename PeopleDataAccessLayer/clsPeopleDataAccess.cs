using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsPeopleDataAccess
    {   
        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
                                       DateTime DateOfBirth, byte Gendor, string Phone, string Email, int Country,
                                       string Address, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO People(FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth
                                                Gendor, Phone, Email, NationalityCountryID, Address, ImagePath)
                             VALUES(@FirstName, @SecondName, @ThirdName, @LastName, @NationalNo, @DateOfBirth
                                    @Gendor, @Phone, @Email, @NationalityCountryID, @Address, @ImagePath)
                             SELECT SCOPE_IDENTITY()";


            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Country", Country);
            Command.Parameters.AddWithValue("@Address", Address);

            if( ImagePath != "" )
            {
                Command.Parameters.AddWithValue("@Imagepath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@Imagepath", System.DBNull.Value);
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
            catch
            {

            }
            finally
            {
                Connection.Close();
            }



            return PersonID;
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



        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
                                       DateTime DateOfBirth, byte Gendor, string Phone, string Email, int Country,
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
                                 Country = @Country,
                                 Address = @Address,
                                 ImagePath = @ImagePath,
                             WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Country", Country);
            Command.Parameters.AddWithValue("@Address", Address);

            if (ImagePath != "")
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
            catch
            {

            }
            finally
            {
                Connection.Close();
            }


            return (RowsAffectived > 0);

        }




        public static bool GetPersonInfoByPersonID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                            ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                            ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE PersonID = @PersonID";

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
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = (int)Reader["CountryName"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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




        public static bool GetPersonInfoByFirstName(ref int PersonID, string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE FirstName = @FirstName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = (int)Reader["CountryName"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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




        public static bool GetPersonInfoBySecondName(ref int PersonID, ref string FirstName, string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)

        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE SecondName = @SecondName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@SecondName", SecondName);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = (int)Reader["CountryName"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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




        public static bool GetPersonInfoByThirdName(ref int PersonID, ref string FirstName, ref string SecondName, string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE ThirdName = @ThirdName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ThirdName", ThirdName);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = (int)Reader["CountryName"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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



        public static bool GetPersonInfoByLastName(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE LastName = @LastName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LastName", LastName);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = (int)Reader["CountryName"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    Country = (int)Reader["CountryName"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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



        public static bool GetPersonInfoByGendor(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE Gendor = @Gendor";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Gendor", Gendor);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = (int)Reader["CountryName"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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



        public static bool GetPersonInfoByPhone(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE Phone = @Phone";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Phone", Phone);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = (int)Reader["CountryName"];
                    Gendor = (byte)Reader["Gendor"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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




        public static bool GetPersonInfoByEmail(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE Email = @Email";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Email", Email);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = (int)Reader["CountryName"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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





        public static bool GetPersonInfoByCountry(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM PersonInfo_View WHERE Country = @Country";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Country", Country);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];


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

            string Query = "SELECT * FROM PersonInfo_View";

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



    }
}
