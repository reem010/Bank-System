using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in
{
    public partial class selectTypeToSignUp : Form
    {
        public selectTypeToSignUp()
        {
            InitializeComponent();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            employee_signUp form3 = new employee_signUp();
            form3.Show();
            this.Hide();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            customer_signUp form3 = new customer_signUp();
            form3.Show();
            this.Hide();
        }

        private void selectTypeToSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
