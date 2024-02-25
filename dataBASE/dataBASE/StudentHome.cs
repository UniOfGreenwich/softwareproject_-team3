using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBASE
{
    // Gets the passed data
    public partial class StudentHome : Form
    {

        public static StudentHome Instance;

        public string FullName { get; set; }
        public int BoH { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int BookID1 { get; set; }
        public int BookID2 { get; set; }
        public int BookID3 { get; set; }
        public StudentHome(string fullName, int boh, int BookId1, int BookId2, int BookId3, string name, string password)
        {
            InitializeComponent();

            Instance = this;

            FullName= fullName;

            Name = name;

            Password = password;

            BoH = boh;

            BookID1 = BookId1;

            BookID2 = BookId2;

            BookID3 = BookId3;

            LabelText();

        }

        //Fills labels with home screen info
        private void LabelText()
        {
            label1.Text = "Welcome, " + FullName;

            if (BoH == 0) { 
                label2.Text = "You currently have no books on hold!"; 
                button6.Enabled = false;
            }
            else
            {
                int i = 0;
                if (BookID1 > 0) { i++; }
                if (BookID2 > 0) { i++; }
                if (BookID3 > 0) { i++; }
                if (i > 1) 
                { 
                    label2.Text = "You currently have " + i + " books on hold";
                    button6.Text = "View Books on Hold";
                }
                else {label2.Text = "You currently have " + i + " book on hold";}
            }
            
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentMyInfo studentMyInfo = new StudentMyInfo(Name, Password);
            studentMyInfo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
