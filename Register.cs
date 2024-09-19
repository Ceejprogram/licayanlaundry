using Microsoft.Win32;
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
    public partial class pnlRegister : UserControl
    {     
        public event EventHandler RegistrationCompleted;
        private string profilePicturePath;

        public pnlRegister()
        {
            InitializeComponent();          
        }

        private void txtRegisUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegisPass_TextChanged(object sender, EventArgs e)
        {
            txtRegisPass.PasswordChar = '*';
        }

        private void txtRegisCPass_TextChanged(object sender, EventArgs e)
        {
            txtRegisCPass.PasswordChar = '*';

        }

        private void btnRegisRegister_Click_1(object sender, EventArgs e)
        {
            if (IsValidRegistration())
            {
                if (txtRegisPass.Text == txtRegisCPass.Text)
                {
                    DatabaseHelper databaseHelper = new DatabaseHelper();
                    string gender = radRegisMale.Checked ? "Male" : "Female";
                    databaseHelper.RegisterUser(
                        txtRegisName.Text,
                        dtpRegis.Value,
                        gender,
                        txtRegisAddress.Text,
                        txtRegisNo.Text,
                        txtRegisEmail.Text,
                        profilePicturePath,
                        txtRegisUser.Text,
                        txtRegisPass.Text,
                        txtRegisCPass.Text
                    );

                    RegistrationCompleted?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Password does not match.", "Registration Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Invalid registration, please complete all fields.", "Registration Error", MessageBoxButtons.OK);
            }
        }

        private void txtRegisAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegisNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegisEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegisName_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidRegistration()
        {
            return !string.IsNullOrWhiteSpace(txtRegisName.Text) &&
                    dtpRegis.Value != null &&
                    (radRegisMale.Checked || radRegisFemale.Checked) &&
                   !string.IsNullOrWhiteSpace(txtRegisAddress.Text) &&
                   !string.IsNullOrWhiteSpace(txtRegisNo.Text) &&
                   !string.IsNullOrWhiteSpace(txtRegisEmail.Text) &&
                   !string.IsNullOrWhiteSpace(profilePicturePath) &&
                   !string.IsNullOrWhiteSpace(txtRegisUser.Text) &&
                   !string.IsNullOrWhiteSpace(txtRegisPass.Text) &&
                   !string.IsNullOrWhiteSpace(txtRegisCPass.Text);
        }

        private void pnlRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisExit_Click(object sender, EventArgs e)
        {
            RegistrationCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void dtpRegis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radRegisMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radRegisFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picRegisCPic_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    profilePicturePath = openFileDialog.FileName;
                    picRegisCPic.Image = Image.FromFile(profilePicturePath);
                }
            }
        }
        
    }
}