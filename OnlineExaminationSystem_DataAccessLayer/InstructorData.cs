using System;
using OnlineExaminationSystem_DataAccessLayer.Global;
using OnlineExaminationSystem_UtilityLayer;
using System.Data;
using System.Data.SqlClient;

namespace OnlineExamination_DataAccessLayer
{
    public class InstructorData
    {
        public static bool GetInstructorInfoByInstructorID(int? instructorID, ref int personID, ref DateTime hireDate,
                                                 ref DateTime? exitDate, ref float monthlySalary,
                                                 ref bool isMarkedForDelete)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Instructors_GetInstructorInfoByInstructorID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorID", (object)instructorID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                personID = (int)reader["PersonID"];

                                hireDate = (DateTime)reader["HireDate"];

                                exitDate = (reader["ExitDate"] != DBNull.Value) ? (DateTime?)reader["ExitDate"] : null;

                                monthlySalary = Convert.ToSingle(reader["MonthlySalary"]);

                                isMarkedForDelete = (bool)reader["IsMarkedForDelete"];

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

        public static bool GetInstructorInfoByPersonID(int personID , ref int? instructorID, ref DateTime hireDate,
                                         ref DateTime? exitDate, ref float monthlySalary,
                                         ref bool isMarkedForDelete)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Instructors_GetInstructorInfoByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                instructorID = (reader["InstructorID"] != DBNull.Value) ? (int?)reader["InstructorID"] : null;

                                hireDate = (DateTime)reader["HireDate"];

                                exitDate = (reader["ExitDate"] != DBNull.Value) ? (DateTime?)reader["ExitDate"] : null;

                                monthlySalary = Convert.ToSingle(reader["MonthlySalary"]);

                                isMarkedForDelete = (bool)reader["IsMarkedForDelete"];

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

        public static bool DoesInstructorExistByInstructorID(int? instructorID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Instructors_CheckIfInstructorExistsByInstructorID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorID", (object)instructorID ?? DBNull.Value);

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

        public static bool DoesInstructorExistByPersonID(int personID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Instructors_CheckIfInstructorExistsByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID",personID);

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

        public static int? AddNewInstructor(int personID, DateTime hireDate, DateTime? exitDate,
                                            float monthlySalary, bool isMarkedForDelete)
        {
            int? instructorID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Instructors_AddNewInstructor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@HireDate", hireDate);
                        command.Parameters.AddWithValue("@ExitDate", (object)exitDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MonthlySalary", monthlySalary);
                        command.Parameters.AddWithValue("@IsMarkedForDelete", isMarkedForDelete);


                        SqlParameter outputInstructorIDParameter = new SqlParameter("@NewInstructorID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputInstructorIDParameter);

                        command.ExecuteNonQuery();

                        instructorID = (int)outputInstructorIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                instructorID = null;
            }
            return instructorID;
        }

        public static bool UpdateInstructorInfo(int? instructorID, int personID, DateTime hireDate, 
                                                DateTime? exitDate, float monthlySalary, bool isMarkedForDelete)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Instructors_UpdateInstructorInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@InstructorID", instructorID);
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@HireDate", hireDate);
                        command.Parameters.AddWithValue("@ExitDate", (object)exitDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MonthlySalary", monthlySalary);
                        command.Parameters.AddWithValue("@IsMarkedForDelete", isMarkedForDelete);


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

        public static bool DeleteInstructor(int? instructorID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Instructors_DeleteInstructor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorID", (object)instructorID ?? DBNull.Value);

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

        public static DataTable GetAllInstructors()
        {
            DataTable instructors = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Instructors_GetAllInstructors", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                instructors.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return instructors;
        }

    }
}