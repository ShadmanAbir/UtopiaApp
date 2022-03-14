using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopiaApp
{
    public class DbConnection
    {
        public SqliteConnection GetConnection()
        {
            SqliteConnection conn = new SqliteConnection("datasource=./db/UtopiaDB.db");
            return conn;
        }
        
    }
}
