using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_MAN
{
    public class KeyHandler
    {
        private Form Form { get; set; }

        public KeyHandler(Form form)
        {
            this.Form = form;
            Form.KeyPreview = true;
            Form.Shown += Form_Shown;


        }

        private void Init()
        {
            Form.KeyDown += Form_KeyDown;

            var b = Form.Controls["btnClose"];
            if(b !=null)
                b.Click += B_Click;

        }

        private void Close()
        {
            Form.Close();
        }

        private void B_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            this.Init();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;

            }
        }


    }
}
