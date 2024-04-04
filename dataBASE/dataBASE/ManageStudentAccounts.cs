using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBASE
{
    public partial class ManageStudentAccounts : Form
    {
        SQLcommands sqlCommands = new SQLcommands();
        public static ManageStudentAccounts Instance;
        private bool isButtonClicked = false;
        public ManageStudentAccounts()
        {
            InitializeComponent();

            Instance = this;

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;

            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;

            button5.Enabled = false;
            button6.Enabled = false;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            SQLcommands sqlCommands = new SQLcommands();
            try
            {

                DataTable dt = sqlCommands.StudentInfoTable(Name);



                bool Role = (bool)dt.Rows[0]["Role"];
                if (!Role)
                {

                    button6.Enabled = true;

                    string fullName = (string)dt.Rows[0]["FullName"];
                    textBox2.Text = fullName.Trim();

                    string email = (string)dt.Rows[0]["Email"];
                    textBox3.Text = email.Trim();

                    string phonenumber = (string)dt.Rows[0]["PhoneNumber"];
                    textBox5.Text = phonenumber.Trim();

                    bool BoH = (bool)dt.Rows[0]["Book_onHold"];
                    if (BoH)
                    {
                        int BookId1 = (int)dt.Rows[0]["BookID1"];  //Replace BookID1 with book name when adding books data base
                        textBox4.Text = BookId1.ToString();

                        int BookId2 = (int)dt.Rows[0]["BookID2"];  //Replace BookID2 with book name when adding books data base
                        if (BookId2 != 0)
                        {
                            textBox4.Text += ", " + BookId2.ToString();

                            int BookId3 = (int)dt.Rows[0]["BookID3"]; //Replace BookID3 with book name when adding books data base
                            if (BookId3 != 0)
                            {
                                textBox4.Text += ", " + BookId3.ToString();
                            }
                        }
                    }

                    decimal Fee = (decimal)dt.Rows[0]["Fees"];
                    textBox6.Text = "£ " + Fee.ToString();
                    button5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong StudentID");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("catch:\n " + Ex.ToString());
            }

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            button6.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            isButtonClicked = !isButtonClicked;

            if (isButtonClicked)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = true;
                button5.Text = "Save";
            }
            else
            {
                button5.Text = "Edit";

                button6.Enabled = true;

                Name = textBox1.Text;

                string newEmail = textBox3.Text;
                sqlCommands.UpdateStudentInfo("Email", newEmail, Name);

                string newFullName = textBox2.Text;
                sqlCommands.UpdateStudentInfo("FullName", newFullName, Name);

                string newPhoneNumber = textBox5.Text;
                sqlCommands.UpdateStudentInfo("PhoneNumber", newPhoneNumber, Name);

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;

            }
        }

        private void ManageStudentAccounts_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string password = "";

            for (int i = 0; i < 9; i++)
            {
                password += chars[random.Next(chars.Length)];
            }
            textBox11.Text = password;
        }

        private bool isSecondWordEntered = false;
        private string generatedText = "";

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox9.Text.Trim();
            if (inputText.Contains(" "))
            {
                string[] words = inputText.Split(' ');

                if (words.Length >= 2 && !isSecondWordEntered)
                {
                    string firstLetters = words[0][0].ToString().ToLower() + words[1][0].ToString().ToLower();
                    Random rand = new Random();
                    string randomDigits = "";
                    for (int i = 0; i < 4; i++)
                    {
                        randomDigits += rand.Next(10).ToString();
                    }
                    char randomLetter = (char)('a' + rand.Next(26));
                    generatedText = firstLetters + randomDigits + randomLetter;

                    isSecondWordEntered = true;
                }
                textBox10.Text = generatedText;
            }
            else
            {
                textBox10.Text = "";
                isSecondWordEntered = false;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            SQLcommands sqlCommands = new SQLcommands();
            if (textBox10.Lines.Length > 0 && textBox9.Lines.Length > 0 && textBox8.Lines.Length > 0 && textBox7.Lines.Length > 0 && textBox11.Lines.Length > 0)
            {
                string name = textBox10.Text;
                string fullname = textBox9.Text;
                string email = textBox8.Text;
                string phonenumber = textBox7.Text;
                string password = textBox11.Text;
                sqlCommands.AddNewStudent(name, fullname, email, phonenumber, password);
                MessageBox.Show("User " + name + " added");
                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
                textBox11.Text = "";
            }
            else
            {
                MessageBox.Show("Fill all the text boxes");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SQLcommands sqlCommands = new SQLcommands();
                string name = textBox1 .Text;
                sqlCommands.DeleteUser(name);
                MessageBox.Show("User " + name + " deleted");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            else { }

        }

    }
}
