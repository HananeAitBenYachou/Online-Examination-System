namespace OnlineExaminationSystem.Administrator.Instructors.InstructorCourses
{
    partial class FrmAssignCourseToInstructor
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtInstructorID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCourses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1.SuspendLayout();
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(769, 88);
            this.guna2GradientPanel1.TabIndex = 293;
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(207, 13);
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
            this.lblTitle.Location = new System.Drawing.Point(264, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Assign Course To Instructor";
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
            this.btnSave.Location = new System.Drawing.Point(450, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 58);
            this.btnSave.TabIndex = 299;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.BackColor = System.Drawing.Color.Transparent;
            this.txtInstructorID.BorderRadius = 22;
            this.txtInstructorID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstructorID.DefaultText = "";
            this.txtInstructorID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtInstructorID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructorID.Enabled = false;
            this.txtInstructorID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructorID.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtInstructorID.ForeColor = System.Drawing.Color.Black;
            this.txtInstructorID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructorID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtInstructorID.Location = new System.Drawing.Point(209, 134);
            this.txtInstructorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInstructorID.Multiline = true;
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.PasswordChar = '\0';
            this.txtInstructorID.PlaceholderText = "";
            this.txtInstructorID.ReadOnly = true;
            this.txtInstructorID.SelectedText = "";
            this.txtInstructorID.Size = new System.Drawing.Size(421, 74);
            this.txtInstructorID.TabIndex = 298;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 297;
            this.label1.Text = "Instructor : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(92, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 296;
            this.label8.Text = "Courses : ";
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
            this.cbCourses.ItemHeight = 50;
            this.cbCourses.Items.AddRange(new object[] {
            "User ID",
            "Full Name",
            "Gender",
            "UserName",
            "Country",
            "Is Active"});
            this.cbCourses.Location = new System.Drawing.Point(209, 255);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(421, 56);
            this.cbCourses.TabIndex = 295;
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
            this.btnClose.Location = new System.Drawing.Point(610, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 58);
            this.btnClose.TabIndex = 294;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 32;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmAssignCourseToInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 483);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInstructorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCourses);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAssignCourseToInstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAssignCourseToInstructor";
            this.Load += new System.EventHandler(this.FrmAssignCourseToInstructor_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtInstructorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cbCourses;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}