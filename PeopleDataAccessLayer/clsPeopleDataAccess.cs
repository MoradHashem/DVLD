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

            string Query = @"INSERT INTO People(FirstName, SecondName, ThirdName, LastName,
                                NationalNo, DateOfBirth, Gendor, Phone, Email,
                                NationalityCountryID, Address, ImagePath)
                            VALUES
                            (@FirstName, @SecondName, @ThirdName, @LastName, @NationalNo, @DateOfBirth,
                                    @Gendor, @Phone, @Email, @NationalityCountryID, @Address, @ImagePath);
                            SELECT SCOPE_IDENTITY();";


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
            Command.Parameters.AddWithValue("@NationalityCountryID", Country);
            Command.Parameters.AddWithValue("@Address", Address);

            if( ImagePath != "" )
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
                                 NationalityCountryID = @Country,
                                 Address = @Address,
                                 ImagePath = @ImagePath
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
                                            ref int Country, ref string Address, ref string ImagePath)
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
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    NationalNo = (string)Reader["NationalNo"];
                    Country = Convert.ToInt32(Reader["NationalityCountryID"]);
                    Gendor = (byte)Reader["Gendor"];
                    Phone = (string)Reader["Phone"];
                    Email = Reader["Email"] == DBNull.Value ? "" : (string)Reader["Email"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Address = (string)Reader["Address"];
                    ImagePath = Reader["ImagePath"] == DBNull.Value ? "" : (string)Reader["ImagePath"];


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

        //public static DataTable GetPeopleByPersonID(int PersonID)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.PersonID = @PersonID";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@PersonID", PersonID);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);

                
        //    }
        //    catch 
        //    {
                
        //    }
        //    finally
        //    {
        //        Connection.Close();
                
        //    }

        //    return dtPerson;
        //}


        public static bool GetPersonInfoByFirstName(ref int PersonID, string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE FirstName = @FirstName";

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



        //public static DataTable GetPeopleByFirstName(string FirstName)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.FirstName LIKE @FirstName + '%'";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@FirstName", FirstName);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}


        public static bool GetPersonInfoBySecondName(ref int PersonID, ref string FirstName, string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)

        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE SecondName = @SecondName";

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



        //public static DataTable GetPeopleBySecondName(string SecondName)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.SecondName LIKE @SecondName + '%'";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@SecondName", SecondName);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}



        public static bool GetPersonInfoByThirdName(ref int PersonID, ref string FirstName, ref string SecondName, string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE ThirdName = @ThirdName";

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


       
        //public static DataTable GetPeopleByThirdName(string ThirdName)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.ThirdName LIKE @ThirdName + '%'";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@ThirdName", ThirdName);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}


        public static bool GetPersonInfoByLastName(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE LastName = @LastName";

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


        //public static DataTable GetPeopleByLastName(string LastName)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.LastName LIKE @LastName + '%'";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@LastName", LastName);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}



        public static bool GetPersonInfoByNationalNo(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
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

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    Country = (int)Reader["NationalityCountryID"];
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



        //public static DataTable GetPeopleByNationalNo(string NationalNo)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.NationalNo LIKE @NationalNo + '%'";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@NationalNo", NationalNo);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}


        public static bool GetPersonInfoByGendor(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, byte Gendor, ref string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE Gendor = @Gendor";

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
                    Country = (int)Reader["NationalityCountryID"];
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



        //public static DataTable GetPeopleByGendor(byte Gendor)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.Gendor = @Gendor";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@Gendor", Gendor);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}



        public static bool GetPersonInfoByPhone(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, string Phone, ref string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE Phone = @Phone";

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

      
        //public static DataTable GetPeopleByPhone(string Phone)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.Phone LIKE @Phone + '%'";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@Phone", Phone);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}


        public static bool GetPersonInfoByEmail(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, string Email,
                                    ref int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE Email = @Email";

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
                    Country = (int)Reader["NationalityCountryID"];
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


        //public static DataTable GetPeopleByEmail(string Email)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.Email LIKE @Email + '%'";

        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@Email", Email);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}



        public static bool GetPersonInfoByCountry(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor, ref string Phone, ref string Email,
                                    int Country)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE Country = @Country";

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


        //public static DataTable GetPeopleByNationality(int NationalityCountryID)
        //{
        //    DataTable dtPerson = new DataTable();

        //    SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string Query = @"
        //        SELECT
        //            People.PersonID,
        //            People.NationalNo,
        //            People.FirstName,
        //            People.SecondName,
        //            People.ThirdName,
        //            People.LastName,

        //            CASE
        //                WHEN People.Gendor = 0 THEN 'Male'
        //                WHEN People.Gendor = 1 THEN 'Female'
        //            END AS Gendor,

        //            People.DateOfBirth,

        //            Countries.CountryName AS Nationality,

        //            People.Address,
        //            People.Phone,
        //            People.Email

        //        FROM People

        //        INNER JOIN Countries
        //            ON People.NationalityCountryID = Countries.CountryID

        //        WHERE People.NationalityCountryID = @NationalityCountryID";


        //    SqlCommand Command = new SqlCommand(Query, Connection);

        //    Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

        //    try
        //    {
        //        Connection.Open();

        //        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

        //        Adapter.Fill(dtPerson);
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return dtPerson;
        //}



        public static DataTable ListPeople()
        {
            DataTable dtPeople = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People";

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
