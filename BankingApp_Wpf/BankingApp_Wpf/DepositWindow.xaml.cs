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
    public partial class DepositWindow : Window
    {
        public double DepositAmount { get; private set; }

        public DepositWindow()
        {
            InitializeComponent();

            
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(depositAmountTextBox.Text, out double amount))
            {
                DepositAmount = amount;
                DialogResult = true; // Set DialogResult to true to indicate successful deposit
                Close();
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
            }
        }
    }
}
