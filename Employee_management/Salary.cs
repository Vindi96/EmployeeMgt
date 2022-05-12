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

namespace Employee_management
{
    public partial class Salary : Form
    {
        int total;
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-I2CIJO3;Initial Catalog=EmployeeDB;Integrated Security=True");

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void fetchEmpData()
        {
            if (txt_empID.Text == "")
            {
                MessageBox.Show("Enter the Employee ID");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string query = "select * from EmployeeTbl where EmpID = '" + txt_empID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {

                        txt_empName.Text = dr["EmpName"].ToString();
                        txt_empPos.Text = dr["EmpPossition"].ToString();


                    }
                    sqlcon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        
        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            fetchEmpData();

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int dailybase;
        private void btn_edit_Click(object sender, EventArgs e)
        {
           
            if (txt_empPos.Text == "")
            {
                MessageBox.Show("Select the position");
            }else if (txt_workDays.Text == "" || Convert.ToInt32(txt_workDays.Text) > 28)
            {
                MessageBox.Show("Insert valid number of days");
            }
            else
            {
                if (txt_empPos.Text == "Manager")
                {
                    dailybase = 250;

                }else if(txt_empPos.Text=="Senior Developer")
                {
                    dailybase = 250;

                }else if(txt_empPos.Text=="QA Engineer")
                {
                    dailybase = 200;

                }
                else
                {
                    dailybase = 100;
                }
                total = dailybase * Convert.ToInt32(txt_workDays.Text);
                SalarySlip.Text ="Employee ID: " +txt_empID.Text + "\n"+"Employee Name: " + txt_empName.Text + "\n"+"Employee Possition: " + txt_empPos.Text + "\n"+"Worked Days: " + txt_workDays.Text + "\n" +"Daily Salary RS: "+ dailybase + "\n" +"Total Salary RS: "+ total;

            }
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private void printDocument1_Printpage(object sender,System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=======SALARY DOCUMENT=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("Employee ID: "+txt_empID.Text,new Font("Century Gothic",18,FontStyle.Regular),Brushes.Gray,new Point(20,100));
            e.Graphics.DrawString("Employee Name: " + txt_empName.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Gray, new Point(20, 140));
            e.Graphics.DrawString("Employee Possition: " + txt_empPos.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Gray, new Point(20, 180));
            e.Graphics.DrawString("Worked days: " + txt_workDays.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Gray, new Point(20, 220));
            e.Graphics.DrawString("Daily Salary: " + dailybase, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Gray, new Point(20, 260));
            e.Graphics.DrawString("Salary: " + total, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Gray, new Point(20, 300));
            e.Graphics.DrawString("=======EmpiSoft=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180, 380));
        }

        private void SalarySlip_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
