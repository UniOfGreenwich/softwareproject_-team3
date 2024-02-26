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
        public static ManageStudentAccounts Instance;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool isButtonClicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            String querry = "SELECT Name, FullName, Email, Role, PhoneNumber, Book_onHold, BookID1, BookId2, BookID3, Fees FROM dbo.Account_data WHERE Name = '" + Name + "'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(querry, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bool Role = reader.GetBoolean(reader.GetOrdinal("Role"));
                    if (!Role)
                    {
                        string fullName = reader.GetString(reader.GetOrdinal("FullName"));
                        textBox2.Text = fullName.Trim();

                        string email = reader.GetString(reader.GetOrdinal("Email"));
                        textBox3.Text = email.Trim();

                        string phonenumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                        textBox5.Text = phonenumber.Trim();

                        bool BoH = reader.GetBoolean(reader.GetOrdinal("Book_onHold"));
                        if (BoH)
                        {
                            int BookId1 = reader.GetInt32(reader.GetOrdinal("BookID1"));  //Replace BookID1 with book name when adding books data base
                            textBox4.Text = BookId1.ToString();

                            int BookId2 = reader.GetInt32(reader.GetOrdinal("BookID2"));  //Replace BookID2 with book name when adding books data base
                            if (BookId2 != 0)
                            {
                                textBox4.Text += ", " + BookId2.ToString();

                                int BookId3 = reader.GetInt32(reader.GetOrdinal("BookID3")); //Replace BookID3 with book name when adding books data base
                                if (BookId3 != 0)
                                {
                                    textBox4.Text += ", " + BookId3.ToString();
                                }
                            }
                        }

                        decimal Fee = reader.GetDecimal(reader.GetOrdinal("Fees"));
                        textBox6.Text = "£ " + Fee.ToString();
                        button5.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong StudentID");
                    }

                }
                else
                {
                    MessageBox.Show("Wrong StudentID");
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

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
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False";

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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "UPDATE dbo.Account_data SET Email = @Email WHERE Name = '" + Name + "'";
                    command.Parameters.AddWithValue("@Email", newEmail);
                    command.ExecuteNonQuery();
                    conn.Close();

                }

                string newFullName = textBox2.Text;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "UPDATE dbo.Account_data SET FullName = @FullName WHERE Name = '" + Name + "'";
                    command.Parameters.AddWithValue("@FullName", newFullName);
                    command.ExecuteNonQuery();
                    conn.Close();
                }

                string newPhoneNumber = textBox5.Text;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "UPDATE dbo.Account_data SET PhoneNumber = @PhoneNumber WHERE Name = '" + Name + "'";
                    command.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
                    command.ExecuteNonQuery();
                    conn.Close();
                }

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
