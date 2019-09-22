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

        public bool Test()
        {


            var s = string.Format("Server={0};Database='{3}';Uid='{1}';Pwd='{2}';", Server, Username, Password, Database);
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
            catch (Exception ex)
            {
                XtraMsg.Error(ex.Message);
                return false;
            }
        }


    }


}
