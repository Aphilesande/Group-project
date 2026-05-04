using System;
using System.Windows.Forms;

namespace Group_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // when the user clicks create account
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            // make sure all fields are filled in
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            // check email has an @ sign in it
            if (!email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.\nExample: 123456789@stu.ukzn.ac.za", "Invalid Email");
                return;
            }

            // password needs to be at least 6 characters
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Weak Password");
                return;
            }

            // make sure both passwords match
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Error");
                txtPassword.Clear();
                txtConfirm.Clear();
                return;
            }

            // check if account already exists
            if (UserStore.EmailExists(email))
            {
                MessageBox.Show("An account with this email already exists.", "Error");
                return;
            }

            // all good, save the account and go to login
            UserStore.AddUser(email, password);
            MessageBox.Show("Account created! You can now log in.", "Success");
            new Form3().Show();
            this.Close();
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