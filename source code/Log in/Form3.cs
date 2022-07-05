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
    public partial class Form3 : Form
    {
        private SqlCommand _cmd;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");

            con.Open();
            _cmd = new SqlCommand("UPDATE EMPLOYEE SET FNAME_EMPLOYEE=@a1 , LNAME_EMPLOYEE = @a3,CITY_EMPLOYEE = @a4,STREET_EMPLOYEE = @a5,PASSWORD_E = @a6 Where USERNAME_E = @a7", con);
            _cmd.Parameters.Add("a1", Convert.ToString(textBox9.Text));
            _cmd.Parameters.Add("a3", Convert.ToString(textBox3.Text));
            _cmd.Parameters.Add("a4", Convert.ToString(textBox4.Text));
            _cmd.Parameters.Add("a5", Convert.ToString(textBox5.Text));
            _cmd.Parameters.Add("a6", Convert.ToString(textBox7.Text));
            _cmd.Parameters.Add("a7", Convert.ToString(textBox6.Text));
            _cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update has successfully executed");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True ");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM EMPLOYEE ", con);

            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
