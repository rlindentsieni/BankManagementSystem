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
    public partial class ExchangeRates : Form
    {

        const double zar_to_usd = 17.32; // = 1 usd
        const double zar_to_euro = 19.31; // = 1 euro
        const double usd_to_euro = 1.11; // = 1 euro

        double rate = 0.0;

        public ExchangeRates()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            // Independent IFs to get the correct conversion rate:
            if (rdoZAR.Checked && cmbConvertTo.SelectedIndex == 0) // between ZAR to ZAR
            {
                rate = 1;
            }

            if (rdoZAR.Checked && cmbConvertTo.SelectedIndex == 1) // between ZAR to USD
            {
                rate = 1/zar_to_usd;
            }

            if (rdoZAR.Checked && cmbConvertTo.SelectedIndex == 2) // between ZAR to EURO
            {
                rate = 1/zar_to_euro;
            }

            if (rdoUSD.Checked && cmbConvertTo.SelectedIndex == 0) // between USD and ZAR
            {
                rate = zar_to_usd;
            }
            if (rdoUSD.Checked && cmbConvertTo.SelectedIndex == 1) // between USD and USD
            {
                rate = 1;
            }
            if (rdoUSD.Checked && cmbConvertTo.SelectedIndex == 2) // between USD and EURO
            {
                rate = 1 / usd_to_euro;
            }

            if (rdoEURO.Checked && cmbConvertTo.SelectedIndex == 0) // between EURO and ZAR
            {
                rate = zar_to_euro;
            }
            if (rdoEURO.Checked && cmbConvertTo.SelectedIndex == 1) // between EURO and USD
            {
                rate = usd_to_euro;
            }
            if (rdoEURO.Checked && cmbConvertTo.SelectedIndex == 2) // between EURO and EURO
            {
                rate = 1;
            }

            // Use the conversion rate to calculate the amount:
            double amount_to_convert = Double.Parse(txtAmount.Text);
            lblCurrencies.Text = "Amount in: " + cmbConvertTo.SelectedItem.ToString();
            lblResults.Text = (Math.Round(amount_to_convert * rate,2)).ToString();

        }

        private void rdoZAR_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoUSD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoEURO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog(); // show the login form.
            this.Close();
        }
    }
}
