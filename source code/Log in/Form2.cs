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
    public partial class Form2 : Form
    {
        private SqlCommand _cmd;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");

            con.Open();
            _cmd = new SqlCommand("UPDATE CUSTOMER SET FNAME=@a1 , MIDDLENAME = @a2 ,LNAME = @a3,CITY_CUSTOMER = @a4,STREET_CUSTOMER = @a5,PASSWORD_C = @a6 Where USERNAME_C = @a7", con);
            _cmd.Parameters.Add("a1", Convert.ToString(textBox9.Text));
            _cmd.Parameters.Add("a2", Convert.ToString(textBox8.Text));
            _cmd.Parameters.Add("a3", Convert.ToString(textBox3.Text));
            _cmd.Parameters.Add("a4", Convert.ToString(textBox4.Text));
            _cmd.Parameters.Add("a5", Convert.ToString(textBox5.Text));
            _cmd.Parameters.Add("a6", Convert.ToString(textBox7.Text));
            _cmd.Parameters.Add("a7", Convert.ToString(textBox6.Text));
            _cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update has successfully executed");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True ");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CUSTOMER " , con);
               
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

    }
}

    

