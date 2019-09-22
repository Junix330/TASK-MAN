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
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        DataTable dtTask;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dtTask = new DataTable();
            dtTask.Columns.Add("PRJ");
            dtTask.Columns.Add("TYPE");
            dtTask.Columns.Add("PRIORITY");
            dtTask.Columns.Add("DESCRIPTION");
            dtTask.Columns.Add("INCHARGE");
            dtTask.Columns.Add("STATUS");

            gcTask.DataSource = dtTask;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.ShowDialog();
        }
    }
}
