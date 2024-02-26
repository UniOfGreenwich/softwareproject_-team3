using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace dataBASE
{
    public partial class StudentMyInfo : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public static StudentMyInfo Instance;

        public string Name { get; set; }
        public string Password { get; set; }



        public StudentMyInfo(string name, string password)
        {
            InitializeComponent();

            Instance = this;

            Name = name;
            Password = password;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;

            FillInfo();
    }


        public void FillInfo()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False";


            textBox1.Text = Name;

            String querry = "SELECT Name, FullName, Email, Role, PhoneNumber FROM dbo.Account_data WHERE Name = '" + Name + "' AND Password = '" + Password + "'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(querry, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string fullName = reader.GetString(reader.GetOrdinal("FullName"));
                    textBox2.Text = fullName;

                    string email = reader.GetString(reader.GetOrdinal("Email"));
                    textBox3.Text = email;

                    textBox4.Text = "***";

                    string phoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                    textBox5.Text = phoneNumber;

                    SqlBoolean roleSql = reader.GetSqlBoolean(reader.GetOrdinal("Role"));
                    bool role = roleSql.Value;

                    if (role)
                    {
                        label1.Text = "    StaffID:";
                    }
                    
                }
                reader.Close();
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool isButtonClicked = true;

        private void button3_Click(object sender, EventArgs e)
        {

            isButtonClicked = !isButtonClicked;

            if (isButtonClicked)
            {
                button3.Text = "Update Your Info";
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                label6.Text = "";

                //if (textBox3.Text.Length == 0) 

                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                String querry = "SELECT Name, FullName, Email, PhoneNumber FROM dbo.Account_data WHERE Name = '" + Name + "' AND Password = '" + Password + "'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(querry, conn);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {

                        if (textBox3.Text.Length == 0)
                        {
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            textBox3.Text = email;
                        }
                        else
                        {
                            string newEmail = textBox3.Text;
                            using (SqlConnection conn1 = new SqlConnection(connectionString))
                            {
                                conn1.Open();
                                SqlCommand command1 = new SqlCommand();
                                command1.Connection = conn1;
                                command1.CommandText = "UPDATE dbo.Account_data SET Email = @Email WHERE Name = '" + Name + "' AND Password = '" + Password + "'";
                                command1.Parameters.AddWithValue("@Email", newEmail);
                                command1.ExecuteNonQuery();
                                conn1.Close();
                            }
                        }

                        if (textBox4.Text.Length == 0)
                        {
                            textBox4.Text = "***";
                        }
                        else
                        {
                            string newPassword = textBox4.Text;
                            using (SqlConnection conn1 = new SqlConnection(connectionString))
                            {
                                conn1.Open();
                                SqlCommand command1 = new SqlCommand();
                                command1.Connection = conn1;
                                command1.CommandText = "UPDATE dbo.Account_data SET Password = @Password WHERE Name = '" + Name + "' AND Password = '" + Password + "'";
                                command1.Parameters.AddWithValue("@Password", newPassword);
                                command1.ExecuteNonQuery();
                                conn1.Close();
                                textBox4.Text = "***";
                            }
                        }


                        if (textBox5.Text.Length == 0)
                        {
                            string phoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                            textBox5.Text = phoneNumber;
                        }
                        else
                        {
                            string newPhoneNumber = textBox5.Text;
                            using (SqlConnection conn1 = new SqlConnection(connectionString))
                            {
                                conn1.Open();
                                SqlCommand command1 = new SqlCommand();
                                command1.Connection = conn1;
                                command1.CommandText = "UPDATE dbo.Account_data SET PhoneNumber = @PhoneNumber WHERE Name = '" + Name + "' AND Password = '" + Password + "'";
                                command1.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
                                command1.ExecuteNonQuery();
                                conn1.Close();
                                
                            }
                        }


                    }
                    reader.Close();
                }
            }
            else
            {
                button3.Text = "Save";
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                label6.Text = "* Empty text boxes won't be updated";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
