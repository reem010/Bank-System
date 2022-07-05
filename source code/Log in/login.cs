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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");
        
        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
               
                String querry = "SELECT * FROM EMPLOYEE  WHERE USERNAME_E = '"+txt_username.Text+ "' AND PASSWORD_E = '" + txt_password.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txt_password.Text;
                    user_password = txt_password.Text;

                    HOMEPAGE form2 = new HOMEPAGE();
                    form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            finally
            {
                conn.Close();
            }
            

        }

        private void signup_Click(object sender, EventArgs e)
        {
            selectTypeToSignUp form3 = new selectTypeToSignUp();
            form3.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void usertype(object sender, EventArgs e)
        {

        }
    }
}
