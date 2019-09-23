using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TASK_MAN
{
    public partial class frmTask : DevExpress.XtraEditors.XtraForm
    {
        public frmTask()
        {
            InitializeComponent();

            var t = new TaskModel(this);
            var k = new TaskController(this, t);
        }

        public frmTask(int id)
        {
            InitializeComponent();

            var t = new TaskModel(this, id);
            var k = new TaskController(this, t);
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {

        }
    }
}