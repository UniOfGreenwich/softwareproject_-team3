using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace dataBASE
{
    public partial class Login : Form
    {
        
        public static Login Instance;


        public Login()
        {

            InitializeComponent();

            this.AcceptButton = LogInButton;

            Instance = this;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Name, Password;
            Name = txt_Name.Text;
            Password = txt_Password.Text;

            try
            {
                
               
                SQLcommands sqlCommands = new SQLcommands();

                DataTable dt = sqlCommands.GetHomeScreenDetails(Name, Password);
                // Returns information about currently logged in user as a Data Table

                if(dt.Rows.Count > 0 )
                {
                    Name = txt_Name.Text;
                    Password = txt_Password.Text;

                    string FullNameValue = (string)dt.Rows[0]["FullName"];
                    int BookId1 = (int)dt.Rows[0]["BookID1"];
                    int BookId2 = (int)dt.Rows[0]["BookID2"];
                    int BookId3 = (int)dt.Rows[0]["BookID3"];
                    bool Boh = (bool)dt.Rows[0]["Book_onHold"];
                    int BoH = Boh ? 1 : 0;
                   // Reeds required data

                    bool isStaff = (bool)dt.Rows[0]["Role"];
                    if (isStaff)
                    {
                        //Logged in as staff, pass required data to Form 2
                        StaffHome form2 = new StaffHome(FullNameValue, Name, Password);
                        form2.Show();
                        txt_Name.Clear();
                        txt_Password.Clear();
                    }
                    else
                    {
                        //Logged in as student, pass required data to Form 3
                        StudentHome form3 = new StudentHome(FullNameValue, BoH, BookId1, BookId2, BookId3, Name, Password);
                        form3.Show();
                        txt_Name.Clear();
                        txt_Password.Clear();
                    }



                }
                else
                {
                    MessageBox.Show("Invalid Login or Password");
                    txt_Name.Clear();
                    txt_Password.Clear();
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Catch Error:" + ex.Message);
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
