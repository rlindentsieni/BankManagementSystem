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
    public partial class Login : Form
    {
        static bool loggedIn = false;
        public Login()
        {
            InitializeComponent();
            if (!btnRates.Enabled) 
            {
                btnRates.BackColor = Color.White;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == lblEmail.Text && txtPassword.Text == lblPass.Text)// hide labels 
            {
                MessageBox.Show("You have succesfully logged in!");

                loggedIn = true;
                lblName.Text = "Welcome back " + lblName.Text; //welcome message...
                lblName.Visible = true;
                label1.Hide();
                label2.Hide();
                txtEmail.Hide();
                txtPassword.Hide();
                btnLogin.Hide();
                btnRates.Enabled = true;
                if (btnRates.Enabled) { 
                    btnRates.BackColor = Color.Green;
                }
                
            }
        }

        private void btnRates_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExchangeRates exchangeRates = new ExchangeRates();
            exchangeRates.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs ContactUsForm = new ContactUs();
            ContactUsForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs AboutUsForm = new AboutUs();
            AboutUsForm.ShowDialog();
            this.Close();
                
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
