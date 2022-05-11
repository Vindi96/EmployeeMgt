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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-I2CIJO3;Initial Catalog=EmployeeDB;Integrated Security=True");
        private void fetchEmpData()
        {
            sqlcon.Open();
            string query = "select * from EmployeeTbl where EmpID = '"+txt_empID.Text+"'";
            SqlCommand cmd = new SqlCommand(query,sqlcon);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                lbl_empID.Text = dr["EmpID"].ToString();
                lbl_empName.Text = dr["EmpName"].ToString();
                lbl_empAdd.Text = dr["EmpAddress"].ToString();
                lbl_empEdu.Text = dr["EmpEdu"].ToString();
                lbl_empPos.Text = dr["EmpPossition"].ToString();
                lbl_gen.Text = dr["EmpGen"].ToString();
                lbl_phone.Text = dr["EmpPhone"].ToString();
                lbl_DBO.Text = dr["EmpDOB"].ToString();

                lbl_empID.Visible = true;
                lbl_empName.Visible = true;
                lbl_empAdd.Visible = true;
                lbl_empEdu.Visible = true;
                lbl_empPos.Visible = true;
                lbl_gen.Visible = true;
                lbl_phone.Visible = true;
                lbl_DBO.Visible = true;
            }
            sqlcon.Close();
        }
        private void View_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void picBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            fetchEmpData();

        }
    }
}
