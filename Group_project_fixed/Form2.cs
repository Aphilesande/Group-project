using System;
using System.Windows.Forms;

namespace Group_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // If user already has an account so we send them to the login page
        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        // user doesnt have an account yet so we send them to register
        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}