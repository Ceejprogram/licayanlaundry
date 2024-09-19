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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tabTransactionsPage_Click(object sender, EventArgs e)
        {

        }

        private void tabCustomerPage_Click(object sender, EventArgs e)
        {

        }

        private void tabServicesPage_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();                         
            frmLogin loginForm = (frmLogin)Application.OpenForms["frmLogin"];
            loginForm.ClearFields();
            loginForm.Show();
        }

        public void LoadUserInfo(User user)
        {
            lblMainName.Text = user.FullName;
            lblMainBDAY.Text = user.DateOfBirth.ToShortDateString();
            lblMainGender.Text = user.Gender;
            lblMainAddress.Text = user.Address;
            lblMainNo.Text = user.ContactNo;
            lblMainEmail.Text = user.Email;
            lblMainUsername.Text = user.Username;

            if (!string.IsNullOrEmpty(user.ProfilePicturePath))
            {
                picMainProfile.Image = Image.FromFile(user.ProfilePicturePath);
            }
        }

        private void lblMainAddresss_Click(object sender, EventArgs e)
        {

        }
    }
}
