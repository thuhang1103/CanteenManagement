using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get {   if( instance == null) instance = new DataProvider();
                    return DataProvider.instance; 
            }
           private set { DataProvider.instance = value; }
        }
        private DataProvider() {}
        private string connectionSTR = "Data Source=DESKTOP-1A34QEH\\SQLEXPRESS;Initial Catalog=CanTeenManager;Integrated Security=True";
        public DataTable ExcuteQuery(string query, Object[] parameter =null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null) {
                    String []ListPara =query.Split(' ');
                    int i = 0;
                    foreach (String item in ListPara) {
                        if (item.Contains("@")) {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();

            } 
                
            return data;


        }

        public int ExcuteNonQuery(string query, Object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    String[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (String item in ListPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();

            }

            return data;


        }


        public object ExcuteScalar(string query, Object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    String[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (String item in ListPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();

            }

            return data;


        }
    }
}
