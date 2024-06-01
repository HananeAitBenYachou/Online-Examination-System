using OnlineExaminationSystem_DataAccessLayer.Global;
using OnlineExaminationSystem_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace OnlineExaminationSystem_DataAccessLayer
{
    public class QuestionData
    {
        public static bool GetQuestionInfoByID(int? questionID, ref string questionText, ref byte questionType,
                                               ref int courseID, ref byte difficultyLevel, ref float mark,
                                               ref string modelAnswer, ref bool isMarkedForDelete)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Questions_GetQuestionInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@QuestionID", (object)questionID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                questionText = (string)reader["QuestionText"];

                                questionType = (byte)reader["QuestionType"];

                                courseID = (int)reader["CourseID"];

                                difficultyLevel = (byte)reader["DifficultyLevel"];

                                mark = Convert.ToSingle(reader["Mark"]);

                                modelAnswer = (string)reader["ModelAnswer"];

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

        public static bool DoesQuestionExist(int? questionID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Questions_CheckIfQuestionExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@QuestionID", (object)questionID ?? DBNull.Value);

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

        public static int? AddNewQuestion(string questionText, byte questionType, int courseID,
                                          byte difficultyLevel, float mark,
                                          string modelAnswer, bool isMarkedForDelete)
        {
            int? questionID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Questions_AddNewQuestion", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@QuestionText", questionText);
                        command.Parameters.AddWithValue("@QuestionType", questionType);
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@DifficultyLevel", difficultyLevel);
                        command.Parameters.AddWithValue("@Mark", mark);
                        command.Parameters.AddWithValue("@ModelAnswer", modelAnswer);
                        command.Parameters.AddWithValue("@IsMarkedForDelete", isMarkedForDelete);


                        SqlParameter outputQuestionIDParameter = new SqlParameter("@NewQuestionID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputQuestionIDParameter);

                        command.ExecuteNonQuery();

                        questionID = (int)outputQuestionIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                questionID = null;
            }
            return questionID;
        }

        public static bool UpdateQuestionInfo(int? questionID, string questionText, byte questionType,
                                             int courseID, byte difficultyLevel, float mark,
                                             string modelAnswer, bool isMarkedForDelete)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Questions_UpdateQuestionInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@QuestionID", questionID);
                        command.Parameters.AddWithValue("@QuestionText", questionText);
                        command.Parameters.AddWithValue("@QuestionType", questionType);
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@DifficultyLevel", difficultyLevel);
                        command.Parameters.AddWithValue("@Mark", mark);
                        command.Parameters.AddWithValue("@ModelAnswer", modelAnswer);
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

        public static bool DeleteQuestion(int? questionID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Questions_DeleteQuestion", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@QuestionID", (object)questionID ?? DBNull.Value);

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

        public static DataTable GetAllQuestions(int? instructorID)
        {
            DataTable questions = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_Questions_GetAllQuestions", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@InstructorID", (object)instructorID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                questions.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return questions;
        }

    }

}
