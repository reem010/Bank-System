using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in
{
    public partial class Form4 : Form
    {
        public static Form4 instance;
        public TextBox tb1;
        public TextBox tb2;
        public Form4()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            tb2 = textBox2;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();


            

            Form5 f = new Form5();
            f.Show();
            this.Hide();

            con.Close();

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
