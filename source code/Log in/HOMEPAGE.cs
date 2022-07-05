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
    public partial class HOMEPAGE : Form
    {
        public HOMEPAGE()
        {
            InitializeComponent();
        }

        private void HOMEPAGE_Load(object sender, EventArgs e)
        {

        }

        private void addBankToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            new Form1().ShowDialog();
            
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new addBranch().ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new customer_signUp().ShowDialog();
        }

        private void listOfLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new showloan().ShowDialog();
        }

        private void listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new showloanemployeecustomer().ShowDialog();
        }

        private void listOfCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new showCustomer().ShowDialog();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void requestLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

      
        private void acppectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().ShowDialog();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
