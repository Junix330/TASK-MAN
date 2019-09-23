using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_MAN
{
    public class TaskController
    {

        Object Model;

        private Form Form { get; set; }

        public TaskController(Form form, Object model)
        {
            this.Form = form;
            this.Model = model;
            Form.KeyPreview = true;
            Form.Shown += Form_Shown;
        }

        private void Init()
        {
            Form.KeyDown += Form_KeyDown;

            Control c;

            c = Form.Controls["btnClose"];
            if (c != null) c.Click += B_Click;

            c = Form.Controls["btnSave"];
            if (c != null) c.Click += C_Click; ;


        }

        private void Close()
        {
            Form.Close();
        }

        private void Commit()
        {
            if(Model is TaskModel)
            {
                var m = Model as TaskModel;
                if (m == null) return;

                m.Commit();
                Close();
            }


        }

        private void C_Click(object sender, EventArgs e)
        {
            Commit();
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

                case Keys.S: //ctrl + s
                    if (e.Control) Commit();

                    break;

            }
        }


    }
}
