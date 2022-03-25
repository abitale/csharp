using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Kantor_WebApi.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }
        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM employee", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenkel = reader.GetString("jenkel"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
                connection.Close();
            }
            return list;
        }
        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM employee WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenkel = reader.GetString("nama"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
                connection.Close();
            }
            return list;
        }
    }
}
