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
    public partial class frmLogin : Form
    {
        pnlRegister register = new pnlRegister();
        private List<Control> originalControls;

        public frmLogin()
        {
            InitializeComponent();
            originalControls = new List<Control>(panLogin.Controls.Cast<Control>());
            this.AcceptButton = btnLogin;
            this.KeyPress += frmLogin_KeyPress;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            panLogin.Controls.Clear();
            register = new pnlRegister();
            panLogin.Controls.Add(register);
            register.RegistrationCompleted += RegisterRegistrationCompleted;
        }

        private void panLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            if (databaseHelper.LoginUser(txtUsername.Text, txtPassword.Text))
            {
                User user = databaseHelper.GetUserInformation(txtUsername.Text);

                this.Hide();
                Main main = new Main();
                main.LoadUserInfo(user);
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK);
            }
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void RegisterRegistrationCompleted(object sender, EventArgs e)
        {
            MessageBox.Show("You can now Login!", "Registration Successful", MessageBoxButtons.OK);
            panLogin.Controls.Clear();
            foreach (Control control in originalControls)
            {
                panLogin.Controls.Add(control);
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click_1(sender, e);
            }
        }

        public void ClearFields()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLoginStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff staff = new Staff();
            staff.ShowDialog();
        }
    }
}