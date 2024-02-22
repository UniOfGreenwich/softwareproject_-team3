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
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        public List<int> AccountNumbers { get; set; }
        public bool IsSavingsAccount { get; private set; }

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            int newAccountNumber;
            if (!int.TryParse(accountNumberTextBox.Text, out newAccountNumber))
            {
                MessageBox.Show("Invalid account number. Please enter a valid integer.");
                return;
            }

            if (AccountNumbers.Contains(newAccountNumber))
            {
                MessageBox.Show("Account number already exists. Please choose a different account number.");
                return;
            }

            // Set IsSavingsAccount based on radio button selection
            IsSavingsAccount = savingsRadioButton.IsChecked ?? false;

            DialogResult = true; // Set DialogResult to true to indicate successful account creation
            Close();
        }
    }
}
