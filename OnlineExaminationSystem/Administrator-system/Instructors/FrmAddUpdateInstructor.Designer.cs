namespace OnlineExaminationSystem.Administrator.Instructors
{
    partial class FrmAddUpdateInstructor
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcInstructorInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ucPersonCardWithFilter1 = new OnlineExaminationSystem.Administrator.People.UserControls.UcPersonCardWithFilter();
            this.tpWorkInfo = new System.Windows.Forms.TabPage();
            this.ckbIsStillEmployed = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExitDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtInstructorID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.tcInstructorInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpWorkInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1021, 88);
            this.guna2GradientPanel1.TabIndex = 236;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.teacher;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(384, 13);
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
            this.lblTitle.Location = new System.Drawing.Point(441, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New Instructor";
            // 
            // tcInstructorInfo
            // 
            this.tcInstructorInfo.Controls.Add(this.tpPersonalInfo);
            this.tcInstructorInfo.Controls.Add(this.tpWorkInfo);
            this.tcInstructorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInstructorInfo.ItemSize = new System.Drawing.Size(190, 60);
            this.tcInstructorInfo.Location = new System.Drawing.Point(0, 88);
            this.tcInstructorInfo.Name = "tcInstructorInfo";
            this.tcInstructorInfo.SelectedIndex = 0;
            this.tcInstructorInfo.Size = new System.Drawing.Size(1021, 695);
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
            this.tcInstructorInfo.TabIndex = 237;
            this.tcInstructorInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.tcInstructorInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.btnClose);
            this.tpPersonalInfo.Controls.Add(this.ucPersonCardWithFilter1);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 64);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(1013, 627);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 22;
            this.btnNext.CustomizableEdges.BottomLeft = false;
            this.btnNext.CustomizableEdges.TopRight = false;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btnNext.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::OnlineExaminationSystem.Properties.Resources.skip;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(858, 552);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(147, 58);
            this.btnNext.TabIndex = 261;
            this.btnNext.Text = "Next";
            this.btnNext.EnabledChanged += new System.EventHandler(this.BtnNext_EnabledChanged);
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
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
            this.btnClose.Location = new System.Drawing.Point(692, 552);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 58);
            this.btnClose.TabIndex = 260;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ucPersonCardWithFilter1
            // 
            this.ucPersonCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ucPersonCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPersonCardWithFilter1.FilterEnabled = true;
            this.ucPersonCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucPersonCardWithFilter1.Name = "ucPersonCardWithFilter1";
            this.ucPersonCardWithFilter1.Size = new System.Drawing.Size(1007, 538);
            this.ucPersonCardWithFilter1.TabIndex = 234;
            // 
            // tpWorkInfo
            // 
            this.tpWorkInfo.Controls.Add(this.ckbIsStillEmployed);
            this.tpWorkInfo.Controls.Add(this.label5);
            this.tpWorkInfo.Controls.Add(this.txtMonthlySalary);
            this.tpWorkInfo.Controls.Add(this.label1);
            this.tpWorkInfo.Controls.Add(this.label4);
            this.tpWorkInfo.Controls.Add(this.dtpHireDate);
            this.tpWorkInfo.Controls.Add(this.label2);
            this.tpWorkInfo.Controls.Add(this.dtpExitDate);
            this.tpWorkInfo.Controls.Add(this.txtInstructorID);
            this.tpWorkInfo.Controls.Add(this.label3);
            this.tpWorkInfo.Controls.Add(this.btnSave);
            this.tpWorkInfo.Location = new System.Drawing.Point(4, 64);
            this.tpWorkInfo.Name = "tpWorkInfo";
            this.tpWorkInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpWorkInfo.Size = new System.Drawing.Size(1013, 627);
            this.tpWorkInfo.TabIndex = 2;
            this.tpWorkInfo.Text = "Work Info";
            this.tpWorkInfo.UseVisualStyleBackColor = true;
            // 
            // ckbIsStillEmployed
            // 
            this.ckbIsStillEmployed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.ckbIsStillEmployed.CheckedState.BorderRadius = 2;
            this.ckbIsStillEmployed.CheckedState.BorderThickness = 0;
            this.ckbIsStillEmployed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.ckbIsStillEmployed.Location = new System.Drawing.Point(712, 307);
            this.ckbIsStillEmployed.Name = "ckbIsStillEmployed";
            this.ckbIsStillEmployed.Size = new System.Drawing.Size(20, 20);
            this.ckbIsStillEmployed.TabIndex = 276;
            this.ckbIsStillEmployed.Text = "guna2CustomCheckBox1";
            this.ckbIsStillEmployed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbIsStillEmployed.UncheckedState.BorderRadius = 2;
            this.ckbIsStillEmployed.UncheckedState.BorderThickness = 0;
            this.ckbIsStillEmployed.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbIsStillEmployed.CheckedChanged += new System.EventHandler(this.CkbIsStillEmployed_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(738, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 274;
            this.label5.Text = "Still employed";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.BorderRadius = 22;
            this.txtMonthlySalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonthlySalary.DefaultText = "";
            this.txtMonthlySalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonthlySalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonthlySalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonthlySalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonthlySalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonthlySalary.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMonthlySalary.ForeColor = System.Drawing.Color.Black;
            this.txtMonthlySalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonthlySalary.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtMonthlySalary.Location = new System.Drawing.Point(686, 137);
            this.txtMonthlySalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.PasswordChar = '\0';
            this.txtMonthlySalary.PlaceholderText = "";
            this.txtMonthlySalary.SelectedText = "";
            this.txtMonthlySalary.Size = new System.Drawing.Size(231, 46);
            this.txtMonthlySalary.TabIndex = 272;
            this.txtMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonthlySalary_KeyPress);
            this.txtMonthlySalary.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMonthlySalary_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(526, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 267;
            this.label1.Text = "Monthly Salary :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 264;
            this.label4.Text = "Hiring Date :";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.BorderRadius = 22;
            this.dtpHireDate.Checked = true;
            this.dtpHireDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.dtpHireDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHireDate.Location = new System.Drawing.Point(173, 233);
            this.dtpHireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(231, 46);
            this.dtpHireDate.TabIndex = 263;
            this.dtpHireDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            this.dtpHireDate.ValueChanged += new System.EventHandler(this.DtpHireDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(526, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 262;
            this.label2.Text = "Exit Date :";
            // 
            // dtpExitDate
            // 
            this.dtpExitDate.BorderRadius = 22;
            this.dtpExitDate.Checked = true;
            this.dtpExitDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.dtpExitDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExitDate.Location = new System.Drawing.Point(686, 233);
            this.dtpExitDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExitDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExitDate.Name = "dtpExitDate";
            this.dtpExitDate.Size = new System.Drawing.Size(231, 46);
            this.dtpExitDate.TabIndex = 261;
            this.dtpExitDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            this.dtpExitDate.Validating += new System.ComponentModel.CancelEventHandler(this.DtpExitDate_Validating);
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.BorderRadius = 22;
            this.txtInstructorID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstructorID.DefaultText = "N/A";
            this.txtInstructorID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtInstructorID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.Enabled = false;
            this.txtInstructorID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructorID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructorID.ForeColor = System.Drawing.Color.Red;
            this.txtInstructorID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructorID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtInstructorID.Location = new System.Drawing.Point(173, 137);
            this.txtInstructorID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.PasswordChar = '\0';
            this.txtInstructorID.PlaceholderText = "";
            this.txtInstructorID.ReadOnly = true;
            this.txtInstructorID.SelectedText = "";
            this.txtInstructorID.Size = new System.Drawing.Size(231, 46);
            this.txtInstructorID.TabIndex = 210;
            this.txtInstructorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 209;
            this.label3.Text = "Instructor ID :";
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
            this.btnSave.Location = new System.Drawing.Point(387, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 68);
            this.btnSave.TabIndex = 260;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmAddUpdateInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 783);
            this.Controls.Add(this.tcInstructorInfo);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateInstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUpdateInstructor";
            this.Load += new System.EventHandler(this.FrmAddUpdateInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcInstructorInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpWorkInfo.ResumeLayout(false);
            this.tpWorkInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcInstructorInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private People.UserControls.UcPersonCardWithFilter ucPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tpWorkInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExitDate;
        private Guna.UI2.WinForms.Guna2TextBox txtInstructorID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtMonthlySalary;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ckbIsStillEmployed;
    }
}