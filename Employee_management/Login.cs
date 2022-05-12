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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void picBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_userId.Text=="" || txt_pass.Text == "")
            {
                MessageBox.Show("Please Enter the User ID and Password");

            }else if(txt_userId.Text == "Admin" && txt_pass.Text == "Admin123")
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password");
            }
        }
    }
}
