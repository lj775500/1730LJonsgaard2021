using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJonsgaardadveragetestscore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = ("0");
            txtTest2.Text = ("0");
            txtTest3.Text = ("0");
            txtAverage.Text = ("");
            txtTest1.Focus ();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = ((
                Convert.ToDecimal(txtTest1.Text) +
                Convert.ToDecimal(txtTest2.Text) +
                Convert.ToDecimal(txtTest3.Text))
                 / 3).ToString("0.00"); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
