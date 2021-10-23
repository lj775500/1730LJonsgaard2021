using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJonsgaard2E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {

            result01Textbox.Text = "";
            result02Textbox.Text = "";
            result03aTextbox.Text = "";
            result03bTextbox.Text = "";
            result04aTextbox.Text = "";
            result04bTextbox.Text = "";
            result05aTextbox.Text = "";
            result05bTextbox.Text = "";
            result06aTextbox.Text = "";
            result06bTextbox.Text = "";
            result07aTextbox.Text = "";
            result08aTextbox.Text = "";
            result09aTextbox.Text = "";
            result10aTextbox.Text = "";

            // #01

            decimal subtotal = Convert.ToDecimal(input01aTextbox.Text);
            //result01Textbox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01Textbox.Text = (LogicalOperations.q01(subtotal)).ToString();

            // #02
            int timeInService = Convert.ToInt32(input02aTextbox.Text);
            //result02Textbox.Text = (timeInService <= 4 || timeInService >= 12).ToString();
            result02Textbox.Text = (LogicalOperations.q02(timeInService)).ToString();

            // #03 - 06 initialization
            bool isValid = Convert.ToBoolean(input03aTextbox.Text);
            int years = Convert.ToInt32(input03cTextbox.Text);

            // #03
            int counter = Convert.ToInt32(input03bTextbox.Text);
            result03aTextbox.Text = (
                LogicalOperations.q03(isValid, years, counter)
                ).ToString();
            result03bTextbox.Text = counter.ToString();

            // #04
            counter = Convert.ToInt32(input03bTextbox.Text);
            result04aTextbox.Text = (
                //isValid == true & counter++ < years
                LogicalOperations.q04(isValid, counter, years)
                ).ToString();
            result04bTextbox.Text = counter.ToString();

            // #05
            counter = Convert.ToInt32(input03bTextbox.Text);
            result05aTextbox.Text = (
                //isValid == true || counter++ < years
                LogicalOperations.q05(isValid, counter, years)
                ).ToString();
            result05bTextbox.Text = counter.ToString();

            // #06
            counter = Convert.ToInt32(input03bTextbox.Text);
            result06aTextbox.Text = (
                //isValid == true | counter++ < years
                LogicalOperations.q06(isValid, counter, years)
                ).ToString();
            result06bTextbox.Text = counter.ToString();

            //# 07
            DateTime startDate = Convert.ToDateTime(input07aTextbox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07bTextbox.Text);
            DateTime date = Convert.ToDateTime(input07cTextbox.Text);
            isValid = Convert.ToBoolean(input07dTextbox.Text);
            result07aTextbox.Text = (/*date > startDate && date < expirationDate || isValid == true*/
                LogicalOperations.q07(startDate, expirationDate, date, isValid)).ToString();

            //#08
            decimal thisYTD = Convert.ToDecimal(input08aTextbox.Text);
            decimal lastYTD = Convert.ToDecimal(input08bTextbox.Text);
            string empType = input08cTextbox.Text;
            int startYear = Convert.ToInt32(input08dTextbox.Text);
            int currentYear = Convert.ToInt32(input08eTextbox.Text);
            result08aTextbox.Text = (
                //((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear
                LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)
                ).ToString();

            //#09
            counter = Convert.ToInt32(input09aTextbox.Text);
            years = Convert.ToInt32(input09bTextbox.Text);
            result09aTextbox.Text = (
                //!(counter++ >= years)
                LogicalOperations.q09(counter, years)
                ).ToString();
            result09bTextbox.Text = counter.ToString();

            //#10
            int a = Convert.ToInt32(input10aTextbox.Text);
            int b = Convert.ToInt32(input10bTextbox.Text);
            int c = Convert.ToInt32(input10cTextbox.Text);
            int d = Convert.ToInt32(input10dTextbox.Text);
            result10aTextbox.Text = (
                //a > b && (b < c || c < d)
                LogicalOperations.q10(a,b,c,d)
                ).ToString();
            // bool v = a > b;
            // bool w = b < c;
            //bool x = c < d;
            //bool y = v && w;
            //bool z = y || x;
            //result10aTextbox.Text = z.ToString();

        }
    }
}
