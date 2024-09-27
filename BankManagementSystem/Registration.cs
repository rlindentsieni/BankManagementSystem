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
    public partial class Registration : Form
    {
        static bool registered = false; // static makes it usable/accessible in other forms.
        public Registration()
        {

            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); //Login form object.
            //Pass data to the login form:
            loginForm.lblName.Text = txtName.Text;
            loginForm.lblPass.Text = txtConfirmPass.Text;
            loginForm.lblEmail.Text = txtEmail.Text;
            
            MessageBox.Show("You Have Successfully registerd!");
            this.Hide();
            loginForm.ShowDialog(); // show the login form.
            this.Close();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {   
            // Password length validation:
            if (txtPassword.Text.Length < 5)
            {
                lblPass.Show();
                registered = false;
            }
            else { 
                lblPass.Hide();
                registered = true;
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            // Password confrimation validation (Matching):
            if (txtPassword.Text != txtConfirmPass.Text)
            {
                lblPassMatching.Show();
                registered = false;
            }
            else { 
                lblPassMatching.Hide();
                lblPassMatching.Text = "Password Correct!";
                lblPassMatching.ForeColor = Color.Green;
                lblPassMatching.Show();
                registered = true;
            }

            // Last validation: Enable the register button if No Errors
            if (registered) { 
                btnRegister.Enabled = true;
                btnRegister.BackColor = Color.Black;
            }

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            if (!btnRegister.Enabled)//The code checks if the btnRegister button is not enabled when the form loads.
            {
                btnRegister.BackColor = Color.White;
            }
        }
    }
}
