namespace OnlineExaminationSystem.Administrator.Students.UserControls
{
    partial class UcStudentCard
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
            this.ucPersonCard1 = new OnlineExaminationSystem.Administrator.People.UserControls.UcPersonCard();
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTrackName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpGraduationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtStudentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucPersonCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(1002, 405);
            this.ucPersonCard1.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.BorderColor = System.Drawing.Color.Silver;
            this.groupBox.BorderRadius = 15;
            this.groupBox.Controls.Add(this.txtTrackName);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.dtpGraduationDate);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.dtpStartDate);
            this.groupBox.Controls.Add(this.txtStudentID);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.FillColor = System.Drawing.SystemColors.Control;
            this.groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(0, 420);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1002, 226);
            this.groupBox.TabIndex = 2;
            this.groupBox.Text = "Academic Information";
            this.groupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTrackName
            // 
            this.txtTrackName.BackColor = System.Drawing.Color.Transparent;
            this.txtTrackName.BorderRadius = 22;
            this.txtTrackName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrackName.DefaultText = "";
            this.txtTrackName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrackName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrackName.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.txtTrackName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrackName.Enabled = false;
            this.txtTrackName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackName.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtTrackName.ForeColor = System.Drawing.Color.Black;
            this.txtTrackName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackName.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtTrackName.Location = new System.Drawing.Point(678, 66);
            this.txtTrackName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.PasswordChar = '\0';
            this.txtTrackName.PlaceholderText = "";
            this.txtTrackName.ReadOnly = true;
            this.txtTrackName.SelectedText = "";
            this.txtTrackName.Size = new System.Drawing.Size(229, 43);
            this.txtTrackName.TabIndex = 277;
            this.txtTrackName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(521, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 276;
            this.label4.Text = "Academic Track :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(521, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 275;
            this.label3.Text = "Graduation Date :";
            // 
            // dtpGraduationDate
            // 
            this.dtpGraduationDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpGraduationDate.BorderRadius = 22;
            this.dtpGraduationDate.Checked = true;
            this.dtpGraduationDate.Enabled = false;
            this.dtpGraduationDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.dtpGraduationDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGraduationDate.ForeColor = System.Drawing.Color.Black;
            this.dtpGraduationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpGraduationDate.Location = new System.Drawing.Point(678, 127);
            this.dtpGraduationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpGraduationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpGraduationDate.Name = "dtpGraduationDate";
            this.dtpGraduationDate.Size = new System.Drawing.Size(229, 43);
            this.dtpGraduationDate.TabIndex = 274;
            this.dtpGraduationDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 273;
            this.label2.Text = "Start Date :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpStartDate.BorderRadius = 22;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.dtpStartDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.ForeColor = System.Drawing.Color.Black;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(174, 127);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(229, 43);
            this.dtpStartDate.TabIndex = 272;
            this.dtpStartDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentID.BorderRadius = 22;
            this.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentID.DefaultText = "N/A";
            this.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentID.Enabled = false;
            this.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentID.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtStudentID.ForeColor = System.Drawing.Color.Red;
            this.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtStudentID.Location = new System.Drawing.Point(174, 66);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.PlaceholderText = "";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.Size = new System.Drawing.Size(229, 43);
            this.txtStudentID.TabIndex = 271;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 270;
            this.label1.Text = "Student ID :";
            // 
            // UcStudentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ucPersonCard1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "UcStudentCard";
            this.Size = new System.Drawing.Size(1002, 646);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.UserControls.UcPersonCard ucPersonCard1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpGraduationDate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2TextBox txtTrackName;
        private System.Windows.Forms.Label label4;
    }
}
