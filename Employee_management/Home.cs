using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lbl_emp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void picBox_Emp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void picBox_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }

        private void picBox_view_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void lbl_view_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();

        }

        private void picBox_salary_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.Show();
            this.Hide();
        }

        private void lbl_salary_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.Show();
            this.Hide();

        }
    }
}
