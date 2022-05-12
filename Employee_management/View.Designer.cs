
namespace Employee_management
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBox_close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DBO = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_gen = new System.Windows.Forms.Label();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.lbl_empEdu = new System.Windows.Forms.Label();
            this.lbl_empPos = new System.Windows.Forms.Label();
            this.lbl_empAdd = new System.Windows.Forms.Label();
            this.lbl_empID = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(66, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 30);
            this.label12.TabIndex = 15;
            this.label12.Text = "Employee Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // picBox_close
            // 
            this.picBox_close.AutoSize = true;
            this.picBox_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.picBox_close.ForeColor = System.Drawing.Color.White;
            this.picBox_close.Location = new System.Drawing.Point(1446, 7);
            this.picBox_close.Name = "picBox_close";
            this.picBox_close.Size = new System.Drawing.Size(30, 32);
            this.picBox_close.TabIndex = 13;
            this.picBox_close.Text = "X";
            this.picBox_close.Click += new System.EventHandler(this.picBox_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_DBO);
            this.panel1.Controls.Add(this.lbl_phone);
            this.panel1.Controls.Add(this.lbl_gen);
            this.panel1.Controls.Add(this.lbl_empName);
            this.panel1.Controls.Add(this.lbl_empEdu);
            this.panel1.Controls.Add(this.lbl_empPos);
            this.panel1.Controls.Add(this.lbl_empAdd);
            this.panel1.Controls.Add(this.lbl_empID);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.txt_empID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 614);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_DBO
            // 
            this.lbl_DBO.AutoSize = true;
            this.lbl_DBO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DBO.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_DBO.Location = new System.Drawing.Point(1082, 421);
            this.lbl_DBO.Name = "lbl_DBO";
            this.lbl_DBO.Size = new System.Drawing.Size(95, 30);
            this.lbl_DBO.TabIndex = 36;
            this.lbl_DBO.Text = "BirthDay";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_phone.Location = new System.Drawing.Point(1079, 324);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(176, 30);
            this.lbl_phone.TabIndex = 35;
            this.lbl_phone.Text = "Employee Phone";
            // 
            // lbl_gen
            // 
            this.lbl_gen.AutoSize = true;
            this.lbl_gen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_gen.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_gen.Location = new System.Drawing.Point(1079, 220);
            this.lbl_gen.Name = "lbl_gen";
            this.lbl_gen.Size = new System.Drawing.Size(187, 30);
            this.lbl_gen.TabIndex = 34;
            this.lbl_gen.Text = "Employee Gender";
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_empName.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_empName.Location = new System.Drawing.Point(1082, 127);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(173, 30);
            this.lbl_empName.TabIndex = 33;
            this.lbl_empName.Text = "Employee Name";
            // 
            // lbl_empEdu
            // 
            this.lbl_empEdu.AutoSize = true;
            this.lbl_empEdu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_empEdu.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_empEdu.Location = new System.Drawing.Point(444, 434);
            this.lbl_empEdu.Name = "lbl_empEdu";
            this.lbl_empEdu.Size = new System.Drawing.Size(209, 30);
            this.lbl_empEdu.TabIndex = 32;
            this.lbl_empEdu.Text = "Employee Education";
            // 
            // lbl_empPos
            // 
            this.lbl_empPos.AutoSize = true;
            this.lbl_empPos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_empPos.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_empPos.Location = new System.Drawing.Point(444, 324);
            this.lbl_empPos.Name = "lbl_empPos";
            this.lbl_empPos.Size = new System.Drawing.Size(190, 30);
            this.lbl_empPos.TabIndex = 31;
            this.lbl_empPos.Text = "Employee Position";
            // 
            // lbl_empAdd
            // 
            this.lbl_empAdd.AutoSize = true;
            this.lbl_empAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_empAdd.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_empAdd.Location = new System.Drawing.Point(444, 220);
            this.lbl_empAdd.Name = "lbl_empAdd";
            this.lbl_empAdd.Size = new System.Drawing.Size(193, 30);
            this.lbl_empAdd.TabIndex = 30;
            this.lbl_empAdd.Text = "Employee Address";
            // 
            // lbl_empID
            // 
            this.lbl_empID.AutoSize = true;
            this.lbl_empID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_empID.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_empID.Location = new System.Drawing.Point(447, 127);
            this.lbl_empID.Name = "lbl_empID";
            this.lbl_empID.Size = new System.Drawing.Size(136, 30);
            this.lbl_empID.TabIndex = 29;
            this.lbl_empID.Text = "Employee ID";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(849, 39);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(112, 40);
            this.btn_refresh.TabIndex = 28;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_empID
            // 
            this.txt_empID.Location = new System.Drawing.Point(614, 44);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(229, 31);
            this.txt_empID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(472, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Employee ID";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(778, 505);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(112, 40);
            this.btn_home.TabIndex = 25;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(614, 505);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(112, 40);
            this.btn_print.TabIndex = 22;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(205, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "Employee Education";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(864, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(205, 324);
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
            this.label6.Location = new System.Drawing.Point(864, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "BirthDay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(864, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Employee Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(205, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(864, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(208, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1482, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBox_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label picBox_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_DBO;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_gen;
        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.Label lbl_empEdu;
        private System.Windows.Forms.Label lbl_empPos;
        private System.Windows.Forms.Label lbl_empAdd;
        private System.Windows.Forms.Label lbl_empID;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}