namespace OnlineExaminationSystem.Administrator.Courses
{
    partial class FrmListCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListCourses));
            this.dgvCoursesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsCourses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCourseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewCourse = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesList)).BeginInit();
            this.cmsCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCoursesList
            // 
            this.dgvCoursesList.AllowUserToAddRows = false;
            this.dgvCoursesList.AllowUserToDeleteRows = false;
            this.dgvCoursesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvCoursesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoursesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCoursesList.ColumnHeadersHeight = 45;
            this.dgvCoursesList.ContextMenuStrip = this.cmsCourses;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoursesList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCoursesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvCoursesList.Location = new System.Drawing.Point(42, 269);
            this.dgvCoursesList.MultiSelect = false;
            this.dgvCoursesList.Name = "dgvCoursesList";
            this.dgvCoursesList.ReadOnly = true;
            this.dgvCoursesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoursesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCoursesList.RowHeadersVisible = false;
            this.dgvCoursesList.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dgvCoursesList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCoursesList.RowTemplate.Height = 50;
            this.dgvCoursesList.Size = new System.Drawing.Size(1126, 408);
            this.dgvCoursesList.TabIndex = 265;
            this.dgvCoursesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvCoursesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvCoursesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCoursesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCoursesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCoursesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCoursesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCoursesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvCoursesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvCoursesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCoursesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCoursesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCoursesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCoursesList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvCoursesList.ThemeStyle.ReadOnly = true;
            this.dgvCoursesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvCoursesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCoursesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCoursesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCoursesList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvCoursesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvCoursesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCoursesList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCoursesList_CellDoubleClick);
            this.dgvCoursesList.SelectionChanged += new System.EventHandler(this.DgvCoursesList_SelectionChanged);
            // 
            // cmsCourses
            // 
            this.cmsCourses.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmsCourses.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsCourses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCourseToolStripMenuItem,
            this.editCourseInformationToolStripMenuItem,
            this.showCourseDetailsToolStripMenuItem,
            this.deleteCourseToolStripMenuItem});
            this.cmsCourses.Name = "cbUsers";
            this.cmsCourses.Size = new System.Drawing.Size(263, 148);
            // 
            // addNewCourseToolStripMenuItem
            // 
            this.addNewCourseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.addNewCourseToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.addNewCourseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewCourseToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.add1;
            this.addNewCourseToolStripMenuItem.Name = "addNewCourseToolStripMenuItem";
            this.addNewCourseToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.addNewCourseToolStripMenuItem.Text = "Add New Course";
            this.addNewCourseToolStripMenuItem.Click += new System.EventHandler(this.AddNewCourseToolStripMenuItem_Click);
            // 
            // editCourseInformationToolStripMenuItem
            // 
            this.editCourseInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.editCourseInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.editCourseInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editCourseInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editCourseInformationToolStripMenuItem.Image")));
            this.editCourseInformationToolStripMenuItem.Name = "editCourseInformationToolStripMenuItem";
            this.editCourseInformationToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.editCourseInformationToolStripMenuItem.Text = "Edit Course Information";
            this.editCourseInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateCourseInfoToolStripMenuItem_Click);
            // 
            // showCourseDetailsToolStripMenuItem
            // 
            this.showCourseDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.showCourseDetailsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showCourseDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showCourseDetailsToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.show;
            this.showCourseDetailsToolStripMenuItem.Name = "showCourseDetailsToolStripMenuItem";
            this.showCourseDetailsToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.showCourseDetailsToolStripMenuItem.Text = "Show Course Details";
            this.showCourseDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowCourseDetailsToolStripMenuItem_Click);
            // 
            // deleteCourseToolStripMenuItem
            // 
            this.deleteCourseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.deleteCourseToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.deleteCourseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteCourseToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.delete;
            this.deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            this.deleteCourseToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.deleteCourseToolStripMenuItem.Text = "Delete Course";
            this.deleteCourseToolStripMenuItem.Click += new System.EventHandler(this.DeleteCourseToolStripMenuItem_Click);
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.BorderRadius = 22;
            this.btnAddNewCourse.CustomizableEdges.BottomLeft = false;
            this.btnAddNewCourse.CustomizableEdges.TopRight = false;
            this.btnAddNewCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCourse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btnAddNewCourse.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCourse.Image = global::OnlineExaminationSystem.Properties.Resources.add_folder;
            this.btnAddNewCourse.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewCourse.Location = new System.Drawing.Point(980, 192);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.Size = new System.Drawing.Size(188, 58);
            this.btnAddNewCourse.TabIndex = 266;
            this.btnAddNewCourse.Text = "Add Course";
            this.btnAddNewCourse.Click += new System.EventHandler(this.BtnAddNewCourse_Click);
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByOptions.BorderRadius = 22;
            this.cbFilterByOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbFilterByOptions.ForeColor = System.Drawing.Color.Black;
            this.cbFilterByOptions.ItemHeight = 35;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "None",
            "Course ID",
            "Name",
            "Duration",
            "Credits",
            "Prerequisites"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(142, 209);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(192, 41);
            this.cbFilterByOptions.TabIndex = 264;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.CbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(42, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 263;
            this.label2.Text = "Filter by :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(42, 92);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1126, 10);
            this.guna2Separator1.TabIndex = 262;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.lblTitle.Location = new System.Drawing.Point(553, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 31);
            this.lblTitle.TabIndex = 260;
            this.lblTitle.Text = "Manage Courses";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 22;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtFilterValue.Location = new System.Drawing.Point(364, 207);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(229, 43);
            this.txtFilterValue.TabIndex = 259;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.TxtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterValue_KeyPress);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.graduation_hat;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(485, 26);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.TabIndex = 261;
            // 
            // FrmListCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 702);
            this.Controls.Add(this.dgvCoursesList);
            this.Controls.Add(this.btnAddNewCourse);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListCourses";
            this.Load += new System.EventHandler(this.FrmListCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesList)).EndInit();
            this.cmsCourses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCoursesList;
        private System.Windows.Forms.ContextMenuStrip cmsCourses;
        private System.Windows.Forms.ToolStripMenuItem addNewCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCourseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCourseToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCourse;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}