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
    public partial class BorrowingBook : Form
    {
        SQLcommands sqlCommands = new SQLcommands();
        public static BorrowingBook Instance;
        public string Name { get; set; }
        public BorrowingBook(string Name)
        {
            InitializeComponent();
            Instance = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
        }

        private void BorrowingBook_Load(object sender, EventArgs e)
        {

        }
    }
}
