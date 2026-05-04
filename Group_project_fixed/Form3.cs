using System;
using System.Windows.Forms;

namespace Group_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check if the login details are correct

            if (UserStore.ValidateUser(txtEmail.Text.Trim(), txtPassword.Text))
            {
                MessageBox.Show("Login successful!", "Success");
            }
            else
            {
                // wrong details, clear password and try again
                MessageBox.Show("Wrong email or password.", "Login Failed");
                txtPassword.Clear();
            }
        }

        // go back to the welcome screen
        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form2().Show();
            this.Close();
        }

        private void lblEmail_Click(object sender, EventArgs e) { }
    }
}