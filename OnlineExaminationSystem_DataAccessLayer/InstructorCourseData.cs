using System;
using System.Data.SqlClient;
using System.Data;
using OnlineExaminationSystem_UtilityLayer;
using OnlineExaminationSystem_DataAccessLayer.Global;
using System.Collections.Generic;

namespace OnlineExaminationSystem_DataAccessLayer
{
    public class InstructorCourseData
    {
        public static bool GetInstructorCourseInfoByID(int? instructorCourseID, ref int instructorID, ref int courseID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_InstructorCourses_GetInstructorCourseInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorCourseID", (object)instructorCourseID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                instructorID = (int)reader["InstructorID"];

                                courseID = (int)reader["CourseID"];

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

        public static bool DoesInstructorCourseExist(int? instructorCourseID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_InstructorCourses_CheckIfInstructorCourseExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorCourseID", (object)instructorCourseID ?? DBNull.Value);

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

        public static int? AddNewInstructorCourse(int instructorID, int courseID)
        {
            int? instructorCourseID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_InstructorCourses_AddNewInstructorCourse", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@InstructorID", instructorID);
                        command.Parameters.AddWithValue("@CourseID", courseID);


                        SqlParameter outputInstructorCourseIDParameter = new SqlParameter("@NewInstructorCourseID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputInstructorCourseIDParameter);

                        command.ExecuteNonQuery();

                        instructorCourseID = (int)outputInstructorCourseIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                instructorCourseID = null;
            }
            return instructorCourseID;
        }

        public static bool DeleteInstructorCourse(int? instructorCourseID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_InstructorCourses_DeleteInstructorCourse", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorCourseID", (object)instructorCourseID ?? DBNull.Value);

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

        public static DataTable GetAllInstructorCourses(int? instructorID)
        {
            DataTable instructorCourses = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_InstructorCourses_GetAllInstructorCourses", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorID", (object)instructorID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                instructorCourses.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return instructorCourses;
        }

        public static Dictionary<string, int> GetAvailableCoursesForInstructor(int? instructorID)
        {
            Dictionary<string, int> courses = new Dictionary<string, int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_InstructorCourses_GetAvailableCoursesForInstructor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorID", (object)instructorID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                courses.Add((string)reader["Name"], (int)reader["Course ID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return courses;
        }

    }

}
