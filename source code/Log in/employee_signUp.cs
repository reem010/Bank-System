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
    public partial class employee_signUp : Form
    {
        public employee_signUp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");

        private void employee_signUp_Load(object sender, EventArgs e)
        {

        }

        private void Save(object sender, EventArgs e)
        {
            con.Open();

            String q = @" INSERT INTO EMPLOYEE(FNAME_EMPLOYEE,LNAME_EMPLOYEE,COUNTRY_EMPLOYEE,CITY_EMPLOYEE,STREET_EMPLOYEE,USERNAME_E,PASSWORD_E) 
                        values ( '" + textBox1.Text + "','" + textBox2.Text +
                "','" + textBox3.Text  + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text +  "');";

            SqlCommand cmd = new SqlCommand(q, con);

            login o = new login();

            o.Show();
            this.Hide();

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Register Successfully");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
