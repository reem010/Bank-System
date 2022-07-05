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
    public partial class showloanemployeecustomer : Form
    {
        public showloanemployeecustomer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT l.LOANNUMBER,l.LOANTYPE,LOANAMOUNT ,FNAME +' '+ MIDDLENAME+' '+ LNAME AS FullNameOfCustomer,FNAME_EMPLOYEE +' '+LNAME_EMPLOYEE as FullNameOfEmployee FROM LOAN as L inner join AVAILEDBY as A on L.LOANNUMBER = A.LOANNUMBER INNER join CUSTOMER as C on C.SSN = A.SSN inner join ADD_LOAN as AL ON AL.LOANNUMBER = L.LOANNUMBER INNER JOIN EMPLOYEE AS E ON E.EMPLOYEE_ID = AL.EMPLOYEE_ID GROUP BY l.LOANNUMBER, l.LOANTYPE, LOANAMOUNT, FNAME + ' ' + MIDDLENAME + ' ' + LNAME, FNAME_EMPLOYEE + ' ' + LNAME_EMPLOYEE" , con);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
