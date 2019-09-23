using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_MAN
{
    public class TaskModel
    {


        int id;
        Form form;
        MemoEdit mDesc;
        ComboBoxEdit cPrj, cType, cIncharge, cPriority;

        string q;
        Conn con;
        Script script;
        List<Control> fControls;

        public TaskModel(Form form)
        {
            this.form = form;
            form.Shown += Form_Shown;

            con = new Conn();
            script = new Script(con);
            fControls = new List<Control>();
        }

        public TaskModel(Form form, int id)
        {
            this.id = id;
            this.form = form;
            form.Shown += Form_Shown;

            con = new Conn();
            script = new Script(con);
            fControls = new List<Control>();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            Control c;

            c = form.Controls["txtDesc"];
            if (c != null)
            {
                mDesc = c as MemoEdit;
                fControls.Add(mDesc);
            }

            c = form.Controls["cboPrj"];
            if (c != null)
            {
                cPrj = c as ComboBoxEdit;
                fControls.Add(cPrj);
            }

            c = form.Controls["cboType"];
            if (c != null)
            {
                cType = c as ComboBoxEdit;
                fControls.Add(cType);
            }

            c = form.Controls["cboIncharge"];
            if (c != null)
            {
                cIncharge = c as ComboBoxEdit;
                fControls.Add(cIncharge);
            }

            c = form.Controls["cboLevel"];
            if (c != null)
            {
                cPriority = c as ComboBoxEdit;
                fControls.Add(cPriority);
            }

        }

        public bool Commit()
        {
            if (id == 0)
            {
                //adding
                string f = "", v = "";

                q = string.Format("INSERT INTO {0} ", form.Tag.ToString());

                foreach (var c in fControls)
                {
                    if (c == null) continue;
                    if (c.Tag == null) continue;
                    if (c.Tag.ToString() == "") continue;

                    if (f == "")
                        f += c.Tag.ToString();
                    else
                        f += "," + c.Tag.ToString();

                    if (v == "")
                        v += Utils.AddQT(c.Text.ToString());
                    else
                        v += "," + Utils.AddQT(c.Text.ToString());
                }

                q += string.Format(" ({0}) ", f);
                q += string.Format(" VALUES ({0}) ", v);

                script.Run(q);
            }
            else
            {
                //update

            }

            XtraMsg.Show(cType.Text);
            return false;
        }

        public bool Delete()
        {


            return false;
        }


        public string Project { get; set; }

        public string Level { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Incharge { get; set; }








    }
}
