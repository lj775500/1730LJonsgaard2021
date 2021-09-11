using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJonsgaard1d1
{
    public partial class frmCurrencyConversion : Form
    {
        public frmCurrencyConversion()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (Convert.ToDecimal(txtAmountAustralia.Text)
                * Convert.ToDecimal(txtRateAustralia.Text)).ToString("0.00");
        }

        private void bhutaneseTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutanese.Text = (Convert.ToDecimal(txtAmountBhtanese.Text)
                * Convert.ToDecimal(txtRateBhutanese.Text)).ToString("0.00");
        }

        private void costaTextChanged(object sender, EventArgs e)
        {
            txtUSDCosta.Text = (Convert.ToDecimal(txtAmountCosta.Text)
                * Convert.ToDecimal(txtRateCosta.Text)).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (Convert.ToDecimal(txtAmountEuro.Text)
                * Convert.ToDecimal(txtRateEuro.Text)).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = 
                (Convert.ToDecimal(txtUSDAustralia.Text)
                + Convert.ToDecimal(txtUSDBhutanese.Text)
                + Convert.ToDecimal(txtUSDCosta.Text)
                + Convert.ToDecimal(txtUSDEuro.Text)).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.717976";
            txtAmountBhtanese.Text = "0.00";
            txtRateBhutanese.Text = "0.0139831";
            txtAmountCosta.Text = "0.00";
            txtRateCosta.Text = ".00176122";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.15528";
        }
    }
    }

