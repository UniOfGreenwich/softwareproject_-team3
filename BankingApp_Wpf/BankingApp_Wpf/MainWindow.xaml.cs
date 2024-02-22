using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace BankingApp_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Account> accounts = new List<Account>();
        private Account account;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateAccountComboBox()
        {
            // Update the ComboBox with account numbers
            accountComboBox.ItemsSource = accounts.Select(acc => acc.AccountNumber).ToList();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the CreateAccount window
            CreateAccount createAccountWindow = new CreateAccount();
            createAccountWindow.Owner = this;

            // Populate the ComboBox in CreateAccount window with account numbers
            createAccountWindow.AccountNumbers = accounts.Select(acc => acc.AccountNumber).ToList();

            createAccountWindow.ShowDialog();

            if (createAccountWindow.DialogResult == true)
            {
                // Check for duplicate account numbers
                int newAccountNumber = int.Parse(createAccountWindow.accountNumberTextBox.Text);
                if (accounts.Any(acc => acc.AccountNumber == newAccountNumber))
                {
                    resultTextBlock.Text = "Account creation failed. Account number already exists.";
                    return;
                }

                // Create a new account if the user clicked "Create Account" in the CreateAccount window
                string firstName = createAccountWindow.firstNameTextBox.Text;
                string lastName = createAccountWindow.lastNameTextBox.Text;
                double initialBalance = double.Parse(createAccountWindow.initialBalanceTextBox.Text);
                bool isSavingsAccount = createAccountWindow.IsSavingsAccount;

                // Create the appropriate account type based on user selection
                if (isSavingsAccount)
                {
                    account = new SavingsAccount(newAccountNumber, firstName, lastName, initialBalance);
                }
                else
                {
                    account = new CurrentAccount(newAccountNumber, firstName, lastName, initialBalance) ;
                }

                account.Deposit(initialBalance);  // Deposit initial balance

                accounts.Add(account);  // Add the account to the list
                UpdateAccountComboBox(); // Update the ComboBox with the new account number
                resultTextBlock.Text = "Account created successfully.";
            }
            else
            {
                resultTextBlock.Text = "Account creation canceled.";
            }
        }

        private void AccountComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Change the currently selected account based on ComboBox selection
            if (accountComboBox.SelectedItem != null)
            {
                int selectedAccountNumber = (int)accountComboBox.SelectedItem;
                account = accounts.FirstOrDefault(acc => acc.AccountNumber == selectedAccountNumber);
                UpdateDetailsLabel();
            }
        }

        private void UpdateDetailsLabel()
        {
            // Update the details label with the current account information
            if (account != null)
            {
                firstNameLabel.Content = $"{account.FirstName}";
                lastNameLabel.Content = $"{account.LastName}";
                accountNumberLabel.Content = $"{account.AccountNumber}";
                balanceLabel.Content = $"{account.GetBalance()}";
            }
            else
            {
                detailsTextBlock.Text = "No account selected.";
            }
        }

        private void ViewBalanceButton_Click(object sender, RoutedEventArgs e)
        {
            // View balance of the current account
            if (account != null)
            {
                UpdateDetailsLabel();
            }
            else
            {
                resultTextBlock.Text = "No account selected.";
            }
        }

        private void ModifyAccountButton_Click(object sender, RoutedEventArgs e)
        {

            string fn = account.FirstName;
            string ln = account.LastName;

            // Open the ModifyWindow as a modal dialog
            ModifyWindow modifyWindow = new ModifyWindow(fn,ln);
            modifyWindow.Owner = this;
            modifyWindow.ShowDialog();


            if (modifyWindow.DialogResult == true)
            {
                // Modify account details if the user clicked "Modify" in the ModifyWindow
                if (account != null)
                {
                    account.ModifyAccount(modifyWindow.NewFirstName, modifyWindow.NewLastName);
                    UpdateDetailsLabel();
                    resultTextBlock.Text = "Account details modified successfully.";
                }
                else
                {
                    resultTextBlock.Text = "No account selected.";
                }
            }
            else
            {
                resultTextBlock.Text = "Modification canceled.";
            }
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the DepositWindow as a modal dialog
            DepositWindow depositWindow = new DepositWindow();
            depositWindow.Owner = this;
            depositWindow.ShowDialog();

            if (depositWindow.DialogResult == true)
            {
                // Deposit amount if the user clicked "Deposit" in the DepositWindow
                if (account != null)
                {
                    account.Deposit(depositWindow.DepositAmount);
                    UpdateDetailsLabel();
                    resultTextBlock.Text = $"Deposited {depositWindow.DepositAmount:C}.";
                }
                else
                {
                    resultTextBlock.Text = "No account selected.";
                }
            }
            else
            {
                resultTextBlock.Text = "Deposit canceled.";
            }
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            if (account != null)
            {
                double currentBalance = account.GetBalance(); // Replace with your logic to get the current balance

                // Open the WithdrawWindow as a modal dialog and pass the current balance
                WithdrawWindow withdrawWindow = new WithdrawWindow(currentBalance);
                withdrawWindow.Owner = this;
                withdrawWindow.ShowDialog();

                if (withdrawWindow.DialogResult == true)
                {
                    // Withdraw amount if the user clicked "Withdraw" in the WithdrawWindow
                    account.Withdraw(withdrawWindow.WithdrawAmount);
                    UpdateDetailsLabel();
                    resultTextBlock.Text = $"Withdrawn {withdrawWindow.WithdrawAmount:C}.";
                }
                else
                {
                    resultTextBlock.Text = "Withdrawal canceled.";
                }
            }
            else
            {
                resultTextBlock.Text = "No account selected.";
            }
        }


        private void DeleteAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Delete the current account
            if (account != null)
            {
                accounts.Remove(account); // Remove the account from the list
                account = null;
                UpdateDetailsLabel();
                resultTextBlock.Text = "Account deleted successfully.";
            }
            else
            {
                resultTextBlock.Text = "No account selected.";
            }
        }
    }
}
