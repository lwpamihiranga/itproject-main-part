﻿namespace itproject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.buttonViewAttendance = new System.Windows.Forms.Button();
            this.buttonLoan = new System.Windows.Forms.Button();
            this.buttonStocks = new System.Windows.Forms.Button();
            this.buttonProjectsAndTasks = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.buttonLeaveManagement = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeDetailsUserControl1 = new itproject.EmployeeDetailsUserControl();
         
            this.customers1 = new itproject.Customers();
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DimGray;
            this.sidePanel.Controls.Add(this.buttonViewAttendance);
            this.sidePanel.Controls.Add(this.buttonLoan);
            this.sidePanel.Controls.Add(this.buttonStocks);
            this.sidePanel.Controls.Add(this.buttonProjectsAndTasks);
            this.sidePanel.Controls.Add(this.buttonCustomers);
            this.sidePanel.Controls.Add(this.buttonPayroll);
            this.sidePanel.Controls.Add(this.buttonLeaveManagement);
            this.sidePanel.Controls.Add(this.buttonEmployees);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(335, 878);
            this.sidePanel.TabIndex = 0;
            // 
            // buttonViewAttendance
            // 
            this.buttonViewAttendance.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewAttendance.Image")));
            this.buttonViewAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewAttendance.Location = new System.Drawing.Point(23, 768);
            this.buttonViewAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewAttendance.Name = "buttonViewAttendance";
            this.buttonViewAttendance.Size = new System.Drawing.Size(285, 83);
            this.buttonViewAttendance.TabIndex = 11;
            this.buttonViewAttendance.Text = "Attendance";
            this.buttonViewAttendance.UseVisualStyleBackColor = true;
            this.buttonViewAttendance.Click += new System.EventHandler(this.ButtonViewAttendance_Click);
            // 
            // buttonLoan
            // 
            this.buttonLoan.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoan.Image")));
            this.buttonLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoan.Location = new System.Drawing.Point(23, 343);
            this.buttonLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoan.Name = "buttonLoan";
            this.buttonLoan.Size = new System.Drawing.Size(285, 85);
            this.buttonLoan.TabIndex = 10;
            this.buttonLoan.Text = "Loan";
            this.buttonLoan.UseVisualStyleBackColor = true;
            this.buttonLoan.Click += new System.EventHandler(this.ButtonLoan_Click);
            // 
            // buttonStocks
            // 
            this.buttonStocks.Image = ((System.Drawing.Image)(resources.GetObject("buttonStocks.Image")));
            this.buttonStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStocks.Location = new System.Drawing.Point(23, 664);
            this.buttonStocks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStocks.Name = "buttonStocks";
            this.buttonStocks.Size = new System.Drawing.Size(285, 83);
            this.buttonStocks.TabIndex = 9;
            this.buttonStocks.Text = "Stocks";
            this.buttonStocks.UseVisualStyleBackColor = true;
            this.buttonStocks.Click += new System.EventHandler(this.ButtonStocks_Click);
            // 
            // buttonProjectsAndTasks
            // 
            this.buttonProjectsAndTasks.Image = ((System.Drawing.Image)(resources.GetObject("buttonProjectsAndTasks.Image")));
            this.buttonProjectsAndTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjectsAndTasks.Location = new System.Drawing.Point(23, 550);
            this.buttonProjectsAndTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProjectsAndTasks.Name = "buttonProjectsAndTasks";
            this.buttonProjectsAndTasks.Size = new System.Drawing.Size(285, 83);
            this.buttonProjectsAndTasks.TabIndex = 4;
            this.buttonProjectsAndTasks.Text = "Projects and Tasks";
            this.buttonProjectsAndTasks.UseVisualStyleBackColor = true;
            this.buttonProjectsAndTasks.Click += new System.EventHandler(this.ButtonProjectsAndTasks_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomers.Image")));
            this.buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.Location = new System.Drawing.Point(23, 444);
            this.buttonCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(285, 83);
            this.buttonCustomers.TabIndex = 8;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.ButtonCustomers_Click);
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.Image = ((System.Drawing.Image)(resources.GetObject("buttonPayroll.Image")));
            this.buttonPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayroll.Location = new System.Drawing.Point(23, 239);
            this.buttonPayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Size = new System.Drawing.Size(285, 85);
            this.buttonPayroll.TabIndex = 7;
            this.buttonPayroll.Text = "Payroll";
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.ButtonPayroll_Click);
            // 
            // buttonLeaveManagement
            // 
            this.buttonLeaveManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaveManagement.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeaveManagement.Image")));
            this.buttonLeaveManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeaveManagement.Location = new System.Drawing.Point(23, 132);
            this.buttonLeaveManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLeaveManagement.Name = "buttonLeaveManagement";
            this.buttonLeaveManagement.Size = new System.Drawing.Size(285, 85);
            this.buttonLeaveManagement.TabIndex = 6;
            this.buttonLeaveManagement.Text = "Leave Management";
            this.buttonLeaveManagement.UseVisualStyleBackColor = true;
            this.buttonLeaveManagement.Click += new System.EventHandler(this.ButtonLeaveManagement_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployees.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployees.Image")));
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(23, 29);
            this.buttonEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(285, 85);
            this.buttonEmployees.TabIndex = 3;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.ButtonEmployees_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(335, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1168, 10);
            this.topPanel.TabIndex = 1;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightBlue;
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Location = new System.Drawing.Point(351, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(165, 217);
            this.logoPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // employeeDetailsUserControl1
            // 
            this.employeeDetailsUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeeDetailsUserControl1.BackgroundImage")));
            this.employeeDetailsUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeeDetailsUserControl1.ForeColor = System.Drawing.Color.White;
            this.employeeDetailsUserControl1.Location = new System.Drawing.Point(351, 224);
            this.employeeDetailsUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.employeeDetailsUserControl1.Name = "employeeDetailsUserControl1";
            this.employeeDetailsUserControl1.Size = new System.Drawing.Size(1043, 565);
            this.employeeDetailsUserControl1.TabIndex = 3;
            // 
            // patternAndStockManagement1
            // 
         
            // 
            // customers1
            // 
            this.customers1.Location = new System.Drawing.Point(335, 222);
            this.customers1.MinimumSize = new System.Drawing.Size(1099, 569);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(1156, 656);
            this.customers1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 878);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.employeeDetailsUserControl1);
           
            this.Controls.Add(this.customers1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button buttonStocks;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonProjectsAndTasks;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonPayroll;
        private System.Windows.Forms.Button buttonLeaveManagement;
        private EmployeeDetailsUserControl employeeDetailsUserControl1;
        private System.Windows.Forms.Button buttonLoan;
    
        private Customers customers1;
        private System.Windows.Forms.Button buttonViewAttendance;
    }
}

