namespace OnlineExaminationSystem.Instructor_system.Exams
{
    partial class FrmListExams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListExams));
            this.dgvExamsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsExams = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExamInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showExamDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTemp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterByExams = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewExam = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamsList)).BeginInit();
            this.cmsExams.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExamsList
            // 
            this.dgvExamsList.AllowUserToAddRows = false;
            this.dgvExamsList.AllowUserToDeleteRows = false;
            this.dgvExamsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvExamsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExamsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvExamsList.ColumnHeadersHeight = 45;
            this.dgvExamsList.ContextMenuStrip = this.cmsExams;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamsList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExamsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvExamsList.Location = new System.Drawing.Point(42, 252);
            this.dgvExamsList.MultiSelect = false;
            this.dgvExamsList.Name = "dgvExamsList";
            this.dgvExamsList.ReadOnly = true;
            this.dgvExamsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvExamsList.RowHeadersVisible = false;
            this.dgvExamsList.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dgvExamsList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvExamsList.RowTemplate.Height = 50;
            this.dgvExamsList.Size = new System.Drawing.Size(1126, 408);
            this.dgvExamsList.TabIndex = 283;
            this.dgvExamsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvExamsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvExamsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExamsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExamsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExamsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExamsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvExamsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvExamsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvExamsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExamsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvExamsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExamsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExamsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvExamsList.ThemeStyle.ReadOnly = true;
            this.dgvExamsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvExamsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExamsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvExamsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExamsList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvExamsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvExamsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExamsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExamsList_CellDoubleClick);
            this.dgvExamsList.SelectionChanged += new System.EventHandler(this.DgvExamsList_SelectionChanged);
            // 
            // cmsExams
            // 
            this.cmsExams.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmsExams.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsExams.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewExamToolStripMenuItem,
            this.editExamInformationToolStripMenuItem,
            this.showExamDetailsToolStripMenuItem,
            this.deleteExamToolStripMenuItem});
            this.cmsExams.Name = "cbUsers";
            this.cmsExams.Size = new System.Drawing.Size(252, 148);
            // 
            // addNewExamToolStripMenuItem
            // 
            this.addNewExamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.addNewExamToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.addNewExamToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewExamToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.add1;
            this.addNewExamToolStripMenuItem.Name = "addNewExamToolStripMenuItem";
            this.addNewExamToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.addNewExamToolStripMenuItem.Text = "Add New Exam";
            this.addNewExamToolStripMenuItem.Click += new System.EventHandler(this.AddNewExamToolStripMenuItem_Click);
            // 
            // editExamInformationToolStripMenuItem
            // 
            this.editExamInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.editExamInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.editExamInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editExamInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editExamInformationToolStripMenuItem.Image")));
            this.editExamInformationToolStripMenuItem.Name = "editExamInformationToolStripMenuItem";
            this.editExamInformationToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.editExamInformationToolStripMenuItem.Text = "Edit Exam Information";
            this.editExamInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateExamInfoToolStripMenuItem_Click);
            // 
            // showExamDetailsToolStripMenuItem
            // 
            this.showExamDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.showExamDetailsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showExamDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showExamDetailsToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.show;
            this.showExamDetailsToolStripMenuItem.Name = "showExamDetailsToolStripMenuItem";
            this.showExamDetailsToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.showExamDetailsToolStripMenuItem.Text = "Show Exam Details";
            this.showExamDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowExamDetailsToolStripMenuItem_Click);
            // 
            // deleteExamToolStripMenuItem
            // 
            this.deleteExamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.deleteExamToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.deleteExamToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteExamToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.delete;
            this.deleteExamToolStripMenuItem.Name = "deleteExamToolStripMenuItem";
            this.deleteExamToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.deleteExamToolStripMenuItem.Text = "Delete Exam";
            this.deleteExamToolStripMenuItem.Click += new System.EventHandler(this.DeleteExamToolStripMenuItem_Click);
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
            this.cbTemp.Location = new System.Drawing.Point(365, 192);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(192, 41);
            this.cbTemp.TabIndex = 285;
            this.cbTemp.Visible = false;
            this.cbTemp.SelectedIndexChanged += new System.EventHandler(this.CbTemp_SelectedIndexChanged);
            // 
            // cbFilterByExams
            // 
            this.cbFilterByExams.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByExams.BorderRadius = 22;
            this.cbFilterByExams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByExams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByExams.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByExams.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByExams.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbFilterByExams.ForeColor = System.Drawing.Color.Black;
            this.cbFilterByExams.ItemHeight = 35;
            this.cbFilterByExams.Items.AddRange(new object[] {
            "None",
            "Exam ID",
            "Course Name",
            "State",
            "Status"});
            this.cbFilterByExams.Location = new System.Drawing.Point(142, 192);
            this.cbFilterByExams.Name = "cbFilterByExams";
            this.cbFilterByExams.Size = new System.Drawing.Size(192, 41);
            this.cbFilterByExams.TabIndex = 282;
            this.cbFilterByExams.SelectedIndexChanged += new System.EventHandler(this.CbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(42, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 281;
            this.label2.Text = "Filter by :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(42, 75);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1126, 10);
            this.guna2Separator1.TabIndex = 280;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.lblTitle.Location = new System.Drawing.Point(553, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 31);
            this.lblTitle.TabIndex = 278;
            this.lblTitle.Text = "Manage Exams";
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
            this.txtFilterValue.Location = new System.Drawing.Point(365, 190);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(229, 43);
            this.txtFilterValue.TabIndex = 277;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterValue_KeyPress);
            // 
            // btnAddNewExam
            // 
            this.btnAddNewExam.BorderRadius = 22;
            this.btnAddNewExam.CustomizableEdges.BottomLeft = false;
            this.btnAddNewExam.CustomizableEdges.TopRight = false;
            this.btnAddNewExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewExam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btnAddNewExam.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewExam.ForeColor = System.Drawing.Color.White;
            this.btnAddNewExam.Image = global::OnlineExaminationSystem.Properties.Resources.add_folder;
            this.btnAddNewExam.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewExam.Location = new System.Drawing.Point(980, 175);
            this.btnAddNewExam.Name = "btnAddNewExam";
            this.btnAddNewExam.Size = new System.Drawing.Size(188, 58);
            this.btnAddNewExam.TabIndex = 284;
            this.btnAddNewExam.Text = "Add Exam";
            this.btnAddNewExam.Click += new System.EventHandler(this.BtnAddNewExam_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.exam1;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(485, 9);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.TabIndex = 279;
            // 
            // FrmListExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 702);
            this.Controls.Add(this.dgvExamsList);
            this.Controls.Add(this.cbTemp);
            this.Controls.Add(this.cbFilterByExams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.btnAddNewExam);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListExams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListExams";
            this.Load += new System.EventHandler(this.FrmListExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamsList)).EndInit();
            this.cmsExams.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvExamsList;
        private System.Windows.Forms.ContextMenuStrip cmsExams;
        private System.Windows.Forms.ToolStripMenuItem addNewExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExamInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showExamDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteExamToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbTemp;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByExams;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2Button btnAddNewExam;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}