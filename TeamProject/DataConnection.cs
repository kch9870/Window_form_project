using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class DataConnection
    {
        public MySqlConnection Connection()
        {
            string constr = null;
            MySqlConnection conn;

            constr = "server=localhost;user=root;password=1234;database=teamproject";
            conn = new MySqlConnection(constr);
            return conn;
        }
    }
}
