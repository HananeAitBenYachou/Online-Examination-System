namespace OnlineExaminationSystem.Administrator.Instructors
{
    partial class FrmListInstructors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListInstructors));
            this.dgvInstructorsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsInstructors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInstructorInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInstructorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTemp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewInstructor = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorsList)).BeginInit();
            this.cmsInstructors.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInstructorsList
            // 
            this.dgvInstructorsList.AllowUserToAddRows = false;
            this.dgvInstructorsList.AllowUserToDeleteRows = false;
            this.dgvInstructorsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInstructorsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInstructorsList.ColumnHeadersHeight = 45;
            this.dgvInstructorsList.ContextMenuStrip = this.cmsInstructors;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstructorsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInstructorsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvInstructorsList.Location = new System.Drawing.Point(42, 253);
            this.dgvInstructorsList.MultiSelect = false;
            this.dgvInstructorsList.Name = "dgvInstructorsList";
            this.dgvInstructorsList.ReadOnly = true;
            this.dgvInstructorsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructorsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInstructorsList.RowHeadersVisible = false;
            this.dgvInstructorsList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInstructorsList.RowTemplate.Height = 50;
            this.dgvInstructorsList.Size = new System.Drawing.Size(1126, 408);
            this.dgvInstructorsList.TabIndex = 274;
            this.dgvInstructorsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvInstructorsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvInstructorsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInstructorsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInstructorsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInstructorsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInstructorsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvInstructorsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvInstructorsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInstructorsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvInstructorsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInstructorsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvInstructorsList.ThemeStyle.ReadOnly = true;
            this.dgvInstructorsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvInstructorsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInstructorsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvInstructorsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInstructorsList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvInstructorsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvInstructorsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInstructorsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInstructorsList_CellDoubleClick);
            this.dgvInstructorsList.SelectionChanged += new System.EventHandler(this.DgvInstructorsList_SelectionChanged);
            // 
            // cmsInstructors
            // 
            this.cmsInstructors.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmsInstructors.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsInstructors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewInstructorToolStripMenuItem,
            this.editInstructorInformationToolStripMenuItem,
            this.showInstructorDetailsToolStripMenuItem,
            this.deleteInstructorToolStripMenuItem});
            this.cmsInstructors.Name = "cbUsers";
            this.cmsInstructors.Size = new System.Drawing.Size(284, 148);
            // 
            // addNewInstructorToolStripMenuItem
            // 
            this.addNewInstructorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.addNewInstructorToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.addNewInstructorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewInstructorToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.add1;
            this.addNewInstructorToolStripMenuItem.Name = "addNewInstructorToolStripMenuItem";
            this.addNewInstructorToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.addNewInstructorToolStripMenuItem.Text = "Add New Instructor";
            this.addNewInstructorToolStripMenuItem.Click += new System.EventHandler(this.AddNewInstructorToolStripMenuItem_Click);
            // 
            // editInstructorInformationToolStripMenuItem
            // 
            this.editInstructorInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.editInstructorInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.editInstructorInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editInstructorInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editInstructorInformationToolStripMenuItem.Image")));
            this.editInstructorInformationToolStripMenuItem.Name = "editInstructorInformationToolStripMenuItem";
            this.editInstructorInformationToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.editInstructorInformationToolStripMenuItem.Text = "Edit Instructor Information";
            this.editInstructorInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateInstructorInfoToolStripMenuItem_Click);
            // 
            // showInstructorDetailsToolStripMenuItem
            // 
            this.showInstructorDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.showInstructorDetailsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showInstructorDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showInstructorDetailsToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.show;
            this.showInstructorDetailsToolStripMenuItem.Name = "showInstructorDetailsToolStripMenuItem";
            this.showInstructorDetailsToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.showInstructorDetailsToolStripMenuItem.Text = "Show Instructor Details";
            this.showInstructorDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowInstructorDetailsToolStripMenuItem_Click);
            // 
            // deleteInstructorToolStripMenuItem
            // 
            this.deleteInstructorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.deleteInstructorToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.deleteInstructorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteInstructorToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.delete;
            this.deleteInstructorToolStripMenuItem.Name = "deleteInstructorToolStripMenuItem";
            this.deleteInstructorToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.deleteInstructorToolStripMenuItem.Text = "Delete Instructor";
            this.deleteInstructorToolStripMenuItem.Click += new System.EventHandler(this.DeleteInstructorToolStripMenuItem_Click);
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
            this.cbTemp.TabIndex = 276;
            this.cbTemp.Visible = false;
            this.cbTemp.SelectedIndexChanged += new System.EventHandler(this.CbTemp_SelectedIndexChanged);
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
            "Instructor ID",
            "Person ID",
            "National No",
            "Full Name",
            "Gender",
            "Status"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(142, 193);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(192, 41);
            this.cbFilterByOptions.TabIndex = 273;
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
            this.label2.TabIndex = 272;
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
            this.guna2Separator1.TabIndex = 271;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.lblTitle.Location = new System.Drawing.Point(553, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 31);
            this.lblTitle.TabIndex = 269;
            this.lblTitle.Text = "Manage Instructors";
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
            this.txtFilterValue.TabIndex = 268;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.TxtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterValue_KeyPress);
            // 
            // btnAddNewInstructor
            // 
            this.btnAddNewInstructor.BorderRadius = 22;
            this.btnAddNewInstructor.CustomizableEdges.BottomLeft = false;
            this.btnAddNewInstructor.CustomizableEdges.TopRight = false;
            this.btnAddNewInstructor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewInstructor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewInstructor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewInstructor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewInstructor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btnAddNewInstructor.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewInstructor.ForeColor = System.Drawing.Color.White;
            this.btnAddNewInstructor.Image = global::OnlineExaminationSystem.Properties.Resources.add_folder;
            this.btnAddNewInstructor.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewInstructor.Location = new System.Drawing.Point(980, 176);
            this.btnAddNewInstructor.Name = "btnAddNewInstructor";
            this.btnAddNewInstructor.Size = new System.Drawing.Size(188, 58);
            this.btnAddNewInstructor.TabIndex = 275;
            this.btnAddNewInstructor.Text = "Add Instructor";
            this.btnAddNewInstructor.Click += new System.EventHandler(this.BtnAddNewInstructor_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.teacher__1_;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(488, 4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.TabIndex = 270;
            // 
            // FrmListInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 702);
            this.Controls.Add(this.dgvInstructorsList);
            this.Controls.Add(this.cbTemp);
            this.Controls.Add(this.btnAddNewInstructor);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListInstructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListInstructors";
            this.Load += new System.EventHandler(this.FrmListInstructors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorsList)).EndInit();
            this.cmsInstructors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvInstructorsList;
        private System.Windows.Forms.ContextMenuStrip cmsInstructors;
        private System.Windows.Forms.ToolStripMenuItem addNewInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInstructorInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInstructorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInstructorToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbTemp;
        private Guna.UI2.WinForms.Guna2Button btnAddNewInstructor;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}