using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestTask.Classes;

namespace TestTask.Models
{
    public class StatisticsFromDb
    {
        public List<string> LoadStatuses()
        {
            List<string> statuses = new List<string>();
            SqlConnection connection = new SqlConnection(DbConnection.connectionStr);

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("EXEC GetStatusesList", connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                statuses.Add(reader.GetString(0));
                            }
                        }
                    }
                }

                return statuses;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка загрузки статусов: {ex.Message}");
                return new List<string>();
            }
            finally
            {
                connection.Close();
            }
        }

        public int GetStatusIdByName(string statusName)
        {
            if (string.IsNullOrEmpty(statusName))
            {
                return 0;
            }

            SqlConnection connection = new SqlConnection(DbConnection.connectionStr);

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("EXEC GetStatusIdByName @StatusName", connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@StatusName", statusName);

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                        return id;
                }

                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка получения ID статуса: {ex.Message}");
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Statistics> LoadStatistics(int? statusId, DateTime start, DateTime end, bool isEmploy)
        {
            List<Statistics> stats = new List<Statistics>();
            SqlConnection connection = new SqlConnection(DbConnection.connectionStr);

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("EXEC GetEmployeeStatistics @StatusId, @StartDate, @EndDate, @IsEmploy", connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@StatusId", (object)statusId ?? DBNull.Value);
                    command.Parameters.AddWithValue("@StartDate", start);
                    command.Parameters.AddWithValue("@EndDate", end);
                    command.Parameters.AddWithValue("@IsEmploy", isEmploy);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                stats.Add(new Statistics(
                                    reader.GetDateTime(0),
                                    reader.GetInt32(1)
                                ));
                            }
                        }
                    }
                }

                return stats;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}");
                return new List<Statistics>();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
