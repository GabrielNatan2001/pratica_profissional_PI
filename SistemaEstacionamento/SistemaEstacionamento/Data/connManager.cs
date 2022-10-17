using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace SistemaEstacionamento.Data
{
    public class connManager
    {
        static string connectionString = "Provider=sqloledb; Data Source=GABRIEL\\SQLEXPRESS; Integrated Security=SSPI";

        public DataSet retornaDados(String query)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                DataSet ds = new DataSet();
                var adapter = new OleDbDataAdapter(query, connectionString);

                try
                {
                    connection.Open();
                    adapter.Fill(ds);
                }
                catch (Exception ex)
                {
                    return null;
                }
                connection.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
