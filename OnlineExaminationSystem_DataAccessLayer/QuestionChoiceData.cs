using OnlineExaminationSystem_DataAccessLayer.Global;
using OnlineExaminationSystem_UtilityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OnlineExaminationSystem_DataAccessLayer
{
    public class QuestionChoiceData
    {
        public static bool GetQuestionChoiceInfoByID(int? questionChoiceID, ref int questionID, ref string choiceText)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_QuestionChoices_GetQuestionChoiceInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@QuestionChoiceID", (object)questionChoiceID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                questionID = (int)reader["QuestionID"];

                                choiceText = (string)reader["ChoiceText"];

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

        public static bool DoesQuestionChoiceExist(int? questionChoiceID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_QuestionChoices_CheckIfQuestionChoiceExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@QuestionChoiceID", (object)questionChoiceID ?? DBNull.Value);

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

        public static int? AddNewQuestionChoice(int questionID, string choiceText)
        {
            int? questionChoiceID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_QuestionChoices_AddNewQuestionChoice", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@QuestionID", questionID);
                        command.Parameters.AddWithValue("@ChoiceText", choiceText);


                        SqlParameter outputQuestionChoiceIDParameter = new SqlParameter("@NewQuestionChoiceID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputQuestionChoiceIDParameter);

                        command.ExecuteNonQuery();

                        questionChoiceID = (int)outputQuestionChoiceIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                questionChoiceID = null;
            }
            return questionChoiceID;
        }

        public static bool UpdateQuestionChoiceInfo(int? questionChoiceID, int questionID, string choiceText)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_QuestionChoices_UpdateQuestionChoiceInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@QuestionChoiceID", questionChoiceID);
                        command.Parameters.AddWithValue("@QuestionID", questionID);
                        command.Parameters.AddWithValue("@ChoiceText", choiceText);


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

        public static bool DeleteQuestionChoice(int? questionChoiceID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_QuestionChoices_DeleteQuestionChoice", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@QuestionChoiceID", (object)questionChoiceID ?? DBNull.Value);

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

        public static List<(int?, int, string)> GetAllQuestionChoices(int questionID)
        {
            var questionChoices = new List<(int?, int, string)>();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_QuestionChoices_GetAllQuestionChoices", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("QuestionID", questionID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                (int?, int, string) choice;
                                choice.Item1 = (int?)reader["QuestionChoiceID"];
                                choice.Item2 = (int)reader["QuestionID"];
                                choice.Item3 = (string)reader["ChoiceText"];

                                questionChoices.Add(choice);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return questionChoices;
        }

    }

}
