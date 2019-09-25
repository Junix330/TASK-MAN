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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            Project.CURRENT_USER = txtUser.Text;
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}