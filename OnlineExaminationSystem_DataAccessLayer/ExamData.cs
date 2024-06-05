using OnlineExaminationSystem_DataAccessLayer.Global;
using OnlineExaminationSystem_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace OnlineExaminationSystem_DataAccessLayer
{
    public class ExamData
    {
        public static bool GetExamInfoByID(int? examID, ref int courseID, ref byte duration, ref DateTime examinationDate, ref byte numOfTrueFalseQuestions, ref byte numOfMCQQuestions, ref bool isMarkedForDelete)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Exams_GetExamInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ExamID", (object)examID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                courseID = (int)reader["CourseID"];

                                duration = (byte)reader["Duration"];

                                examinationDate = (DateTime)reader["ExaminationDate"];

                                numOfTrueFalseQuestions = (byte)reader["NumOfTrueFalseQuestions"];

                                numOfMCQQuestions = (byte)reader["NumOfMCQQuestions"];

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

        public static bool DoesExamExist(int? examID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Exams_CheckIfExamExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ExamID", (object)examID ?? DBNull.Value);

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

        public static int? AddNewExam(int courseID, byte duration, DateTime examinationDate, byte numOfTrueFalseQuestions, byte numOfMCQQuestions, bool isMarkedForDelete)
        {
            int? examID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Exams_AddNewExam", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@Duration", duration);
                        command.Parameters.AddWithValue("@ExaminationDate", examinationDate);
                        command.Parameters.AddWithValue("@NumOfTrueFalseQuestions", numOfTrueFalseQuestions);
                        command.Parameters.AddWithValue("@NumOfMCQQuestions", numOfMCQQuestions);
                        command.Parameters.AddWithValue("@IsMarkedForDelete", isMarkedForDelete);


                        SqlParameter outputExamIDParameter = new SqlParameter("@NewExamID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputExamIDParameter);

                        command.ExecuteNonQuery();

                        examID = (int)outputExamIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                examID = null;
            }
            return examID;
        }

        public static bool UpdateExamInfo(int? examID, int courseID, byte duration, DateTime examinationDate, byte numOfTrueFalseQuestions, byte numOfMCQQuestions, bool isMarkedForDelete , bool areExamQuestionsRegenerated)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Exams_UpdateExamInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ExamID", examID);
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@Duration", duration);
                        command.Parameters.AddWithValue("@ExaminationDate", examinationDate);
                        command.Parameters.AddWithValue("@NumOfTrueFalseQuestions", numOfTrueFalseQuestions);
                        command.Parameters.AddWithValue("@NumOfMCQQuestions", numOfMCQQuestions);
                        command.Parameters.AddWithValue("@IsMarkedForDelete", isMarkedForDelete);
                        command.Parameters.AddWithValue("@AreExamQuestionsGenerated", areExamQuestionsRegenerated);

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

        public static bool DeleteExam(int? examID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Exams_DeleteExam", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ExamID", (object)examID ?? DBNull.Value);

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

        public static DataTable GetAllExams()
        {
            DataTable exams = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Exams_GetAllExams", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                exams.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return exams;
        }

    }


}
