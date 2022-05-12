
namespace Employee_management
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.label12 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_empPos = new System.Windows.Forms.ComboBox();
            this.SalarySlip = new System.Windows.Forms.RichTextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_workDays = new System.Windows.Forms.TextBox();
            this.txt_empName = new System.Windows.Forms.TextBox();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(71, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 30);
            this.label12.TabIndex = 15;
            this.label12.Text = "Salary";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1451, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 32);
            this.close.TabIndex = 13;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1214, 699);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "DevelopedByVindi2022";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1188, 698);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_empPos);
            this.panel1.Controls.Add(this.SalarySlip);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_workDays);
            this.panel1.Controls.Add(this.txt_empName);
            this.panel1.Controls.Add(this.txt_empID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 614);
            this.panel1.TabIndex = 18;
            // 
            // txt_empPos
            // 
            this.txt_empPos.FormattingEnabled = true;
            this.txt_empPos.Items.AddRange(new object[] {
            "Manager",
            "Senior Developer",
            "QA Engineer",
            "Business Analyst"});
            this.txt_empPos.Location = new System.Drawing.Point(69, 295);
            this.txt_empPos.Name = "txt_empPos";
            this.txt_empPos.Size = new System.Drawing.Size(245, 33);
            this.txt_empPos.TabIndex = 31;
            // 
            // SalarySlip
            // 
            this.SalarySlip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalarySlip.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalarySlip.ForeColor = System.Drawing.Color.SlateGray;
            this.SalarySlip.Location = new System.Drawing.Point(574, 43);
            this.SalarySlip.Name = "SalarySlip";
            this.SalarySlip.Size = new System.Drawing.Size(846, 491);
            this.SalarySlip.TabIndex = 30;
            this.SalarySlip.Text = "";
            this.SalarySlip.TextChanged += new System.EventHandler(this.SalarySlip_TextChanged);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(69, 444);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(112, 40);
            this.btn_home.TabIndex = 29;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(379, 67);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 40);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Fetch Data";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(202, 444);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 40);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "View";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(980, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_workDays
            // 
            this.txt_workDays.Location = new System.Drawing.Point(69, 386);
            this.txt_workDays.Name = "txt_workDays";
            this.txt_workDays.Size = new System.Drawing.Size(245, 31);
            this.txt_workDays.TabIndex = 19;
            // 
            // txt_empName
            // 
            this.txt_empName.Location = new System.Drawing.Point(69, 177);
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.Size = new System.Drawing.Size(245, 31);
            this.txt_empName.TabIndex = 17;
            // 
            // txt_empID
            // 
            this.txt_empID.Location = new System.Drawing.Point(69, 72);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(245, 31);
            this.txt_empID.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(69, 251);
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
            this.label6.Location = new System.Drawing.Point(69, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Worked Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(69, 144);
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
            this.label2.Location = new System.Drawing.Point(69, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_Printpage);
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
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1482, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_workDays;
        private System.Windows.Forms.TextBox txt_empName;
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.RichTextBox SalarySlip;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txt_empPos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}