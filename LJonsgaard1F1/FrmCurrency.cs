using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJonsgaard1F1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBt.BackgroundImage = picBtDim.Image;
            btnRica.BackgroundImage = picRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + lblCurrency.Text;
            txtRate.Text = ("0.717976");
            txtAmount.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBt.BackgroundImage = picBtDim.Image;
            btnRica.BackgroundImage = picRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = (":"); 
            lblCurrency.Text = btnAustralia.Text + lblCurrency.Text;
            txtRate.Text = ("0.717976");
            txtUS.Text = ("0.00");
            txtAmount.Text = ("0.00");
            txtAmount.Focus();
        }

        private void btnBt_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBt.BackgroundImage = picBt.Image;
            btnRica.BackgroundImage = picRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = (":");
            lblCurrency.Text = btnBt.Text + lblCurrency.Text;
            txtRate.Text = ("0.0139831");
            txtUS.Text = ("0.00");
            txtAmount.Text = ("0.00");
            txtAmount.Focus();
        }

        private void btnRica_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBt.BackgroundImage = picBtDim.Image;
            btnRica.BackgroundImage = picRica.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = (":");
            lblCurrency.Text = btnRica.Text + lblCurrency.Text;
            txtRate.Text = ("0.00176122");
            txtUS.Text = ("0.00");
            txtAmount.Text = ("0.00");
            txtAmount.Focus();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBt.BackgroundImage = picBtDim.Image;
            btnRica.BackgroundImage = picRicaDim.Image;
            btnEuro.BackgroundImage = picEuro.Image;
            lblCurrency.Text = (":");
            lblCurrency.Text = btnEuro.Text + lblCurrency.Text;
            txtRate.Text = ("1.15528");
            txtUS.Text = ("0.00");
            txtAmount.Text = ("0.00");
            txtAmount.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmount.Text = ("0.00");
            txtUS.Text = ("0.00");
            txtTotal.Text = ("0.00");
            lblEquation.Text = ("");
            txtAmount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            txtUS.Text = (Convert.ToDecimal(txtAmount.Text) 
                * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUS.Text;
            txtTotal.Text = (Convert.ToDecimal(txtTotal.Text)
                + Convert.ToDecimal(txtUS.Text)).ToString("0.00");
            txtAmount.Focus();
            txtAmount.SelectAll();
        }
    }
}
