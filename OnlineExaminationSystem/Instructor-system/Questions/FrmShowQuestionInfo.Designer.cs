namespace OnlineExaminationSystem.Instructor_system.Questions
{
    partial class FrmShowQuestionInfo
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucQuestionCard1 = new OnlineExaminationSystem.Instructor_system.Questions.UserControls.UcQuestionCard();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucQuestionCard1
            // 
            this.ucQuestionCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucQuestionCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucQuestionCard1.Location = new System.Drawing.Point(0, 0);
            this.ucQuestionCard1.Name = "ucQuestionCard1";
            this.ucQuestionCard1.Size = new System.Drawing.Size(1060, 529);
            this.ucQuestionCard1.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(910, 535);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 58);
            this.btnClose.TabIndex = 283;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmShowQuestionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucQuestionCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShowQuestionInfo";
            this.Text = "FrmShowQuestionInfo";
            this.Load += new System.EventHandler(this.FrmShowQuestionInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserControls.UcQuestionCard ucQuestionCard1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}