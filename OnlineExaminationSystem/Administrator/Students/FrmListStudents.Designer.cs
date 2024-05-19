namespace OnlineExaminationSystem.Administrator.Students
{
    partial class FrmAddUpdateInstrcutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdateInstrcutor));
            this.dgvStudentsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsStudents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cbTemp = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).BeginInit();
            this.cmsStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentsList
            // 
            this.dgvStudentsList.AllowUserToAddRows = false;
            this.dgvStudentsList.AllowUserToDeleteRows = false;
            this.dgvStudentsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvStudentsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentsList.ColumnHeadersHeight = 45;
            this.dgvStudentsList.ContextMenuStrip = this.cmsStudents;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvStudentsList.Location = new System.Drawing.Point(42, 253);
            this.dgvStudentsList.MultiSelect = false;
            this.dgvStudentsList.Name = "dgvStudentsList";
            this.dgvStudentsList.ReadOnly = true;
            this.dgvStudentsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudentsList.RowHeadersVisible = false;
            this.dgvStudentsList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvStudentsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentsList.RowTemplate.Height = 50;
            this.dgvStudentsList.Size = new System.Drawing.Size(1126, 408);
            this.dgvStudentsList.TabIndex = 265;
            this.dgvStudentsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvStudentsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvStudentsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStudentsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudentsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudentsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudentsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvStudentsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvStudentsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudentsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvStudentsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudentsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudentsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStudentsList.ThemeStyle.ReadOnly = true;
            this.dgvStudentsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvStudentsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudentsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvStudentsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudentsList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvStudentsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvStudentsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStudentsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentsList_CellDoubleClick);
            this.dgvStudentsList.SelectionChanged += new System.EventHandler(this.DgvStudentsList_SelectionChanged);
            // 
            // cmsStudents
            // 
            this.cmsStudents.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmsStudents.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.editStudentInformationToolStripMenuItem,
            this.showStudentDetailsToolStripMenuItem,
            this.deleteStudentToolStripMenuItem});
            this.cmsStudents.Name = "cbUsers";
            this.cmsStudents.Size = new System.Drawing.Size(270, 148);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.addNewStudentToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.addNewStudentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewStudentToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.add1;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(269, 36);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.AddNewStudentToolStripMenuItem_Click);
            // 
            // editStudentInformationToolStripMenuItem
            // 
            this.editStudentInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.editStudentInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.editStudentInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editStudentInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editStudentInformationToolStripMenuItem.Image")));
            this.editStudentInformationToolStripMenuItem.Name = "editStudentInformationToolStripMenuItem";
            this.editStudentInformationToolStripMenuItem.Size = new System.Drawing.Size(269, 36);
            this.editStudentInformationToolStripMenuItem.Text = "Edit Student Information";
            this.editStudentInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateStudentInfoToolStripMenuItem_Click);
            // 
            // showStudentDetailsToolStripMenuItem
            // 
            this.showStudentDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.showStudentDetailsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showStudentDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showStudentDetailsToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.show;
            this.showStudentDetailsToolStripMenuItem.Name = "showStudentDetailsToolStripMenuItem";
            this.showStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(269, 36);
            this.showStudentDetailsToolStripMenuItem.Text = "Show Student Details";
            this.showStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowStudentDetailsToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.deleteStudentToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.deleteStudentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteStudentToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.delete;
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(269, 36);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.DeleteTrackToolStripMenuItem_Click);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.BorderRadius = 22;
            this.btnAddNewStudent.CustomizableEdges.BottomLeft = false;
            this.btnAddNewStudent.CustomizableEdges.TopRight = false;
            this.btnAddNewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btnAddNewStudent.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddNewStudent.Image = global::OnlineExaminationSystem.Properties.Resources.add_folder;
            this.btnAddNewStudent.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewStudent.Location = new System.Drawing.Point(980, 176);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(188, 58);
            this.btnAddNewStudent.TabIndex = 266;
            this.btnAddNewStudent.Text = "Add Student";
            this.btnAddNewStudent.Click += new System.EventHandler(this.BtnAddNewStudent_Click);
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
            "Student ID",
            "Person ID",
            "National No",
            "Full Name",
            "Gender",
            "Track",
            "Status"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(142, 193);
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
            this.label2.Location = new System.Drawing.Point(42, 205);
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
            this.guna2Separator1.Location = new System.Drawing.Point(42, 76);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1126, 10);
            this.guna2Separator1.TabIndex = 262;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.lblTitle.Location = new System.Drawing.Point(553, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 31);
            this.lblTitle.TabIndex = 260;
            this.lblTitle.Text = "Manage Students";
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
            this.txtFilterValue.Location = new System.Drawing.Point(365, 191);
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
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.graduating_student;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(485, 10);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.TabIndex = 261;
            // 
            // cbTemp
            // 
            this.cbTemp.BackColor = System.Drawing.Color.Transparent;
            this.cbTemp.BorderRadius = 22;
            this.cbTemp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTemp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTemp.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbTemp.ForeColor = System.Drawing.Color.Black;
            this.cbTemp.ItemHeight = 35;
            this.cbTemp.Location = new System.Drawing.Point(365, 193);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(192, 41);
            this.cbTemp.TabIndex = 267;
            this.cbTemp.Visible = false;
            this.cbTemp.SelectedIndexChanged += new System.EventHandler(this.CbTemp_SelectedIndexChanged);
            // 
            // FrmListStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 702);
            this.Controls.Add(this.cbTemp);
            this.Controls.Add(this.dgvStudentsList);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListStudents";
            this.Load += new System.EventHandler(this.FrmListStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).EndInit();
            this.cmsStudents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvStudentsList;
        private System.Windows.Forms.ContextMenuStrip cmsStudents;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddNewStudent;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTemp;
    }
}