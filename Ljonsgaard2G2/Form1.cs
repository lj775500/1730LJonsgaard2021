using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ljonsgaard2G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 1a) "Switch with no default
            resultSwitch01Textbox.Text = Ex2gCalculations.Switch01(input1aTextbox.Text);

            // 1b) Seprate "if" statements
            resultIf01Textbox.Text = Ex2gCalculations.If01(input1aTextbox.Text);

            // 1c) if elseIf
            resultElseIf01Textbox.Text = Ex2gCalculations.ElseIf01(input1aTextbox.Text);

            // 1d) Nested if-else
            resultNestedIfElse1Textbox.Text = Ex2gCalculations.NestedIfElse01(input1aTextbox.Text);

            // 1a) "Switch with no default
            resultSwitchDefault01Textbox.Text = Ex2gCalculations.SwitchDefault01(input1aTextbox.Text);

            // 1b) Seprate "if" statements, default value
            resultIfDefault01Textbox.Text = Ex2gCalculations.IfDefault01(input1aTextbox.Text);

            // 1g) if elseIf with default
            resultElseIfDefault01Textbox.Text = Ex2gCalculations.ElseIfDefault01(input1aTextbox.Text);

            // 1h) Nested if-else with Default
            resultNestedIfElse1DefaultTextbox.Text = Ex2gCalculations.NestedIfElseDefault01(input1aTextbox.Text);

            // 2a) "Switch with no default
            resultSwitch02Textbox.Text = Ex2gCalculations.Switch02(input2aTextbox.Text);

            // 2b) Separate 'if' statements
            resultIf02Textbox.Text = Ex2gCalculations.If02(input2aTextbox.Text);

            // 2c) if elseif  
            resultElseIf02Textbox.Text = Ex2gCalculations.ElseIf02(input2aTextbox.Text);

            // 2d) Nested if-else
            resultNestedIfElse2Textbox.Text = Ex2gCalculations.NestedIfElse02(input2aTextbox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
