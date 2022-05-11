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
    public partial class Employee : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-I2CIJO3;Initial Catalog=EmployeeDB;Integrated Security=True");
        public Employee()
        {
            InitializeComponent();
        }


        private void Employee_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_empID.Text == "" || txt_EmpName.Text == "" || txt_empPhone.Text == "" || txt_EmpAdd.Text == "")
            {
                MessageBox.Show("Missing some details.");
            }
            else
            {
                try {
                    sqlcon.Open();
                    String query = "insert into EmployeeTbl values("+txt_empID.Text+",'"+txt_EmpName.Text+"','"+txt_EmpAdd.Text+"','"+cbo_empPosition.SelectedItem.ToString()+"','"+dtp_DBO.Value.Date+"','"+txt_empPhone.Text+"','"+cbo_empEdu.SelectedItem.ToString()+"','"+cbo_empGender.SelectedItem.ToString()+"') ";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee details are successfully added");
                    sqlcon.Close();
                    populate();
                
                } catch(Exception Ex) {
                    MessageBox.Show(Ex.Message);
                
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            sqlcon.Open();
            String query = "Select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_emp.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_empID.Text == "") {
                MessageBox.Show("Enter the employee ID");
            }
            else
            {
                try
                {
                    sqlcon.Open();
                    string query = "Delete from EmployeeTbl where EmpID = '" + txt_empID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully");
                    sqlcon.Close();
                    populate();
                    
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_empID.Text = dgv_emp.SelectedRows[0].Cells[0].Value.ToString();
            txt_EmpName.Text = dgv_emp.SelectedRows[0].Cells[1].Value.ToString();
            txt_EmpAdd.Text = dgv_emp.SelectedRows[0].Cells[2].Value.ToString();
            cbo_empPosition.Text = dgv_emp.SelectedRows[0].Cells[3].Value.ToString();
            txt_empPhone.Text = dgv_emp.SelectedRows[0].Cells[5].Value.ToString();
            cbo_empGender.Text = dgv_emp.SelectedRows[0].Cells[7].Value.ToString();
            cbo_empEdu.Text = dgv_emp.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
