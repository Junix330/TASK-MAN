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

        private void Load()
        {
            var i = gvTask.FocusedRowHandle;

            dtTask = script.Run("SELECT ID_Task,Prj_Task,Type_Task,Level_Task,Desc_Task,Incharge_Task,Prepared_Task,Status_Task,Added_Task FROM task_master WHERE ID_Task <> 0 ORDER BY ID_Task DESC", "DT");
            gcTask.DataSource = dtTask;

            gvTask.FocusedRowHandle = i;
        }

        private void LoadUser()
        {
            Project.CURRENT_USER = "GUEST";
            btnLogin.Caption = Project.CURRENT_USER;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
           
            Load();
            LoadUser();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var f = new frmTask();
            f.ShowDialog();
            Load();
        }

        private void BtnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmLogin();
            f.ShowDialog();
        }

        private void TmRefresh_Tick(object sender, EventArgs e)
        {
            if (!con.Test()) return;
            Load();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            nyMain.Visible = false;
        }
    }
}
