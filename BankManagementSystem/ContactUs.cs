using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog(); // show the login form.
            this.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            //string subtitle = txtSubject.Text;

            if (!string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Form submitted successfully!" + username);
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }


          
        }
    }
}
