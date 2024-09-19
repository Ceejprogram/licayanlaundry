using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licayanlaundry
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnStaffExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin loginForm = (frmLogin)Application.OpenForms["frmLogin"];
            loginForm.ClearFields();
            loginForm.Show();
        }

        private void btnStaffLogin_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main main = new Main();       
            main.ShowDialog();
        }

        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStaffUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStaffPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
