using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_MAN
{
    public static class XtraMsg
    {
        public static void Show(string msg, string title = "")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warn(string msg, string title = "")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Error(string msg, string title = "")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void Info(string msg, string title = "")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }


    public class Utils
    {

        public static void CfgSet(string key, string val)
        {

        }

        public static string CfgGet(string key)
        {

            return "";
        }

        public static string Clean(object obj)
        {
            if (obj == null) return "";
            var s = "";

            try
            {
                s = obj.ToString();
                s = s.Trim();
                return s;
            }
            catch
            {
                return "";
            }
        }



    }

}
