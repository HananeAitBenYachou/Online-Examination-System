namespace OnlineExaminationSystem.Instructor_system.Exams
{
    partial class FrmAddUpdateExam
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtExamID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCourses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudNoOfTFQuestions = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNoOfMcqQuestions = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudExamDuration = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpExamDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvGeneratedQuestionsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGenerateQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfTFQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfMcqQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratedQuestionsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 32;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1084, 88);
            this.guna2GradientPanel1.TabIndex = 324;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.exam;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(402, 13);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Size = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(459, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Generate New Exam";
            // 
            // txtExamID
            // 
            this.txtExamID.BorderRadius = 22;
            this.txtExamID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExamID.DefaultText = "N/A";
            this.txtExamID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExamID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExamID.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.txtExamID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExamID.Enabled = false;
            this.txtExamID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExamID.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtExamID.ForeColor = System.Drawing.Color.Red;
            this.txtExamID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExamID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtExamID.Location = new System.Drawing.Point(296, 121);
            this.txtExamID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.PasswordChar = '\0';
            this.txtExamID.PlaceholderText = "";
            this.txtExamID.SelectedText = "";
            this.txtExamID.Size = new System.Drawing.Size(231, 46);
            this.txtExamID.TabIndex = 326;
            this.txtExamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 325;
            this.label1.Text = "Exam ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(603, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 328;
            this.label3.Text = "Course :";
            // 
            // cbCourses
            // 
            this.cbCourses.BackColor = System.Drawing.Color.Transparent;
            this.cbCourses.BorderRadius = 22;
            this.cbCourses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCourses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCourses.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbCourses.ForeColor = System.Drawing.Color.Black;
            this.cbCourses.ItemHeight = 40;
            this.cbCourses.Location = new System.Drawing.Point(802, 121);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(231, 46);
            this.cbCourses.TabIndex = 327;
            this.cbCourses.SelectedIndexChanged += new System.EventHandler(this.CbCourses_SelectedIndexChanged);
            // 
            // nudNoOfTFQuestions
            // 
            this.nudNoOfTFQuestions.BackColor = System.Drawing.Color.Transparent;
            this.nudNoOfTFQuestions.BorderRadius = 20;
            this.nudNoOfTFQuestions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNoOfTFQuestions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNoOfTFQuestions.Location = new System.Drawing.Point(296, 282);
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
            this.nudNoOfTFQuestions.TabIndex = 335;
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
            this.label4.Location = new System.Drawing.Point(26, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 21);
            this.label4.TabIndex = 334;
            this.label4.Text = "No Of True / False Questions :";
            // 
            // nudNoOfMcqQuestions
            // 
            this.nudNoOfMcqQuestions.BackColor = System.Drawing.Color.Transparent;
            this.nudNoOfMcqQuestions.BorderRadius = 20;
            this.nudNoOfMcqQuestions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNoOfMcqQuestions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNoOfMcqQuestions.Location = new System.Drawing.Point(802, 282);
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
            this.nudNoOfMcqQuestions.TabIndex = 337;
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
            this.label2.Location = new System.Drawing.Point(603, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 336;
            this.label2.Text = "No Of MCQ Questions :";
            // 
            // nudExamDuration
            // 
            this.nudExamDuration.BackColor = System.Drawing.Color.Transparent;
            this.nudExamDuration.BorderRadius = 20;
            this.nudExamDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudExamDuration.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExamDuration.Location = new System.Drawing.Point(294, 201);
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
            this.nudExamDuration.TabIndex = 339;
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
            this.label5.Location = new System.Drawing.Point(26, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 21);
            this.label5.TabIndex = 338;
            this.label5.Text = "Exam Duration (Min) :";
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.BorderRadius = 22;
            this.dtpExamDate.Checked = true;
            this.dtpExamDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpExamDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.dtpExamDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExamDate.Location = new System.Drawing.Point(802, 201);
            this.dtpExamDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExamDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(231, 46);
            this.dtpExamDate.TabIndex = 340;
            this.dtpExamDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(603, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 341;
            this.label6.Text = "Exam Date :";
            // 
            // dgvGeneratedQuestionsList
            // 
            this.dgvGeneratedQuestionsList.AllowUserToAddRows = false;
            this.dgvGeneratedQuestionsList.AllowUserToDeleteRows = false;
            this.dgvGeneratedQuestionsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvGeneratedQuestionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGeneratedQuestionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGeneratedQuestionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGeneratedQuestionsList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGeneratedQuestionsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGeneratedQuestionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvGeneratedQuestionsList.Location = new System.Drawing.Point(12, 360);
            this.dgvGeneratedQuestionsList.MultiSelect = false;
            this.dgvGeneratedQuestionsList.Name = "dgvGeneratedQuestionsList";
            this.dgvGeneratedQuestionsList.ReadOnly = true;
            this.dgvGeneratedQuestionsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGeneratedQuestionsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGeneratedQuestionsList.RowHeadersVisible = false;
            this.dgvGeneratedQuestionsList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvGeneratedQuestionsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGeneratedQuestionsList.RowTemplate.Height = 50;
            this.dgvGeneratedQuestionsList.Size = new System.Drawing.Size(1060, 337);
            this.dgvGeneratedQuestionsList.TabIndex = 342;
            this.dgvGeneratedQuestionsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvGeneratedQuestionsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvGeneratedQuestionsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGeneratedQuestionsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGeneratedQuestionsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGeneratedQuestionsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGeneratedQuestionsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGeneratedQuestionsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvGeneratedQuestionsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvGeneratedQuestionsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGeneratedQuestionsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvGeneratedQuestionsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGeneratedQuestionsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGeneratedQuestionsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvGeneratedQuestionsList.ThemeStyle.ReadOnly = true;
            this.dgvGeneratedQuestionsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvGeneratedQuestionsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGeneratedQuestionsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvGeneratedQuestionsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGeneratedQuestionsList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvGeneratedQuestionsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvGeneratedQuestionsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnGenerateQuestions
            // 
            this.btnGenerateQuestions.BorderRadius = 22;
            this.btnGenerateQuestions.CustomizableEdges.BottomLeft = false;
            this.btnGenerateQuestions.CustomizableEdges.TopRight = false;
            this.btnGenerateQuestions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateQuestions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateQuestions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateQuestions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btnGenerateQuestions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateQuestions.ForeColor = System.Drawing.Color.White;
            this.btnGenerateQuestions.Image = global::OnlineExaminationSystem.Properties.Resources.light_bulb;
            this.btnGenerateQuestions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGenerateQuestions.Location = new System.Drawing.Point(12, 710);
            this.btnGenerateQuestions.Name = "btnGenerateQuestions";
            this.btnGenerateQuestions.Size = new System.Drawing.Size(211, 58);
            this.btnGenerateQuestions.TabIndex = 346;
            this.btnGenerateQuestions.Text = "Generate Questions";
            this.btnGenerateQuestions.Click += new System.EventHandler(this.BtnGenerateQuestions_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 22;
            this.btnSave.CustomizableEdges.BottomLeft = false;
            this.btnSave.CustomizableEdges.TopRight = false;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::OnlineExaminationSystem.Properties.Resources.save;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(765, 710);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 58);
            this.btnSave.TabIndex = 345;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(925, 710);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 58);
            this.btnClose.TabIndex = 344;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmAddUpdateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 782);
            this.Controls.Add(this.btnGenerateQuestions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvGeneratedQuestionsList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpExamDate);
            this.Controls.Add(this.nudExamDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudNoOfMcqQuestions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudNoOfTFQuestions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCourses);
            this.Controls.Add(this.txtExamID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUpdateExam";
            this.Load += new System.EventHandler(this.FrmAddUpdateExam_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfTFQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfMcqQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratedQuestionsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtExamID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbCourses;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudExamDuration;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNoOfMcqQuestions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNoOfTFQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExamDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGeneratedQuestionsList;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnGenerateQuestions;
    }
}