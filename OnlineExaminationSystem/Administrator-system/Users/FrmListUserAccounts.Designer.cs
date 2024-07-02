namespace OnlineExaminationSystem.Administrator_system.Users
{
    partial class FrmListUserAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListUserAccounts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsUserAccounts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editUserAccountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUserAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cbTemp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvUserAccountsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmsUserAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccountsList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsUserAccounts
            // 
            this.cmsUserAccounts.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmsUserAccounts.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsUserAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserAccountInformationToolStripMenuItem,
            this.showUserAccountDetailsToolStripMenuItem,
            this.deleteUserAccountToolStripMenuItem});
            this.cmsUserAccounts.Name = "cbUsers";
            this.cmsUserAccounts.Size = new System.Drawing.Size(308, 112);
            // 
            // editUserAccountInformationToolStripMenuItem
            // 
            this.editUserAccountInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.editUserAccountInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.editUserAccountInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editUserAccountInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editUserAccountInformationToolStripMenuItem.Image")));
            this.editUserAccountInformationToolStripMenuItem.Name = "editUserAccountInformationToolStripMenuItem";
            this.editUserAccountInformationToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.editUserAccountInformationToolStripMenuItem.Text = "Edit User Account Information";
            this.editUserAccountInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateUserAccountInfoToolStripMenuItem_Click);
            // 
            // showUserAccountDetailsToolStripMenuItem
            // 
            this.showUserAccountDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.showUserAccountDetailsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showUserAccountDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showUserAccountDetailsToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.show;
            this.showUserAccountDetailsToolStripMenuItem.Name = "showUserAccountDetailsToolStripMenuItem";
            this.showUserAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.showUserAccountDetailsToolStripMenuItem.Text = "Show User Account Details";
            this.showUserAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowUserAccountDetailsToolStripMenuItem_Click);
            // 
            // deleteUserAccountToolStripMenuItem
            // 
            this.deleteUserAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.deleteUserAccountToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.deleteUserAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteUserAccountToolStripMenuItem.Image = global::OnlineExaminationSystem.Properties.Resources.delete;
            this.deleteUserAccountToolStripMenuItem.Name = "deleteUserAccountToolStripMenuItem";
            this.deleteUserAccountToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.deleteUserAccountToolStripMenuItem.Text = "Deactivate User Account";
            this.deleteUserAccountToolStripMenuItem.Click += new System.EventHandler(this.DeactivateUserAccountToolStripMenuItem_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(42, 86);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1126, 10);
            this.guna2Separator1.TabIndex = 262;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.lblTitle.Location = new System.Drawing.Point(553, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 31);
            this.lblTitle.TabIndex = 260;
            this.lblTitle.Text = "Manage User Accounts";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::OnlineExaminationSystem.Properties.Resources.management;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(485, 20);
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
            this.cbTemp.Location = new System.Drawing.Point(365, 208);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(192, 41);
            this.cbTemp.TabIndex = 273;
            this.cbTemp.Visible = false;
            this.cbTemp.SelectedIndexChanged += new System.EventHandler(this.CbTemp_SelectedIndexChanged);
            // 
            // dgvUserAccountsList
            // 
            this.dgvUserAccountsList.AllowUserToAddRows = false;
            this.dgvUserAccountsList.AllowUserToDeleteRows = false;
            this.dgvUserAccountsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvUserAccountsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserAccountsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserAccountsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUserAccountsList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserAccountsList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUserAccountsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvUserAccountsList.Location = new System.Drawing.Point(42, 268);
            this.dgvUserAccountsList.MultiSelect = false;
            this.dgvUserAccountsList.Name = "dgvUserAccountsList";
            this.dgvUserAccountsList.ReadOnly = true;
            this.dgvUserAccountsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserAccountsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUserAccountsList.RowHeadersVisible = false;
            this.dgvUserAccountsList.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dgvUserAccountsList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUserAccountsList.RowTemplate.Height = 50;
            this.dgvUserAccountsList.Size = new System.Drawing.Size(1126, 408);
            this.dgvUserAccountsList.TabIndex = 271;
            this.dgvUserAccountsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvUserAccountsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvUserAccountsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUserAccountsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUserAccountsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUserAccountsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUserAccountsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserAccountsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvUserAccountsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvUserAccountsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUserAccountsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUserAccountsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUserAccountsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserAccountsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvUserAccountsList.ThemeStyle.ReadOnly = true;
            this.dgvUserAccountsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvUserAccountsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserAccountsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUserAccountsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUserAccountsList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvUserAccountsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvUserAccountsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUserAccountsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUserAccountsList_CellDoubleClick);
            this.dgvUserAccountsList.SelectionChanged += new System.EventHandler(this.DgvUserAccountsList_SelectionChanged);
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
            "User ID",
            "Person ID",
            "Username",
            "Full Name",
            "Role",
            "Status"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(142, 208);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(192, 41);
            this.cbFilterByOptions.TabIndex = 270;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.CbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(42, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 269;
            this.label2.Text = "Filter by :";
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
            this.txtFilterValue.Location = new System.Drawing.Point(365, 206);
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
            // FrmListUserAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 702);
            this.Controls.Add(this.cbTemp);
            this.Controls.Add(this.dgvUserAccountsList);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListUserAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListUserAccounts";
            this.Load += new System.EventHandler(this.FrmListUserAccounts_Load);
            this.cmsUserAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccountsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsUserAccounts;
        private System.Windows.Forms.ToolStripMenuItem editUserAccountInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUserAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserAccountToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTemp;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUserAccountsList;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
    }
}