using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Database
{
    public class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"172.28.10.25\QA";

            string database = "barcode_db";
            string username = "sa";
            string password = "$umcevn123";
            return DBSQLServerUtils.GetDBConnection(datasource, database, password, username);
        }
    }
}
