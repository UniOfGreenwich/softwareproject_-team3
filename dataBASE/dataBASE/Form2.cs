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
    public partial class Form2 : Form
    {
        public static Form2 Instance;

        public string FullName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }    

        public Form2(string fullName, string name, string password)
        {
            InitializeComponent();

            Instance = this;

            FullName = fullName;

            Name = name;

            Password = password;

            LabelText();

        }

        private void LabelText()
        {
            label1.Text = "Welcome, " + FullName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            this.SendToBack();
            ManageStudentAccounts manageStudentAccounts = new ManageStudentAccounts();
            manageStudentAccounts.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
