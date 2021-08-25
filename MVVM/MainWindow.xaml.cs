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
using MVVM.Model;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly CalculatorService CalculatorService = new ();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fistNumber = Convert.ToDecimal(TextBox.Text);
            var secondNumber = Convert.ToDecimal(TextBox2.Text);

            var comboBoxContent = ((ComboBoxItem)ComboBox.SelectedItem).Content;
            var operationType = ((TextBlock)comboBoxContent).Text;
            
            var result = operationType switch
            {
                "+" => CalculatorService.Sum(fistNumber, secondNumber),
                "-" => CalculatorService.Subtraction(fistNumber, secondNumber),
                "*" => CalculatorService.Multiplication(fistNumber, secondNumber),
                "/" => CalculatorService.Division(fistNumber, secondNumber),
                _ => 0m,
            };
            TextBlock.Text += $"{fistNumber} {operationType} {secondNumber} = {result}\n";
        }
    }
}
