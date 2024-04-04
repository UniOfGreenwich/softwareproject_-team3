using System;
using System.Windows.Forms;

namespace dataBASE
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        // Event handler for PayButton Click event
        private void PayButton_Click(object sender, EventArgs e)
        {
            // Validate the credit card details
            if (IsValidCreditCard(CardNumText.Text, ExpiryDateText.Text, CVVText.Text))
            {
                // Check card type
                string cardType = GetCardType(CardNumText.Text);
                MessageBox.Show("Payment successful! Card Type: " + cardType);
            }
            else
            {
                MessageBox.Show("Invalid credit card details. Please check and try again.");
            }
        }

        // Method to validate credit card details
        private bool IsValidCreditCard(string cardNumber, string expiryDate, string cvv)
        {
            // Simple validation for demonstration purposes
            if (cardNumber.Length == 16 && expiryDate.Length == 5 && cvv.Length == 3)
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to determine the card type
        private string GetCardType(string cardNumber)
        {
            // Remove any non-numeric characters from the card number
            string cleanCardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            // Check card prefix to determine card type
            if (cleanCardNumber.StartsWith("4"))
            {
                return "Visa";
            }
            else if (cleanCardNumber.StartsWith("5"))
            {
                return "Mastercard";
            }
            else if (cleanCardNumber.StartsWith("34") || cleanCardNumber.StartsWith("37"))
            {
                return "American Express";
            }
            else
            {
                return "Unknown";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

