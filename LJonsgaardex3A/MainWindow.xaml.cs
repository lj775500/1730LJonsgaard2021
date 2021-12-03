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

namespace LJonsgaardex3A
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
            resultTextbox0.Text = Ex3aLoops.Calc0(
                inputTextbox0a.Text, inputTextbox0b.Text, inputTextbox0c.Text);
            resultTextbox1.Text = Ex3aLoops.Calc1(
                inputTextbox1a.Text, inputTextbox1b.Text, inputTextbox1c.Text);
            resultTextbox2.Text = Ex3aLoops.Calc2(
                inputTextbox2a.Text, inputTextbox2b.Text, inputTextbox2c.Text);
            resultTextbox3.Text = Ex3aLoops.Calc3(
                inputTextbox3a.Text, inputTextbox3b.Text, inputTextbox3c.Text);
            resultTextbox4.Text = Ex3aLoops.Calc4(
                inputTextbox4a.Text, inputTextbox4b.Text, inputTextbox4c.Text);
            resultTextbox5.Text = Ex3aLoops.Calc5(
                inputTextbox5a.Text, inputTextbox5b.Text, inputTextbox5c.Text);
            resultTextbox6.Text = Ex3aLoops.Calc6(
                inputTextbox6a.Text, inputTextbox6b.Text);
            resultTextbox7.Text = Ex3aLoops.Calc7(
                inputTextbox7a.Text, inputTextbox7b.Text);
            resultTextbox8.Text = Ex3aLoops.Calc8(
                inputTextbox8a.Text, inputTextbox8b.Text);
        }
    }
}
