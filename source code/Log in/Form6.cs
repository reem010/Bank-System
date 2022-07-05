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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT  NAME_BRANCH as NameOfBranch FROM BRANCH as B inner join ACCOUNT as A on A.ACCOUNTNUMBER = B.BRANCH_ID group by NAME_BRANCH HAVING count(ACCOUNTNUMBER) = 0", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT C.SSN AS ID, FNAME +' '+ MIDDLENAME+' '+ LNAME AS FullName ,STREET_CUSTOMER+' '+CITY_CUSTOMER AS Adderss ,PHONE AS Phone ,count(DISTINCT EMPLOYEE_ID) as numberOfEmployee from CUSTOMER AS C INNER JOIN CUTOMER_PHONE AS CP ON C.SSN = CP.SSN INNER JOIN AVAILEDBY AS A ON C.SSN = A.SSN INNER JOIN LOAN AS L ON A.LOANNUMBER = L.LOANNUMBER INNER JOIN ADD_LOAN AS AL ON L.LOANNUMBER = AL.LOANNUMBER GROUP BY C.SSN, FNAME + ' ' + MIDDLENAME + ' ' + LNAME, STREET_CUSTOMER + ' ' + CITY_CUSTOMER, PHONE", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT C.SSN AS ID, FNAME +' '+ MIDDLENAME+' '+ LNAME AS FullName  FROM CUSTOMER AS C inner join AVAILEDBY AS A  on C.SSN = A.SSN GROUP BY FNAME + ' ' + MIDDLENAME + ' ' + LNAME, C.SSN HAVING count(LOANNUMBER) = 0", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT C.SSN AS ID, C.FNAME +' '+ C.MIDDLENAME+' '+ C.LNAME AS FullName  , count(LOANNUMBER) as numberOfLoans FROM CUSTOMER AS C inner join AVAILEDBY as A on C.SSN = A.SSN GROUP BY FNAME + ' ' + MIDDLENAME + ' ' + LNAME, C.SSN Having count(LOANNUMBER) = ( select max(LOANNUMBER) from AVAILEDBY as A where A.SSN = C.SSN ); ", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("select TOP 1 E.EMPLOYEE_ID as ID,  FNAME_EMPLOYEE +' '+LNAME_EMPLOYEE as EmployeeFullName , max(AL.LOANNUMBER) as NumberOfLoans from EMPLOYEE as E inner join ADD_LOAN as AL on  E.EMPLOYEE_ID = AL.EMPLOYEE_ID inner join LOAN as L on   L.LOANNUMBER = AL.LOANNUMBER Group by FNAME_EMPLOYEE + ' ' + LNAME_EMPLOYEE, E.EMPLOYEE_ID ", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT  NAME_BRANCH as NameOfBranch FROM BRANCH as B inner join EMPLOYEE as E on E.EMPLOYEE_ID = B.BRANCH_ID group by NAME_BRANCH  HAVING count(EMPLOYEE_ID) = 0", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;
            }
        }
    }

}
