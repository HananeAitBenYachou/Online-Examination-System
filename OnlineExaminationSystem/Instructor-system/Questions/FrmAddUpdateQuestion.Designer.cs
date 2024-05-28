namespace OnlineExaminationSystem.Instructor_system.Questions
{
    partial class FrmAddUpdateQuestion
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbModelAnswer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtChoice3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChoice2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChoice1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudQuestionMark = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtQuestionText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbQuestionComplexity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuestionTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCourses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlQuestionChoices = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestionMark)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.pnlQuestionChoices.SuspendLayout();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(435, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New Question";
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
            this.btnSave.Location = new System.Drawing.Point(701, 547);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 58);
            this.btnSave.TabIndex = 343;
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
            this.btnClose.Location = new System.Drawing.Point(861, 547);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 58);
            this.btnClose.TabIndex = 342;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(590, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 21);
            this.label9.TabIndex = 341;
            this.label9.Text = "Model Answer : ";
            // 
            // cbModelAnswer
            // 
            this.cbModelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.cbModelAnswer.BorderRadius = 22;
            this.cbModelAnswer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModelAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelAnswer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelAnswer.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbModelAnswer.ForeColor = System.Drawing.Color.Black;
            this.cbModelAnswer.ItemHeight = 35;
            this.cbModelAnswer.Location = new System.Drawing.Point(772, 383);
            this.cbModelAnswer.Name = "cbModelAnswer";
            this.cbModelAnswer.Size = new System.Drawing.Size(148, 41);
            this.cbModelAnswer.TabIndex = 340;
            // 
            // txtChoice3
            // 
            this.txtChoice3.BorderRadius = 22;
            this.txtChoice3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChoice3.DefaultText = "";
            this.txtChoice3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChoice3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChoice3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChoice3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChoice3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChoice3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtChoice3.ForeColor = System.Drawing.Color.Black;
            this.txtChoice3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChoice3.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtChoice3.Location = new System.Drawing.Point(779, 22);
            this.txtChoice3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChoice3.Name = "txtChoice3";
            this.txtChoice3.PasswordChar = '\0';
            this.txtChoice3.PlaceholderText = "";
            this.txtChoice3.SelectedText = "";
            this.txtChoice3.Size = new System.Drawing.Size(193, 51);
            this.txtChoice3.TabIndex = 339;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(687, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 338;
            this.label8.Text = "Choice 3 :";
            // 
            // txtChoice2
            // 
            this.txtChoice2.BorderRadius = 22;
            this.txtChoice2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChoice2.DefaultText = "";
            this.txtChoice2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChoice2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChoice2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChoice2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChoice2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChoice2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtChoice2.ForeColor = System.Drawing.Color.Black;
            this.txtChoice2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChoice2.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtChoice2.Location = new System.Drawing.Point(444, 22);
            this.txtChoice2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChoice2.Name = "txtChoice2";
            this.txtChoice2.PasswordChar = '\0';
            this.txtChoice2.PlaceholderText = "";
            this.txtChoice2.SelectedText = "";
            this.txtChoice2.Size = new System.Drawing.Size(193, 51);
            this.txtChoice2.TabIndex = 337;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(352, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 336;
            this.label7.Text = "Choice 2 :";
            // 
            // txtChoice1
            // 
            this.txtChoice1.BorderRadius = 22;
            this.txtChoice1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChoice1.DefaultText = "";
            this.txtChoice1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChoice1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChoice1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChoice1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChoice1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChoice1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtChoice1.ForeColor = System.Drawing.Color.Black;
            this.txtChoice1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChoice1.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtChoice1.Location = new System.Drawing.Point(116, 22);
            this.txtChoice1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChoice1.Name = "txtChoice1";
            this.txtChoice1.PasswordChar = '\0';
            this.txtChoice1.PlaceholderText = "";
            this.txtChoice1.SelectedText = "";
            this.txtChoice1.Size = new System.Drawing.Size(193, 51);
            this.txtChoice1.TabIndex = 335;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 334;
            this.label6.Text = "Choice 1 :";
            // 
            // nudQuestionMark
            // 
            this.nudQuestionMark.BackColor = System.Drawing.Color.Transparent;
            this.nudQuestionMark.BorderRadius = 20;
            this.nudQuestionMark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuestionMark.DecimalPlaces = 2;
            this.nudQuestionMark.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuestionMark.Location = new System.Drawing.Point(296, 383);
            this.nudQuestionMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuestionMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudQuestionMark.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuestionMark.Name = "nudQuestionMark";
            this.nudQuestionMark.Size = new System.Drawing.Size(148, 41);
            this.nudQuestionMark.TabIndex = 333;
            this.nudQuestionMark.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.nudQuestionMark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.BorderRadius = 22;
            this.txtQuestionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestionText.DefaultText = "";
            this.txtQuestionText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuestionText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuestionText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestionText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestionText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestionText.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtQuestionText.ForeColor = System.Drawing.Color.Black;
            this.txtQuestionText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestionText.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtQuestionText.Location = new System.Drawing.Point(150, 173);
            this.txtQuestionText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.PasswordChar = '\0';
            this.txtQuestionText.PlaceholderText = "";
            this.txtQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuestionText.SelectedText = "";
            this.txtQuestionText.Size = new System.Drawing.Size(834, 119);
            this.txtQuestionText.TabIndex = 332;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 331;
            this.label5.Text = "Question Text :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(590, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 329;
            this.label2.Text = "Question Complexity :";
            // 
            // cbQuestionComplexity
            // 
            this.cbQuestionComplexity.BackColor = System.Drawing.Color.Transparent;
            this.cbQuestionComplexity.BorderRadius = 22;
            this.cbQuestionComplexity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuestionComplexity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestionComplexity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuestionComplexity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuestionComplexity.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbQuestionComplexity.ForeColor = System.Drawing.Color.Black;
            this.cbQuestionComplexity.ItemHeight = 35;
            this.cbQuestionComplexity.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbQuestionComplexity.Location = new System.Drawing.Point(772, 318);
            this.cbQuestionComplexity.Name = "cbQuestionComplexity";
            this.cbQuestionComplexity.Size = new System.Drawing.Size(148, 41);
            this.cbQuestionComplexity.TabIndex = 328;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(154, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 327;
            this.label1.Text = "Question Type :";
            // 
            // cbQuestionTypes
            // 
            this.cbQuestionTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbQuestionTypes.BorderRadius = 22;
            this.cbQuestionTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuestionTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestionTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuestionTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuestionTypes.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbQuestionTypes.ForeColor = System.Drawing.Color.Black;
            this.cbQuestionTypes.ItemHeight = 35;
            this.cbQuestionTypes.Items.AddRange(new object[] {
            "MCQ",
            "TF"});
            this.cbQuestionTypes.Location = new System.Drawing.Point(296, 318);
            this.cbQuestionTypes.Name = "cbQuestionTypes";
            this.cbQuestionTypes.Size = new System.Drawing.Size(148, 41);
            this.cbQuestionTypes.TabIndex = 326;
            this.cbQuestionTypes.SelectedIndexChanged += new System.EventHandler(this.CbQuestionTypes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(324, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 325;
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
            this.cbCourses.ItemHeight = 35;
            this.cbCourses.Location = new System.Drawing.Point(409, 112);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(287, 41);
            this.cbCourses.TabIndex = 324;
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1020, 88);
            this.guna2GradientPanel1.TabIndex = 323;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.conversation;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(378, 13);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Size = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(154, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 330;
            this.label4.Text = "Question Mark :";
            // 
            // pnlQuestionChoices
            // 
            this.pnlQuestionChoices.Controls.Add(this.txtChoice3);
            this.pnlQuestionChoices.Controls.Add(this.label6);
            this.pnlQuestionChoices.Controls.Add(this.txtChoice1);
            this.pnlQuestionChoices.Controls.Add(this.label7);
            this.pnlQuestionChoices.Controls.Add(this.txtChoice2);
            this.pnlQuestionChoices.Controls.Add(this.label8);
            this.pnlQuestionChoices.Location = new System.Drawing.Point(15, 446);
            this.pnlQuestionChoices.Name = "pnlQuestionChoices";
            this.pnlQuestionChoices.Size = new System.Drawing.Size(996, 91);
            this.pnlQuestionChoices.TabIndex = 344;
            // 
            // FrmAddUpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 613);
            this.Controls.Add(this.pnlQuestionChoices);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbModelAnswer);
            this.Controls.Add(this.nudQuestionMark);
            this.Controls.Add(this.txtQuestionText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbQuestionComplexity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuestionTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCourses);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUpdateQuestion";
            this.Load += new System.EventHandler(this.FrmAddUpdateQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestionMark)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.pnlQuestionChoices.ResumeLayout(false);
            this.pnlQuestionChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbModelAnswer;
        private Guna.UI2.WinForms.Guna2TextBox txtChoice3;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtChoice2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtChoice1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuestionMark;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbQuestionComplexity;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbQuestionTypes;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbCourses;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlQuestionChoices;
    }
}