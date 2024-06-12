namespace OnlineExaminationSystem.Instructor_system.Exams.UserControls
{
    partial class UcExamCard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtCourse = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbCompleted = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbUpcoming = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvExamQuestionsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsQuestions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showQuestionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpExamDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nudExamDuration = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNoOfMcqQuestions = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNoOfTFQuestions = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExamID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamQuestionsList)).BeginInit();
            this.cmsQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfMcqQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfTFQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.BorderColor = System.Drawing.Color.Silver;
            this.groupBox.BorderRadius = 15;
            this.groupBox.Controls.Add(this.txtCourse);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.rbCompleted);
            this.groupBox.Controls.Add(this.rbUpcoming);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.dgvExamQuestionsList);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.dtpExamDate);
            this.groupBox.Controls.Add(this.nudExamDuration);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.nudNoOfMcqQuestions);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.nudNoOfTFQuestions);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtExamID);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1088, 689);
            this.groupBox.TabIndex = 4;
            this.groupBox.Text = "Exam Information";
            this.groupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCourse
            // 
            this.txtCourse.BorderRadius = 22;
            this.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourse.DefaultText = "";
            this.txtCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCourse.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCourse.Enabled = false;
            this.txtCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourse.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtCourse.ForeColor = System.Drawing.Color.Black;
            this.txtCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCourse.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtCourse.Location = new System.Drawing.Point(803, 61);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.PlaceholderText = "";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.SelectedText = "";
            this.txtCourse.Size = new System.Drawing.Size(231, 46);
            this.txtCourse.TabIndex = 361;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label8.Location = new System.Drawing.Point(427, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 360;
            this.label8.Text = "Upcoming";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label9.Location = new System.Drawing.Point(291, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 359;
            this.label9.Text = "Completed";
            // 
            // rbCompleted
            // 
            this.rbCompleted.Checked = true;
            this.rbCompleted.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.rbCompleted.CheckedState.BorderThickness = 0;
            this.rbCompleted.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rbCompleted.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbCompleted.Enabled = false;
            this.rbCompleted.Location = new System.Drawing.Point(378, 303);
            this.rbCompleted.Name = "rbCompleted";
            this.rbCompleted.Size = new System.Drawing.Size(20, 20);
            this.rbCompleted.TabIndex = 358;
            this.rbCompleted.Text = "guna2CustomRadioButton2";
            this.rbCompleted.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbCompleted.UncheckedState.BorderThickness = 2;
            this.rbCompleted.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbCompleted.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbUpcoming
            // 
            this.rbUpcoming.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.rbUpcoming.CheckedState.BorderThickness = 0;
            this.rbUpcoming.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rbUpcoming.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbUpcoming.Enabled = false;
            this.rbUpcoming.Location = new System.Drawing.Point(510, 303);
            this.rbUpcoming.Name = "rbUpcoming";
            this.rbUpcoming.Size = new System.Drawing.Size(20, 20);
            this.rbUpcoming.TabIndex = 357;
            this.rbUpcoming.Text = "guna2CustomRadioButton1";
            this.rbUpcoming.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbUpcoming.UncheckedState.BorderThickness = 2;
            this.rbUpcoming.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbUpcoming.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 356;
            this.label7.Text = "Status :";
            // 
            // dgvExamQuestionsList
            // 
            this.dgvExamQuestionsList.AllowUserToAddRows = false;
            this.dgvExamQuestionsList.AllowUserToDeleteRows = false;
            this.dgvExamQuestionsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvExamQuestionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExamQuestionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamQuestionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExamQuestionsList.ColumnHeadersHeight = 45;
            this.dgvExamQuestionsList.ContextMenuStrip = this.cmsQuestions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamQuestionsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExamQuestionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvExamQuestionsList.Location = new System.Drawing.Point(13, 338);
            this.dgvExamQuestionsList.MultiSelect = false;
            this.dgvExamQuestionsList.Name = "dgvExamQuestionsList";
            this.dgvExamQuestionsList.ReadOnly = true;
            this.dgvExamQuestionsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamQuestionsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExamQuestionsList.RowHeadersVisible = false;
            this.dgvExamQuestionsList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvExamQuestionsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExamQuestionsList.RowTemplate.Height = 50;
            this.dgvExamQuestionsList.Size = new System.Drawing.Size(1060, 337);
            this.dgvExamQuestionsList.TabIndex = 355;
            this.dgvExamQuestionsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvExamQuestionsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvExamQuestionsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExamQuestionsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExamQuestionsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExamQuestionsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExamQuestionsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvExamQuestionsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvExamQuestionsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvExamQuestionsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExamQuestionsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvExamQuestionsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExamQuestionsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExamQuestionsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvExamQuestionsList.ThemeStyle.ReadOnly = true;
            this.dgvExamQuestionsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvExamQuestionsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExamQuestionsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvExamQuestionsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExamQuestionsList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvExamQuestionsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvExamQuestionsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExamQuestionsList.SelectionChanged += new System.EventHandler(this.DgvExamQuestionsList_SelectionChanged);
            // 
            // cmsQuestions
            // 
            this.cmsQuestions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmsQuestions.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsQuestions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showQuestionDetailsToolStripMenuItem});
            this.cmsQuestions.Name = "cbUsers";
            this.cmsQuestions.Size = new System.Drawing.Size(256, 68);
            // 
            // showQuestionDetailsToolStripMenuItem
            // 
            this.showQuestionDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.showQuestionDetailsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showQuestionDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showQuestionDetailsToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.show;
            this.showQuestionDetailsToolStripMenuItem.Name = "showQuestionDetailsToolStripMenuItem";
            this.showQuestionDetailsToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.showQuestionDetailsToolStripMenuItem.Text = "Show Question Details";
            this.showQuestionDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowQuestionDetailsToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(604, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 354;
            this.label6.Text = "Exam Date :";
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.BorderRadius = 22;
            this.dtpExamDate.Checked = true;
            this.dtpExamDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpExamDate.Enabled = false;
            this.dtpExamDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.dtpExamDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExamDate.Location = new System.Drawing.Point(803, 141);
            this.dtpExamDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExamDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(231, 46);
            this.dtpExamDate.TabIndex = 353;
            this.dtpExamDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // nudExamDuration
            // 
            this.nudExamDuration.BackColor = System.Drawing.Color.Transparent;
            this.nudExamDuration.BorderRadius = 20;
            this.nudExamDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudExamDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudExamDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudExamDuration.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.nudExamDuration.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudExamDuration.DisabledState.UpDownButtonForeColor = System.Drawing.Color.DimGray;
            this.nudExamDuration.Enabled = false;
            this.nudExamDuration.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExamDuration.Location = new System.Drawing.Point(295, 141);
            this.nudExamDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudExamDuration.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudExamDuration.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudExamDuration.Name = "nudExamDuration";
            this.nudExamDuration.Size = new System.Drawing.Size(231, 46);
            this.nudExamDuration.TabIndex = 352;
            this.nudExamDuration.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.nudExamDuration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 21);
            this.label5.TabIndex = 351;
            this.label5.Text = "Exam Duration (Min) :";
            // 
            // nudNoOfMcqQuestions
            // 
            this.nudNoOfMcqQuestions.BackColor = System.Drawing.Color.Transparent;
            this.nudNoOfMcqQuestions.BorderRadius = 20;
            this.nudNoOfMcqQuestions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNoOfMcqQuestions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNoOfMcqQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNoOfMcqQuestions.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.nudNoOfMcqQuestions.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNoOfMcqQuestions.DisabledState.UpDownButtonForeColor = System.Drawing.Color.DimGray;
            this.nudNoOfMcqQuestions.Enabled = false;
            this.nudNoOfMcqQuestions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNoOfMcqQuestions.Location = new System.Drawing.Point(803, 222);
            this.nudNoOfMcqQuestions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNoOfMcqQuestions.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoOfMcqQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfMcqQuestions.Name = "nudNoOfMcqQuestions";
            this.nudNoOfMcqQuestions.Size = new System.Drawing.Size(231, 46);
            this.nudNoOfMcqQuestions.TabIndex = 350;
            this.nudNoOfMcqQuestions.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.nudNoOfMcqQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(604, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 349;
            this.label2.Text = "No Of MCQ Questions :";
            // 
            // nudNoOfTFQuestions
            // 
            this.nudNoOfTFQuestions.BackColor = System.Drawing.Color.Transparent;
            this.nudNoOfTFQuestions.BorderRadius = 20;
            this.nudNoOfTFQuestions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNoOfTFQuestions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNoOfTFQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNoOfTFQuestions.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.nudNoOfTFQuestions.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNoOfTFQuestions.DisabledState.UpDownButtonForeColor = System.Drawing.Color.DimGray;
            this.nudNoOfTFQuestions.Enabled = false;
            this.nudNoOfTFQuestions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNoOfTFQuestions.Location = new System.Drawing.Point(297, 222);
            this.nudNoOfTFQuestions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNoOfTFQuestions.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoOfTFQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfTFQuestions.Name = "nudNoOfTFQuestions";
            this.nudNoOfTFQuestions.Size = new System.Drawing.Size(231, 46);
            this.nudNoOfTFQuestions.TabIndex = 348;
            this.nudNoOfTFQuestions.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.nudNoOfTFQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 21);
            this.label4.TabIndex = 347;
            this.label4.Text = "No Of True / False Questions :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(604, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 346;
            this.label3.Text = "Course :";
            // 
            // txtExamID
            // 
            this.txtExamID.BorderRadius = 22;
            this.txtExamID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExamID.DefaultText = "N/A";
            this.txtExamID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExamID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExamID.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.txtExamID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExamID.Enabled = false;
            this.txtExamID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExamID.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtExamID.ForeColor = System.Drawing.Color.Red;
            this.txtExamID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExamID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtExamID.Location = new System.Drawing.Point(297, 61);
            this.txtExamID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.PasswordChar = '\0';
            this.txtExamID.PlaceholderText = "";
            this.txtExamID.ReadOnly = true;
            this.txtExamID.SelectedText = "";
            this.txtExamID.Size = new System.Drawing.Size(231, 46);
            this.txtExamID.TabIndex = 344;
            this.txtExamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 343;
            this.label1.Text = "Exam ID :";
            // 
            // UcExamCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox);
            this.Name = "UcExamCard";
            this.Size = new System.Drawing.Size(1088, 689);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamQuestionsList)).EndInit();
            this.cmsQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudExamDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfMcqQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfTFQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2DataGridView dgvExamQuestionsList;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExamDate;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudExamDuration;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNoOfMcqQuestions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNoOfTFQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtExamID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbCompleted;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbUpcoming;
        private Guna.UI2.WinForms.Guna2TextBox txtCourse;
        private System.Windows.Forms.ContextMenuStrip cmsQuestions;
        private System.Windows.Forms.ToolStripMenuItem showQuestionDetailsToolStripMenuItem;
    }
}
