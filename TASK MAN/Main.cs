using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TASK_MAN
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        Conn con;
        Script script;
        DataTable dtTask;


        public Main()
        {
            InitializeComponent();
            con = new Conn();
            script = new Script(con);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            var f = new frmLogin();
            f.ShowDialog();

            dtTask = script.Run("SELECT ID_Task,Prj_Task,Type_Task,Level_Task,Desc_Task,Incharge_Task,Prepared_Task,Status_Task FROM task_master WHERE ID_Task <> 0 ", "DT");
            gcTask.DataSource = dtTask;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var f = new frmTask();
            f.ShowDialog();
        }


    }
}
