using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJonsgaard2a1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            txtSubtotal.Text = subtotal.ToString("0.00");
            decimal discount = Convert.ToDecimal(txtDiscountPercent.Text) / 100;
            txtDiscountPercent.Text = discount.ToString("0.00");
            decimal damount = subtotal * discount;
            txtDiscountAmount.Text = damount.ToString("0.00");
            decimal total = subtotal - damount;
            txtTotal.Text = total.ToString("0.00");

        }
    }
}
