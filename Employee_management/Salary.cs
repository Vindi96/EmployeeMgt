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

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            fetchEmpData();

        }
    }
}
