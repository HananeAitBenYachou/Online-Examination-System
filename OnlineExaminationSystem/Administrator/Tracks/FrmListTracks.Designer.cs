namespace OnlineExaminationSystem.Administrator.Tracks
{
    partial class FrmListTracks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListTracks));
            this.dgvTracksList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsTracks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTrackInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTrackDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewTrack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.showTrackCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracksList)).BeginInit();
            this.cmsTracks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTracksList
            // 
            this.dgvTracksList.AllowUserToAddRows = false;
            this.dgvTracksList.AllowUserToDeleteRows = false;
            this.dgvTracksList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvTracksList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTracksList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTracksList.ColumnHeadersHeight = 45;
            this.dgvTracksList.ContextMenuStrip = this.cmsTracks;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTracksList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTracksList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvTracksList.Location = new System.Drawing.Point(42, 262);
            this.dgvTracksList.MultiSelect = false;
            this.dgvTracksList.Name = "dgvTracksList";
            this.dgvTracksList.ReadOnly = true;
            this.dgvTracksList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTracksList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTracksList.RowHeadersVisible = false;
            this.dgvTracksList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvTracksList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTracksList.RowTemplate.Height = 50;
            this.dgvTracksList.Size = new System.Drawing.Size(1126, 408);
            this.dgvTracksList.TabIndex = 24;
            this.dgvTracksList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvTracksList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvTracksList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTracksList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTracksList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTracksList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTracksList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTracksList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvTracksList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvTracksList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTracksList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTracksList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTracksList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTracksList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvTracksList.ThemeStyle.ReadOnly = true;
            this.dgvTracksList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvTracksList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTracksList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTracksList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTracksList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvTracksList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvTracksList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTracksList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTracksList_CellDoubleClick);
            this.dgvTracksList.SelectionChanged += new System.EventHandler(this.DgvTracksList_SelectionChanged);
            // 
            // cmsTracks
            // 
            this.cmsTracks.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmsTracks.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsTracks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTrackToolStripMenuItem,
            this.editTrackInformationToolStripMenuItem,
            this.showTrackDetailsToolStripMenuItem,
            this.deleteTrackToolStripMenuItem,
            this.showTrackCoursesToolStripMenuItem,
            this.addCourseToTrackToolStripMenuItem});
            this.cmsTracks.Name = "cbUsers";
            this.cmsTracks.Size = new System.Drawing.Size(250, 248);
            // 
            // addNewTrackToolStripMenuItem
            // 
            this.addNewTrackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.addNewTrackToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.addNewTrackToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewTrackToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.add1;
            this.addNewTrackToolStripMenuItem.Name = "addNewTrackToolStripMenuItem";
            this.addNewTrackToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.addNewTrackToolStripMenuItem.Text = "Add New Track";
            this.addNewTrackToolStripMenuItem.Click += new System.EventHandler(this.AddNewTrackToolStripMenuItem_Click);
            // 
            // editTrackInformationToolStripMenuItem
            // 
            this.editTrackInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.editTrackInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.editTrackInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editTrackInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editTrackInformationToolStripMenuItem.Image")));
            this.editTrackInformationToolStripMenuItem.Name = "editTrackInformationToolStripMenuItem";
            this.editTrackInformationToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.editTrackInformationToolStripMenuItem.Text = "Edit Track Information";
            this.editTrackInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateTrackInfoToolStripMenuItem_Click);
            // 
            // showTrackDetailsToolStripMenuItem
            // 
            this.showTrackDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.showTrackDetailsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showTrackDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showTrackDetailsToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.show;
            this.showTrackDetailsToolStripMenuItem.Name = "showTrackDetailsToolStripMenuItem";
            this.showTrackDetailsToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.showTrackDetailsToolStripMenuItem.Text = "Show Track Details";
            this.showTrackDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowTrackDetailsToolStripMenuItem_Click);
            // 
            // deleteTrackToolStripMenuItem
            // 
            this.deleteTrackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.deleteTrackToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.deleteTrackToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteTrackToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.delete;
            this.deleteTrackToolStripMenuItem.Name = "deleteTrackToolStripMenuItem";
            this.deleteTrackToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.deleteTrackToolStripMenuItem.Text = "Delete Track";
            this.deleteTrackToolStripMenuItem.Click += new System.EventHandler(this.DeleteTrackToolStripMenuItem_Click);
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
            "Track ID",
            "Track Name"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(142, 202);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(192, 41);
            this.cbFilterByOptions.TabIndex = 23;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.CbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(42, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filter by :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(42, 85);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1126, 10);
            this.guna2Separator1.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.lblTitle.Location = new System.Drawing.Point(553, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 31);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Manage Tracks";
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
            this.txtFilterValue.Location = new System.Drawing.Point(364, 200);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(229, 43);
            this.txtFilterValue.TabIndex = 0;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.TxtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterValue_KeyPress);
            // 
            // btnAddNewTrack
            // 
            this.btnAddNewTrack.BorderRadius = 22;
            this.btnAddNewTrack.CustomizableEdges.BottomLeft = false;
            this.btnAddNewTrack.CustomizableEdges.TopRight = false;
            this.btnAddNewTrack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewTrack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewTrack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewTrack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btnAddNewTrack.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTrack.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTrack.Image = global::OnlineExaminationSystem.Properties.Resources.add_folder;
            this.btnAddNewTrack.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewTrack.Location = new System.Drawing.Point(980, 185);
            this.btnAddNewTrack.Name = "btnAddNewTrack";
            this.btnAddNewTrack.Size = new System.Drawing.Size(188, 58);
            this.btnAddNewTrack.TabIndex = 258;
            this.btnAddNewTrack.Text = "Add Track";
            this.btnAddNewTrack.Click += new System.EventHandler(this.BtnAddNewTrack_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.graduation_hat;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(485, 19);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.TabIndex = 19;
            // 
            // showTrackCoursesToolStripMenuItem
            // 
            this.showTrackCoursesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.showTrackCoursesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showTrackCoursesToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.add1;
            this.showTrackCoursesToolStripMenuItem.Name = "showTrackCoursesToolStripMenuItem";
            this.showTrackCoursesToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.showTrackCoursesToolStripMenuItem.Text = "Show Track Courses";
            this.showTrackCoursesToolStripMenuItem.Click += new System.EventHandler(this.ShowTrackCoursesToolStripMenuItem_Click);
            // 
            // addCourseToTrackToolStripMenuItem
            // 
            this.addCourseToTrackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.addCourseToTrackToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCourseToTrackToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.add1;
            this.addCourseToTrackToolStripMenuItem.Name = "addCourseToTrackToolStripMenuItem";
            this.addCourseToTrackToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.addCourseToTrackToolStripMenuItem.Text = "Add Course To Track";
            this.addCourseToTrackToolStripMenuItem.Click += new System.EventHandler(this.AddCourseToTrackToolStripMenuItem_Click);
            // 
            // FrmListTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 702);
            this.Controls.Add(this.btnAddNewTrack);
            this.Controls.Add(this.dgvTracksList);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListTracks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListTracks";
            this.Load += new System.EventHandler(this.FrmListTracks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracksList)).EndInit();
            this.cmsTracks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTracksList;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewTrack;
        private System.Windows.Forms.ContextMenuStrip cmsTracks;
        private System.Windows.Forms.ToolStripMenuItem addNewTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTrackInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTrackDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTrackCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToTrackToolStripMenuItem;
    }
}