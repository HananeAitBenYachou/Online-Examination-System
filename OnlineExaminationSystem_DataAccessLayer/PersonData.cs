using OnlineExaminationSystem_DataAccessLayer.Global;
using OnlineExaminationSystem_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace OnlineExamination_DataAccessLayer
{
    public class PersonData
    {
        public static bool GetPersonInfoByID(int? personID, ref string firstName, ref string lastName,
                                             ref string nationalNo, ref char gender, ref DateTime birthDate,
                                             ref string email, ref string address, ref string phoneNumber,
                                             ref string personalImagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_GetPersonInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                firstName = (string)reader["FirstName"];

                                lastName = (string)reader["LastName"];

                                nationalNo = (string)reader["NationalNo"];

                                gender = ((string)reader["Gender"])[0];

                                birthDate = (DateTime)reader["BirthDate"];

                                email = (string)reader["Email"];

                                address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;

                                phoneNumber = (reader["PhoneNumber"] != DBNull.Value) ? (string)reader["PhoneNumber"] : null;

                                personalImagePath = (reader["PersonalImagePath"] != DBNull.Value) ? (string)reader["PersonalImagePath"] : null;

                            }

                            else
                            {
                                // The record wasn't found !
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static bool GetPersonInfoByNationalNo(string nationalNo, ref int? personID, ref string firstName,
                                                     ref string lastName, ref char gender, ref DateTime birthDate,
                                                     ref string email, ref string address, ref string phoneNumber,
                                                     ref string personalImagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_GetPersonInfoByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNo",nationalNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;

                                firstName = (string)reader["FirstName"];

                                lastName = (string)reader["LastName"];

                                gender = ((string)reader["Gender"])[0];

                                birthDate = (DateTime)reader["BirthDate"];

                                email = (string)reader["Email"];

                                address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;

                                phoneNumber = (reader["PhoneNumber"] != DBNull.Value) ? (string)reader["PhoneNumber"] : null;

                                personalImagePath = (reader["PersonalImagePath"] != DBNull.Value) ? (string)reader["PersonalImagePath"] : null;

                            }

                            else
                            {
                                // The record wasn't found !
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static bool DoesPersonExistByID(int? personID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_CheckIfPersonExistsByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        isFound = (int)returnValue.Value == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static bool DoesPersonExistByEmail(string email)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_CheckIfPersonExistsByEmail", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Email",email);

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        isFound = (int)returnValue.Value == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static bool DoesPersonExistByNationalNo(string nationalNo)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_CheckIfPersonExistsByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNo", nationalNo);

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        isFound = (int)returnValue.Value == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static int? AddNewPerson(string firstName, string lastName, string nationalNo,
                                        char gender, DateTime birthDate, string email,
                                        string address, string phoneNumber, string personalImagePath)
        {
            int? personID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_AddNewPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@NationalNo", nationalNo);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", (object)address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", (object)phoneNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PersonalImagePath", (object)personalImagePath ?? DBNull.Value);


                        SqlParameter outputPersonIDParameter = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputPersonIDParameter);

                        command.ExecuteNonQuery();

                        personID = (int)outputPersonIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                personID = null;
            }
            return personID;
        }

        public static bool UpdatePersonInfo(int? personID, string firstName, string lastName, 
                                            string nationalNo, char gender, DateTime birthDate, 
                                            string email, string address, string phoneNumber, string personalImagePath)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_UpdatePersonInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@NationalNo", nationalNo);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", (object)address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", (object)phoneNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PersonalImagePath", (object)personalImagePath ?? DBNull.Value);


                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                rowsAffected = 0;
            }
            return rowsAffected != 0;
        }

        public static bool DeletePerson(int? personID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_DeletePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return rowsAffected != 0;
        }

        public static DataTable GetAllPeople()
        {
            DataTable people = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_People_GetAllPeople", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                people.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return people;
        }

    }
}