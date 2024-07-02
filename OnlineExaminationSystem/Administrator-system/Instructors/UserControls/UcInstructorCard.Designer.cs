namespace OnlineExaminationSystem.Administrator.Instructors.UserControls
{
    partial class UcInstructorCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pnlExitInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpExitDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtInstructorID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPersonCard1 = new OnlineExaminationSystem.Administrator.People.UserControls.UcPersonCard();
            this.groupBox.SuspendLayout();
            this.pnlExitInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.BorderColor = System.Drawing.Color.Silver;
            this.groupBox.BorderRadius = 15;
            this.groupBox.Controls.Add(this.pnlExitInformation);
            this.groupBox.Controls.Add(this.txtMonthlySalary);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.dtpHireDate);
            this.groupBox.Controls.Add(this.txtInstructorID);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(0, 420);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1002, 226);
            this.groupBox.TabIndex = 4;
            this.groupBox.Text = "Work Information";
            this.groupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlExitInformation
            // 
            this.pnlExitInformation.Controls.Add(this.dtpExitDate);
            this.pnlExitInformation.Controls.Add(this.label3);
            this.pnlExitInformation.Location = new System.Drawing.Point(529, 107);
            this.pnlExitInformation.Name = "pnlExitInformation";
            this.pnlExitInformation.Size = new System.Drawing.Size(394, 92);
            this.pnlExitInformation.TabIndex = 278;
            // 
            // dtpExitDate
            // 
            this.dtpExitDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpExitDate.BorderRadius = 22;
            this.dtpExitDate.Checked = true;
            this.dtpExitDate.Enabled = false;
            this.dtpExitDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.dtpExitDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExitDate.ForeColor = System.Drawing.Color.Black;
            this.dtpExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExitDate.Location = new System.Drawing.Point(150, 21);
            this.dtpExitDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExitDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExitDate.Name = "dtpExitDate";
            this.dtpExitDate.Size = new System.Drawing.Size(229, 43);
            this.dtpExitDate.TabIndex = 274;
            this.dtpExitDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 275;
            this.label3.Text = "Exit Date :";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.BackColor = System.Drawing.Color.Transparent;
            this.txtMonthlySalary.BorderRadius = 22;
            this.txtMonthlySalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonthlySalary.DefaultText = "";
            this.txtMonthlySalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonthlySalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonthlySalary.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.txtMonthlySalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonthlySalary.Enabled = false;
            this.txtMonthlySalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonthlySalary.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtMonthlySalary.ForeColor = System.Drawing.Color.Black;
            this.txtMonthlySalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonthlySalary.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtMonthlySalary.Location = new System.Drawing.Point(678, 66);
            this.txtMonthlySalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.PasswordChar = '\0';
            this.txtMonthlySalary.PlaceholderText = "";
            this.txtMonthlySalary.ReadOnly = true;
            this.txtMonthlySalary.SelectedText = "";
            this.txtMonthlySalary.Size = new System.Drawing.Size(229, 43);
            this.txtMonthlySalary.TabIndex = 277;
            this.txtMonthlySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(537, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 276;
            this.label4.Text = "Monthly Salary :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 273;
            this.label2.Text = "Hiring Date :";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpHireDate.BorderRadius = 22;
            this.dtpHireDate.Checked = true;
            this.dtpHireDate.Enabled = false;
            this.dtpHireDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.dtpHireDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.ForeColor = System.Drawing.Color.Black;
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHireDate.Location = new System.Drawing.Point(174, 127);
            this.dtpHireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(229, 43);
            this.dtpHireDate.TabIndex = 272;
            this.dtpHireDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.BackColor = System.Drawing.Color.Transparent;
            this.txtInstructorID.BorderRadius = 22;
            this.txtInstructorID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstructorID.DefaultText = "N/A";
            this.txtInstructorID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.txtInstructorID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.Enabled = false;
            this.txtInstructorID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructorID.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtInstructorID.ForeColor = System.Drawing.Color.Red;
            this.txtInstructorID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructorID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtInstructorID.Location = new System.Drawing.Point(174, 66);
            this.txtInstructorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.PasswordChar = '\0';
            this.txtInstructorID.PlaceholderText = "";
            this.txtInstructorID.ReadOnly = true;
            this.txtInstructorID.SelectedText = "";
            this.txtInstructorID.Size = new System.Drawing.Size(229, 43);
            this.txtInstructorID.TabIndex = 271;
            this.txtInstructorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 270;
            this.label1.Text = "Instructor ID :";
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucPersonCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(1002, 405);
            this.ucPersonCard1.TabIndex = 3;
            // 
            // UcInstructorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ucPersonCard1);
            this.Name = "UcInstructorCard";
            this.Size = new System.Drawing.Size(1002, 646);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.pnlExitInformation.ResumeLayout(false);
            this.pnlExitInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2TextBox txtMonthlySalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExitDate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHireDate;
        private Guna.UI2.WinForms.Guna2TextBox txtInstructorID;
        private System.Windows.Forms.Label label1;
        private People.UserControls.UcPersonCard ucPersonCard1;
        private Guna.UI2.WinForms.Guna2Panel pnlExitInformation;
    }
}
