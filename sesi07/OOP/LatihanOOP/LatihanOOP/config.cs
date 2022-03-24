using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace LatihanOOP
{
    public class Config
    {
        string connectionString = "";
        public MySqlConnection connection = null;
        public string server = "127.0.0.1";
        public string user = "root";
        public string pass = "";
        DataSet ds;
        DataTable dt;
        public String table = "user_info";
        public string connectionType = "";
        string recordSource = "";

        DataGridView tempdata;

        public Config()
        {

        }

        public void Connect(string dbName)
        {
            try
            {
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + dbName + ";" + "UID=" + user + ";" + "PASS=" + pass+";";
                connection = new MySqlConnection(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ExecuteSql(string sqlCommand)
        {
            Nowquiee(sqlCommand);
        }

        public void Nowquiee(string sqlCommand)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(connectionString);
                cs.Open();
                MySqlCommand com = new MySqlCommand(sqlCommand, cs);
                com.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int Execute(string sqlCommand)
        {
            recordSource = sqlCommand;
            connectionType = table;
            dt = new DataTable(connectionType);
            try
            {
                string command = recordSource.ToUpper();

                MySqlDataAdapter adapter2 = new MySqlDataAdapter(recordSource, connection);

                DataSet temps = new DataSet();
                adapter2.Fill(temps, connectionType);
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public string Results(int row, string columnName)
        {
            try
            {
                return dt.Rows[row][columnName].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }

        public void ExecuteSelect(string sqlCommand)
        {
            recordSource = sqlCommand;
            connectionType = table;
            dt = new DataTable(connectionType);
            try
            {
                string command = recordSource.ToUpper();
                MySqlDataAdapter adapter = new MySqlDataAdapter(recordSource, connection);
                ds = new DataSet();
                adapter.Fill(ds, connectionType);
                adapter.Fill(dt);
                tempdata = new DataGridView();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int Count()
        {
            return dt.Rows.Count;
        }
    }
}
