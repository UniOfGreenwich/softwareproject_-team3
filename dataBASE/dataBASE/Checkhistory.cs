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
namespace dataBASE
{
    public partial class Checkhistory : Form
    {
        public static Checkhistory Instance;

        public Checkhistory()
        {
            InitializeComponent();

            Instance = this;
        }
        private void Checkhistory_load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data sources = MSSQLLocalDB; database= library;integrated security=True";
            SQLcommands cmd = new SQLcommands();
            cmd.Connection = con;

            cmd.CommandText = "select * from new DataTabel";
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0] ;
        }
        int bid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data sources = MSSQLLocalDB; database= library;integrated security=True";
            SQLcommands cmd = new SQLcommands();
            cmd.Connection = con;

            cmd.CommandText = "select * from new DataTabe where bid= ";
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void label1_Click(object sender, EventArgs e) //title book history 
        {

        }

        private void button2_Click(object sender, EventArgs e) //update option
        {
    
        }

        private void button4_Click(object sender, EventArgs e) //delete option
        {

        }

        private void button5_Click(object sender, EventArgs e) //cancel option
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)  // book name for search option
        {

        }

        private void button1_Click(object sender, EventArgs e)  //refresh button
        {

        }

        private void label3_Click(object sender, EventArgs e) //book name 
        {

        }
        private void label4_Click(object sender, EventArgs e) //book auther name 
        {

        }
        private void label5_Click(object sender, EventArgs e) //book publication 
        {

        }
        private void label6_Click(object sender, EventArgs e) //ISBN
        {

        }
        private void button3_Click(object sender, EventArgs e) //home
        {
            Close();
        }

        
    }
}