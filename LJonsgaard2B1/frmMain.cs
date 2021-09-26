using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJonsgaard2B1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amoutAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            txtAmountAustralia.Text = amoutAustralia.ToString("");
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            txtRateAustralia.Text = rateAustralia.ToString("");
            decimal usdAustralia = amoutAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");

            decimal amountBhutan = Convert.ToDecimal(txtAmountBhtanese.Text);
            txtAmountBhtanese.Text = amountBhutan.ToString("");
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutanese.Text);
            txtRateBhutanese.Text = rateBhutan.ToString("");
            decimal usdBhutan = amountBhutan * rateBhutan;
            txtUSDBhutanese.Text = usdBhutan.ToString("0.00");

            decimal amountCosta = Convert.ToDecimal(txtAmountCosta.Text);
            txtAmountCosta.Text = amountCosta.ToString("");
            decimal rateCosta = Convert.ToDecimal(txtRateCosta.Text);
            txtRateCosta.Text = rateCosta.ToString("");
            decimal usdCosta = amountCosta * rateCosta;
            txtUSDCosta.Text = usdCosta.ToString("0.00");

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            txtAmountEuro.Text = amountEuro.ToString("");
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);
            txtRateEuro.Text = rateEuro.ToString("");
            decimal usdEuro = amountEuro * rateEuro;
            txtUSDEuro.Text = usdEuro.ToString("0.00");

            decimal totalUSD = usdAustralia + usdAustralia + usdCosta + usdEuro;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
