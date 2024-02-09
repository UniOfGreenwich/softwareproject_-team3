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

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            SQLcommands sqlCommands = new SQLcommands();
            try
            {
                
                DataTable dt = sqlCommands.StudentInfoTable(Name);

                //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                //String querry = "SELECT Name, FullName, Email, Role, PhoneNumber, Book_onHold, BookID1, BookId2, BookID3, Fees FROM dbo.Account_data WHERE Name = '" + Name + "'";

                bool Role = (bool)dt.Rows[0]["Role"];
                if (!Role)
                {
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
            catch(Exception Ex)
            {
                MessageBox.Show("catch:\n " + Ex.ToString() );
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
    }
}
