using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJonsgaard2F1
{
    public partial class IfElseStatements : Form
    {
        public IfElseStatements()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //// #1: if
            
            decimal subtotal = 0m;
            decimal discountPercent = 0.0m;
           
            result1Textbox.Text = Ex2fCalculations.Calc01(input1ATextbox.Text);

            // #2: if (block)
            
            result2Textbox.Text = Ex2fCalculations.Calc02(input2ATextbox.Text);

            //// #3: if else
           
            result3Textbox.Text = Ex2fCalculations.Calc03(input3ATextbox.Text);

            //// #4: if else if
            
            result4Textbox.Text = Ex2fCalculations.Calc04(input4ATextbox.Text);


            //// #5: Better range test
            
            result5Textbox.Text = Ex2fCalculations.Calc05(input5ATextbox.Text);

            //// #6: nested if statements
            
            result6Textbox.Text = Ex2fCalculations.Calc06(input6ATextbox.Text, input6BTextbox.Text);

            // #7: Input Validation
            result7Textbox.Text = Ex2fCalculations.Calc07(input7ATextbox.Text);

            // #8: Input validation, calculate total and shipping
            //      Shipping = $5.00 for orders under $50.00
            result8Textbox.Text = Ex2fCalculations.Calc08(input8ATextbox.Text, input8BTextbox.Text);

            // #9 Validate input, calculate difference * rate

            result9Textbox.Text = Ex2fCalculations.Calc09(input9ATextbox.Text, input9BTextbox.Text);

            // #10 Validate input, divide large num by small
            // Both numbers must be > 0
            result10Textbox.Text = Ex2fCalculations.Calc10(input10ATextbox.Text, input10BTextbox.Text);
        }
    }
}
