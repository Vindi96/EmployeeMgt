
namespace Employee_management
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbo_empEdu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_empPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_DBO = new System.Windows.Forms.DateTimePicker();
            this.cbo_empPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_empGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_EmpAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgv_emp);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbo_empEdu);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_empPhone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp_DBO);
            this.panel1.Controls.Add(this.cbo_empPosition);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbo_empGender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_EmpAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_EmpName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_empID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 614);
            this.panel1.TabIndex = 4;
            // 
            // dgv_emp
            // 
            this.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp.Location = new System.Drawing.Point(610, 27);
            this.dgv_emp.Name = "dgv_emp";
            this.dgv_emp.RowHeadersWidth = 62;
            this.dgv_emp.RowTemplate.Height = 33;
            this.dgv_emp.Size = new System.Drawing.Size(846, 558);
            this.dgv_emp.TabIndex = 26;
            this.dgv_emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellContentClick);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(460, 514);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(112, 40);
            this.btn_home.TabIndex = 25;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(460, 468);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 40);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(460, 419);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 40);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo_empEdu
            // 
            this.cbo_empEdu.FormattingEnabled = true;
            this.cbo_empEdu.Items.AddRange(new object[] {
            "BTec",
            "MTec",
            "BA",
            "MBA"});
            this.cbo_empEdu.Location = new System.Drawing.Point(56, 401);
            this.cbo_empEdu.Name = "cbo_empEdu";
            this.cbo_empEdu.Size = new System.Drawing.Size(229, 33);
            this.cbo_empEdu.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(56, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "Employee Education";
            // 
            // txt_empPhone
            // 
            this.txt_empPhone.Location = new System.Drawing.Point(343, 293);
            this.txt_empPhone.Multiline = true;
            this.txt_empPhone.Name = "txt_empPhone";
            this.txt_empPhone.Size = new System.Drawing.Size(229, 31);
            this.txt_empPhone.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(343, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee Phone";
            // 
            // dtp_DBO
            // 
            this.dtp_DBO.Location = new System.Drawing.Point(56, 520);
            this.dtp_DBO.Name = "dtp_DBO";
            this.dtp_DBO.Size = new System.Drawing.Size(292, 31);
            this.dtp_DBO.TabIndex = 17;
            // 
            // cbo_empPosition
            // 
            this.cbo_empPosition.FormattingEnabled = true;
            this.cbo_empPosition.Items.AddRange(new object[] {
            "Manager",
            "Senior Developer",
            "Business Analyst",
            "QA Engineer"});
            this.cbo_empPosition.Location = new System.Drawing.Point(56, 291);
            this.cbo_empPosition.Name = "cbo_empPosition";
            this.cbo_empPosition.Size = new System.Drawing.Size(229, 33);
            this.cbo_empPosition.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(56, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Employee Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(56, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "BirthDay";
            // 
            // cbo_empGender
            // 
            this.cbo_empGender.FormattingEnabled = true;
            this.cbo_empGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbo_empGender.Location = new System.Drawing.Point(343, 187);
            this.cbo_empGender.Name = "cbo_empGender";
            this.cbo_empGender.Size = new System.Drawing.Size(229, 33);
            this.cbo_empGender.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(343, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Employee Gender";
            // 
            // txt_EmpAdd
            // 
            this.txt_EmpAdd.Location = new System.Drawing.Point(56, 189);
            this.txt_EmpAdd.Multiline = true;
            this.txt_EmpAdd.Name = "txt_EmpAdd";
            this.txt_EmpAdd.Size = new System.Drawing.Size(229, 31);
            this.txt_EmpAdd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(56, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee Address";
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(343, 96);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(229, 31);
            this.txt_EmpName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(343, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name";
            // 
            // txt_empID
            // 
            this.txt_empID.Location = new System.Drawing.Point(59, 96);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(229, 31);
            this.txt_empID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(59, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1214, 699);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "DevelopedByVindi2022";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1188, 698);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1443, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 32);
            this.label11.TabIndex = 9;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(63, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 30);
            this.label12.TabIndex = 12;
            this.label12.Text = "Manage Employee";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1482, 738);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbo_empEdu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_empPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_DBO;
        private System.Windows.Forms.ComboBox cbo_empPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_empGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_EmpAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgv_emp;
    }
}