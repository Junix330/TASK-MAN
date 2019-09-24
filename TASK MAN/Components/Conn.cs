using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_MAN
{

    public class Conn
    {
        public string Server { get; set; }

        public string Database { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Conn()
        {
            this.Server = "localhost";
            this.Database = "xel erp";
            this.Username = "root";
            this.Password = "root";
        }


        public Conn(string server, string db, string user, string pass)
        {
            this.Server = server;
            this.Database = db;
            this.Username = user;
            this.Password = pass;
        }

        public bool Test()
        {


            //var s = string.Format(" Server={0}; database ={ 0}; UID = UserName; password = your password", Server, Username, Password, Database);
            var s = string.Format("Server={0};port=3306;database='{3}';UID='{1}';password='{2}';", Server, Username, Password, Database);
            var c = new MySqlConnection(s);

            try
            {
                c.Open();
                if (c.State == System.Data.ConnectionState.Open)
                {
                    c.Close();
                    c.Dispose();
                    return true;
                }

                else
                {
                    c.Dispose();
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }


    }


}
