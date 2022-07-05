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

namespace Log_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            String q = @" INSERT INTO BANK(NAMEBANK,STREETBANK,CITYBANK,COUNTRYBANK) values ( '" + textBox1.Text + "','" + textBox2.Text +
                "','" + textBox3.Text + "','" + textBox4.Text + "');";

            SqlCommand cmd = new SqlCommand(q, con);

            this.Hide();

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Register Successfully");
            this.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
