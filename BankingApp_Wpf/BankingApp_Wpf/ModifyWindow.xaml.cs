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
    public partial class ModifyWindow : Window
    {
        public string NewFirstName { get; private set; }
        public string NewLastName { get; private set; }

        public ModifyWindow(string fn, string ln)
        {
            InitializeComponent();
            currentFirstNameLabel.Content = fn;
            currentLastNameLabel.Content = ln;
        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            NewFirstName = newFirstNameTextBox.Text;
            NewLastName = newLastNameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(NewFirstName) && !string.IsNullOrWhiteSpace(NewLastName))
            {
                DialogResult = true; // Set DialogResult to true to indicate successful modification
                Close();
            }
            else
            {
                MessageBox.Show("Both First Name and Last Name must be provided.");
            }
        }
    }
}
