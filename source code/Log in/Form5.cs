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
    public partial class Form5 : Form
    {
        private SqlCommand _cmd;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You rejected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //HOMEPAGE f = new HOMEPAGE();
            //this.Hide();
            //f.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            TextBox t1 = Form4.instance.tb1;
            TextBox t2 = Form4.instance.tb2;
            String q = @" INSERT INTO LOAN(LOANTYPE,LOANAMOUNT) values ( '" + t1.Text + "','" + t2.Text + "');";

            SqlCommand cmd = new SqlCommand(q, con);

            this.Hide();

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Request Successfully");
            this.Close();

        }

    }
}
