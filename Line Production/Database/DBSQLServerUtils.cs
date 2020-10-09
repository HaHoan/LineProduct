using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Database
{
    public class DBSQLServerUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database, string password, string username)
        {
            string connString = @"data source="+datasource+";initial catalog="+database+";user id="+username+";password="+password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

    }
}
