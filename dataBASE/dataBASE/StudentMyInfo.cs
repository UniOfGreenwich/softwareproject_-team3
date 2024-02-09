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
        SQLcommands sqlCommands = new SQLcommands();

        DataTable dt = new DataTable();

        //SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False");

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

            textBox1.Text = Name;

           
            dt = sqlCommands.StudentInfoTable(Name);

                    string fullname = (string)dt.Rows[0]["FullName"];
                    textBox2.Text = fullname;

                    string email = (string)dt.Rows[0]["Email"];
                    textBox3.Text = email;

                    textBox4.Text = "***";

                    string phoneNumber = (string)dt.Rows[0]["PhoneNumber"];
                    textBox5.Text = phoneNumber;

                    bool role = (bool)dt.Rows[0]["Role"];

                    if (role)
                    {
                        label1.Text = "    StaffID:";
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

               
                if (textBox3.Text.Length == 0)
                {
                    string email = (string)dt.Rows[0]["Email"];
                    textBox3.Text = email;
                }
                else
                {
                    string newEmail = textBox3.Text;

                    sqlCommands.UpdateStudentInfo("Email", newEmail, Name);

                }

                if (textBox4.Text.Length == 0)
                {
                    textBox4.Text = "***";
                }
                else
                {
                    string newPassword = textBox4.Text;

                    sqlCommands.UpdateStudentInfo("Password", newPassword, Name);
                }


                if (textBox5.Text.Length == 0)
                {
                    string phoneNumber = (string)dt.Rows[0]["PhoneNumber"];
                    textBox5.Text = phoneNumber;
                }
                else
                {
                    string newPhoneNumber = textBox5.Text;

                    sqlCommands.UpdateStudentInfo("PhoneNumber", newPhoneNumber, Name);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
