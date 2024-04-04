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
    public partial class Form3 : Form
    {

        public static Form3 Instance;

        public string FullName { get; set; }
        public int BoH { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int BookID1 { get; set; }
        public int BookID2 { get; set; }
        public int BookID3 { get; set; }
        public Form3(string fullName, int boh, int BookId1, int BookId2, int BookId3, string name, string password)
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
                    label2.Text = "You currently h" +
                        "ave " + i + " books on hold";
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
            Checkhistory checkhistory = new Checkhistory();
            checkhistory.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SendToBack();
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
            this.SendToBack();
            BorrowingBook borrowingBook = new BorrowingBook(Name);
            borrowingBook.Show();
            borrowingBook.BringToFront();
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
