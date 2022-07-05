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
    public partial class addBranch : Form
    {
        public addBranch()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            String q = @" INSERT INTO BRANCH(NAME_BRANCH,COUNTRY_BRANCH,CITY_BRANCH,STREET_BRANCH) values ( '" + textBox2.Text +
                "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "');";

            SqlCommand cmd = new SqlCommand(q, con);

            this.Hide();

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Register Successfully");
            this.Close();
        }
    }
}
