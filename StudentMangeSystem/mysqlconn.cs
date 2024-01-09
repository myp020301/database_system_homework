using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace StudentMangeSystem
{
    class mysqlconn
    {
        private string username, password;

        public mysqlconn()
        { 
        }
        public static MySqlConnection getConn(string username,string password)
        {
            String connetStr = $"server=127.0.0.1;port=3306;user={username};password={password}; database=studentmanage; Charset=utf8";
            
            MySqlConnection conn = new MySqlConnection(connetStr);
            return conn;
        }


    }
}
