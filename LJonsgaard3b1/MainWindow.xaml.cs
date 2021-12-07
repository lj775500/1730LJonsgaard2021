using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LJonsgaard3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            //0) Calculate discountPercent
            try
            {
                decimal subtotal = decimal.Parse(inputTextbox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(499m);
                resultTextbox0.Text = discountPercent.ToString("f3");
            }
            catch {
                resultTextbox0.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox0a.Text);
            }
            // 2) Calculate futureValue
            try
            {
                int months = Int32.Parse(this.inputTextbox2a.Text);
                decimal monthlyInvestment = decimal.Parse(inputTextbox2b.Text);
                decimal monthlyInterestRate = decimal.Parse(this.inputTextbox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
                resultTextbox2.Text = futureValue.ToString("c2");
            }
            catch {
                resultTextbox0.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextbox2a.Text + "\n"
                    + this.inputTextbox2b.Text + "\n"
                    + this.inputTextbox2c.Text + "\n");
            }
            // 4) Calculate degrees Celslus
            try
            {
                double fahrenheit = Double.Parse(inputTextbox4a.Text);
                double celsius = Ex3bCalculations.FahrenheitToCelsius(fahrenheit);
                resultTextbox4.Text = celsius.ToString("f1");


            }
            catch
            {
                resultTextbox0.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox4a.Text);
            }
            //6) Grtoss Pay
            try
            {
                decimal Hours = Decimal.Parse(this.inputTextbox6a.Text);
                decimal Rate = Decimal.Parse(this.inputTextbox6b.Text);
                decimal FutureValue = Ex3bCalculations.GrossPay(Hours, Rate);
                resultTextbox6.Text = FutureValue.ToString("c2");
            }
            catch
            {
                resultTextbox6.Text = "";
                MessageBox.Show("Invalid input:\n"
                                        + this.inputTextbox6a.Text + "\n"
                    + this.inputTextbox6b.Text + "\n");
                // Total Hours
                try
                {
                    this.resultTextbox7.Text =
                        Ex3bCalculations.TotalHours(this.inputTextbox7a.Text.ToString("n2");
                }

            
        }
    }
}
