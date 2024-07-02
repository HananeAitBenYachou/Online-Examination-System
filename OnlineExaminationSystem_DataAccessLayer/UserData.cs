using OnlineExaminationSystem_DataAccessLayer.Global;
using OnlineExaminationSystem_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace OnlineExamination_DataAccessLayer
{
    public class UserData
    {
        public static bool GetUserInfoByID(int? userID, ref int personID, ref string username, ref string password, ref byte userRule, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_GetUserInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                personID = (int)reader["PersonID"];

                                username = (string)reader["Username"];

                                password = (string)reader["Password"];

                                userRule = (byte)reader["UserRule"];

                                isActive = (bool)reader["IsActive"];

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

        public static bool GetUserInfoByPersonIDAndRule(int? personID, byte userRule , ref int? userID, ref string username, ref string password, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_GetUserInfoByPersonIDAndRule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UserRule", userRule);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;

                                username = (string)reader["Username"];

                                password = (string)reader["Password"];

                                isActive = (bool)reader["IsActive"];
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

        public static bool DoesUserExist(int? userID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_CheckIfUserExistsByUserID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);

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

        public static bool DoesUserExist(string username)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_CheckIfUserExistsByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", username);

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

        public static bool DoesUserExist(int? personID , byte userRule)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_CheckIfUserExistsByPersonIDAndRule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UserRule", userRule);

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

        public static int? AddNewUser(int personID, string username, string password, byte userRule, bool isActive)
        {
            int? userID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@UserRule", userRule);
                        command.Parameters.AddWithValue("@IsActive", isActive);


                        SqlParameter outputUserIDParameter = new SqlParameter("@NewUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputUserIDParameter);

                        command.ExecuteNonQuery();

                        userID = (int)outputUserIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                userID = null;
            }
            return userID;
        }

        public static bool UpdateUserInfo(int? userID, int personID, string username, string password, byte userRule, bool isActive)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_UpdateUserInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@UserRule", userRule);
                        command.Parameters.AddWithValue("@IsActive", isActive);


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

        public static bool DeactivateUser(int? userID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_DeactivateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);

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

        public static bool ActivateUser(int? userID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_ActivateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);

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

        public static DataTable GetAllUsers()
        {
            DataTable users = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Users_GetAllUsers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                users.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return users;
        }
    }
}