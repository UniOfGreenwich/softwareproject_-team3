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
using System.Windows.Shapes;

namespace BankingApp_Wpf
{
    public partial class WithdrawWindow : Window
    {
        public double WithdrawAmount { get; private set; }

        public WithdrawWindow(double currentBalance)
        {
            InitializeComponent();
            currentBalanceLabel.Content = $"{currentBalance}";
          
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(withdrawAmountTextBox.Text, out double amount))
            {
                WithdrawAmount = amount;
                DialogResult = true; // Set DialogResult to true to indicate successful withdrawal
                Close();
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
            }
        }
    }
}
