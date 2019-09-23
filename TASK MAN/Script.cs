using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_MAN
{
    public class Script
    {
        Conn con { get; set; }
        MySqlConnection sqlCon;


        public Script(Conn Connection)
        {
            this.con = Connection;

            var s = string.Format("Server={0};port=3306;database='{3}';UID='{1}';password='{2}';", con.Server, con.Username, con.Password, con.Database);
            sqlCon = new MySqlConnection(s);

        }


        public bool Run(string q)
        {
            try
            {
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();


                var cmd = new MySqlCommand(q, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                XtraMsg.Error(ex.Message);
                return false;
            }
        }

        public DataTable Run(string q, string type)
        {
            var dt = new DataTable();
            var da = new MySqlDataAdapter(q, sqlCon);
            da.Fill(dt);
            da.Dispose();
            sqlCon.Close();

            return dt;
        }


    }
}
