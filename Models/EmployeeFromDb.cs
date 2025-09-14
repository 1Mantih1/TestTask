using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestTask.Classes;

namespace TestTask.Models
{
    class EmployeeFromDb
    {
        public List<Employee> LoadEmployees()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection connection = new SqlConnection(DbConnection.connectionStr);

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("EXEC GetEmployeesList", connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                employees.Add(new Employee(
                                    reader["Fio"].ToString(),
                                    reader["Status"].ToString(),
                                    reader["Department"].ToString(),
                                    reader["Post"].ToString(),
                                    reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                                    reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5)
                                ));
                            }
                        }
                    }
                }

                return employees;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}");
                return new List<Employee>();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
