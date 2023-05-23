namespace housing
{
    partial class AdminAttendance
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.roundPanel1 = new housing.CustomElements.RoundPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAbsent = new housing.CustomElements.RoundButton();
            this.tbxSearchName = new housing.CustomElements.RoundTextBox();
            this.roundPanelListBox1 = new housing.CustomElements.RoundPanelListBox();
            this.dgvTenantStatus = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPresent = new housing.CustomElements.RoundButton();
            this.lbTenant = new System.Windows.Forms.Label();
            this.btnSearchName = new housing.CustomElements.RoundButton();
            this.panelTop.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundPanelListBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenantStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1041, 53);
            this.panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Image = global::housing.Properties.Resources.attendance;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(911, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(130, 53);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "  Admin";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackgroundImage = global::housing.Properties.Resources.background1;
            this.roundPanel1.BorderColor = System.Drawing.Color.White;
            this.roundPanel1.BorderWidth = 5;
            this.roundPanel1.Controls.Add(this.panel2);
            this.roundPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.roundPanel1.IsBorder = false;
            this.roundPanel1.IsFill = true;
            this.roundPanel1.Location = new System.Drawing.Point(46, 93);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radius = 20;
            this.roundPanel1.Size = new System.Drawing.Size(946, 442);
            this.roundPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btnAbsent);
            this.panel2.Controls.Add(this.tbxSearchName);
            this.panel2.Controls.Add(this.roundPanelListBox1);
            this.panel2.Controls.Add(this.btnPresent);
            this.panel2.Controls.Add(this.lbTenant);
            this.panel2.Controls.Add(this.btnSearchName);
            this.panel2.Location = new System.Drawing.Point(13, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 396);
            this.panel2.TabIndex = 16;
            // 
            // btnAbsent
            // 
            this.btnAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnAbsent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnAbsent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnAbsent.BorderRadius = 14;
            this.btnAbsent.BorderSize = 0;
            this.btnAbsent.FlatAppearance.BorderSize = 0;
            this.btnAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsent.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsent.ForeColor = System.Drawing.Color.White;
            this.btnAbsent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbsent.Location = new System.Drawing.Point(643, 284);
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.Size = new System.Drawing.Size(118, 43);
            this.btnAbsent.TabIndex = 18;
            this.btnAbsent.Text = "Absent ❎";
            this.btnAbsent.TextColor = System.Drawing.Color.White;
            this.btnAbsent.UseVisualStyleBackColor = false;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // 
            // tbxSearchName
            // 
            this.tbxSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxSearchName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tbxSearchName.BorderFocusColor = System.Drawing.Color.White;
            this.tbxSearchName.BorderRadius = 12;
            this.tbxSearchName.BorderSize = 2;
            this.tbxSearchName.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchName.ForeColor = System.Drawing.Color.White;
            this.tbxSearchName.Location = new System.Drawing.Point(643, 93);
            this.tbxSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearchName.Multiline = false;
            this.tbxSearchName.Name = "tbxSearchName";
            this.tbxSearchName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxSearchName.PasswordChar = false;
            this.tbxSearchName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxSearchName.PlaceholderText = "< tenant >";
            this.tbxSearchName.Size = new System.Drawing.Size(121, 32);
            this.tbxSearchName.TabIndex = 17;
            this.tbxSearchName.Texts = "";
            this.tbxSearchName.UnderlinedStyle = true;
            // 
            // roundPanelListBox1
            // 
            this.roundPanelListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.roundPanelListBox1.Controls.Add(this.dgvTenantStatus);
            this.roundPanelListBox1.Location = new System.Drawing.Point(38, 65);
            this.roundPanelListBox1.Name = "roundPanelListBox1";
            this.roundPanelListBox1.Size = new System.Drawing.Size(565, 272);
            this.roundPanelListBox1.TabIndex = 16;
            // 
            // dgvTenantStatus
            // 
            this.dgvTenantStatus.AllowUserToAddRows = false;
            this.dgvTenantStatus.AllowUserToDeleteRows = false;
            this.dgvTenantStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.dgvTenantStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTenantStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenantStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnStatus});
            this.dgvTenantStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTenantStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvTenantStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvTenantStatus.Name = "dgvTenantStatus";
            this.dgvTenantStatus.ReadOnly = true;
            this.dgvTenantStatus.RowHeadersWidth = 62;
            this.dgvTenantStatus.RowTemplate.Height = 28;
            this.dgvTenantStatus.Size = new System.Drawing.Size(565, 272);
            this.dgvTenantStatus.TabIndex = 2;
            this.dgvTenantStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTenantStatus_CellClick);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 8;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnPresent
            // 
            this.btnPresent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnPresent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnPresent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnPresent.BorderRadius = 14;
            this.btnPresent.BorderSize = 0;
            this.btnPresent.FlatAppearance.BorderSize = 0;
            this.btnPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresent.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresent.ForeColor = System.Drawing.Color.White;
            this.btnPresent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPresent.Location = new System.Drawing.Point(772, 284);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(115, 43);
            this.btnPresent.TabIndex = 11;
            this.btnPresent.Text = "Present ☑";
            this.btnPresent.TextColor = System.Drawing.Color.White;
            this.btnPresent.UseVisualStyleBackColor = false;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // lbTenant
            // 
            this.lbTenant.AutoSize = true;
            this.lbTenant.BackColor = System.Drawing.Color.Transparent;
            this.lbTenant.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenant.ForeColor = System.Drawing.Color.White;
            this.lbTenant.Location = new System.Drawing.Point(642, 67);
            this.lbTenant.Name = "lbTenant";
            this.lbTenant.Size = new System.Drawing.Size(127, 21);
            this.lbTenant.TabIndex = 13;
            this.lbTenant.Text = "Search Tenant";
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSearchName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSearchName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSearchName.BorderRadius = 14;
            this.btnSearchName.BorderSize = 0;
            this.btnSearchName.FlatAppearance.BorderSize = 0;
            this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchName.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.ForeColor = System.Drawing.Color.White;
            this.btnSearchName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchName.Location = new System.Drawing.Point(643, 132);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(244, 43);
            this.btnSearchName.TabIndex = 15;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.TextColor = System.Drawing.Color.White;
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // AdminAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1041, 573);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminAttendance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestAttendance";
            this.Load += new System.EventHandler(this.adminattendance_Load);
            this.Leave += new System.EventHandler(this.AdminAttendance_Leave);
            this.panelTop.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.roundPanelListBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenantStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private CustomElements.RoundPanel roundPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private CustomElements.RoundButton btnAbsent;
        private CustomElements.RoundTextBox tbxSearchName;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private System.Windows.Forms.DataGridView dgvTenantStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private CustomElements.RoundButton btnPresent;
        private System.Windows.Forms.Label lbTenant;
        private CustomElements.RoundButton btnSearchName;
    }
}