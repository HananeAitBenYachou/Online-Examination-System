namespace OnlineExaminationSystem.Administrator.Instructors.InstructorCourses
{
    partial class FrmShowInstructorCourses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tcInstructorInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpInstructorInfo = new System.Windows.Forms.TabPage();
            this.tpCoursesInfo = new System.Windows.Forms.TabPage();
            this.ucInstructorCard1 = new OnlineExaminationSystem.Administrator.Instructors.UserControls.UcInstructorCard();
            this.dgvInstructorCoursesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.tcInstructorInfo.SuspendLayout();
            this.tpInstructorInfo.SuspendLayout();
            this.tpCoursesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorCoursesList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2ImageButton1);
            this.guna2GradientPanel1.Controls.Add(this.lblTitle);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(143)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1021, 88);
            this.guna2GradientPanel1.TabIndex = 284;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(437, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Instructor Courses";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.book;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(380, 13);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Size = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 32;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tcInstructorInfo
            // 
            this.tcInstructorInfo.Controls.Add(this.tpInstructorInfo);
            this.tcInstructorInfo.Controls.Add(this.tpCoursesInfo);
            this.tcInstructorInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcInstructorInfo.ItemSize = new System.Drawing.Size(190, 60);
            this.tcInstructorInfo.Location = new System.Drawing.Point(0, 88);
            this.tcInstructorInfo.Name = "tcInstructorInfo";
            this.tcInstructorInfo.SelectedIndex = 0;
            this.tcInstructorInfo.Size = new System.Drawing.Size(1021, 730);
            this.tcInstructorInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcInstructorInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.tcInstructorInfo.TabButtonHoverState.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcInstructorInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcInstructorInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.tcInstructorInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcInstructorInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.tcInstructorInfo.TabButtonIdleState.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.tcInstructorInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcInstructorInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.tcInstructorInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcInstructorInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.tcInstructorInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.tcInstructorInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcInstructorInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.tcInstructorInfo.TabButtonSize = new System.Drawing.Size(190, 60);
            this.tcInstructorInfo.TabIndex = 288;
            this.tcInstructorInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.tcInstructorInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpInstructorInfo
            // 
            this.tpInstructorInfo.Controls.Add(this.ucInstructorCard1);
            this.tpInstructorInfo.Location = new System.Drawing.Point(4, 64);
            this.tpInstructorInfo.Name = "tpInstructorInfo";
            this.tpInstructorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstructorInfo.Size = new System.Drawing.Size(1013, 662);
            this.tpInstructorInfo.TabIndex = 0;
            this.tpInstructorInfo.Text = "Instructor Info";
            this.tpInstructorInfo.UseVisualStyleBackColor = true;
            // 
            // tpCoursesInfo
            // 
            this.tpCoursesInfo.Controls.Add(this.dgvInstructorCoursesList);
            this.tpCoursesInfo.Location = new System.Drawing.Point(4, 64);
            this.tpCoursesInfo.Name = "tpCoursesInfo";
            this.tpCoursesInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCoursesInfo.Size = new System.Drawing.Size(1013, 662);
            this.tpCoursesInfo.TabIndex = 2;
            this.tpCoursesInfo.Text = "Courses";
            this.tpCoursesInfo.UseVisualStyleBackColor = true;
            // 
            // ucInstructorCard1
            // 
            this.ucInstructorCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucInstructorCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucInstructorCard1.Location = new System.Drawing.Point(3, 3);
            this.ucInstructorCard1.Name = "ucInstructorCard1";
            this.ucInstructorCard1.Size = new System.Drawing.Size(1007, 646);
            this.ucInstructorCard1.TabIndex = 0;
            // 
            // dgvInstructorCoursesList
            // 
            this.dgvInstructorCoursesList.AllowUserToAddRows = false;
            this.dgvInstructorCoursesList.AllowUserToDeleteRows = false;
            this.dgvInstructorCoursesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorCoursesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructorCoursesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInstructorCoursesList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstructorCoursesList.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInstructorCoursesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvInstructorCoursesList.Location = new System.Drawing.Point(42, 149);
            this.dgvInstructorCoursesList.MultiSelect = false;
            this.dgvInstructorCoursesList.Name = "dgvInstructorCoursesList";
            this.dgvInstructorCoursesList.ReadOnly = true;
            this.dgvInstructorCoursesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructorCoursesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInstructorCoursesList.RowHeadersVisible = false;
            this.dgvInstructorCoursesList.RowHeadersWidth = 51;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorCoursesList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvInstructorCoursesList.RowTemplate.Height = 50;
            this.dgvInstructorCoursesList.Size = new System.Drawing.Size(939, 394);
            this.dgvInstructorCoursesList.TabIndex = 267;
            this.dgvInstructorCoursesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvInstructorCoursesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvInstructorCoursesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInstructorCoursesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorCoursesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInstructorCoursesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInstructorCoursesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInstructorCoursesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvInstructorCoursesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvInstructorCoursesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInstructorCoursesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvInstructorCoursesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorCoursesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInstructorCoursesList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvInstructorCoursesList.ThemeStyle.ReadOnly = true;
            this.dgvInstructorCoursesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvInstructorCoursesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInstructorCoursesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvInstructorCoursesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorCoursesList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvInstructorCoursesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvInstructorCoursesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 22;
            this.btnClose.CustomizableEdges.BottomLeft = false;
            this.btnClose.CustomizableEdges.TopRight = false;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.btnClose.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::OnlineExaminationSystem.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(867, 824);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 58);
            this.btnClose.TabIndex = 289;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmShowInstructorCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 892);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcInstructorInfo);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShowInstructorCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowInstructorCourses";
            this.Load += new System.EventHandler(this.FrmShowInstructorCourses_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcInstructorInfo.ResumeLayout(false);
            this.tpInstructorInfo.ResumeLayout(false);
            this.tpCoursesInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorCoursesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TabControl tcInstructorInfo;
        private System.Windows.Forms.TabPage tpInstructorInfo;
        private UserControls.UcInstructorCard ucInstructorCard1;
        private System.Windows.Forms.TabPage tpCoursesInfo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInstructorCoursesList;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}