﻿using System.Data;
using System.Data.SqlClient;


namespace Venar.Data
{
 
    public class DataServices
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataReader reader = null;
        DataTable data = null;
        const string ConnectionString = "Data Source = sql.bsite.net\\MSSQL2016; User ID = venar_dx; Password = venar1997; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = True; ";
        public DataTable Selection(string SQL, Dictionary<string, string> parametros)
        {            
            using (connection = new SqlConnection(@ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (command = new SqlCommand(SQL, connection))
                    {
                        if (parametros != null)
                        {
                            foreach (var prm in parametros)
                            {
                                command.Parameters.Add(new SqlParameter(prm.Key, prm.Value));
                            }
                        }
                        using (reader = command.ExecuteReader())
                        {
                            data = new DataTable();
                            data.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            return data;
        }
        public int Execute(string SQLText, Dictionary<string, string> parametros)
        {
            int result = 0;
            using (connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (command = new SqlCommand(SQLText, connection))
                {
                    if (parametros != null)
                    {
                        foreach (var p in parametros)
                        {
                            command.Parameters.Add(new SqlParameter(p.Key, p.Value));
                        }
                    }
                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }

    }
}



