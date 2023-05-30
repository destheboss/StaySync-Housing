namespace housing
{
    partial class AdminComplaints
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
            this.tbComplaints = new housing.CustomElements.CustomTabControl();
            this.tabPeople = new System.Windows.Forms.TabPage();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.tabAdmins = new System.Windows.Forms.TabPage();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.btnDelete = new housing.CustomElements.RoundButton();
            this.panelTop.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbComplaints.SuspendLayout();
            this.tabPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.tabRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.tabAdmins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
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
            this.panel2.Controls.Add(this.tbComplaints);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(13, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 396);
            this.panel2.TabIndex = 18;
            // 
            // tbComplaints
            // 
            this.tbComplaints.Controls.Add(this.tabPeople);
            this.tbComplaints.Controls.Add(this.tabRoom);
            this.tbComplaints.Controls.Add(this.tabGeneral);
            this.tbComplaints.Controls.Add(this.tabAdmins);
            this.tbComplaints.Location = new System.Drawing.Point(35, 47);
            this.tbComplaints.Name = "tbComplaints";
            this.tbComplaints.SelectedIndex = 0;
            this.tbComplaints.Size = new System.Drawing.Size(682, 305);
            this.tbComplaints.TabIndex = 49;
            // 
            // tabPeople
            // 
            this.tabPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tabPeople.Controls.Add(this.dgvPeople);
            this.tabPeople.Location = new System.Drawing.Point(4, 25);
            this.tabPeople.Name = "tabPeople";
            this.tabPeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeople.Size = new System.Drawing.Size(674, 276);
            this.tabPeople.TabIndex = 0;
            this.tabPeople.Text = "People";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvPeople.Location = new System.Drawing.Point(3, 3);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidth = 62;
            this.dgvPeople.RowTemplate.Height = 28;
            this.dgvPeople.Size = new System.Drawing.Size(668, 270);
            this.dgvPeople.TabIndex = 6;
            this.dgvPeople.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAboutYou_CellDoubleClick);
            // 
            // tabRoom
            // 
            this.tabRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tabRoom.Controls.Add(this.dgvRoom);
            this.tabRoom.Location = new System.Drawing.Point(4, 25);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoom.Size = new System.Drawing.Size(603, 275);
            this.tabRoom.TabIndex = 1;
            this.tabRoom.Text = "Rooms";
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.dgvRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvRoom.Location = new System.Drawing.Point(3, 3);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersWidth = 62;
            this.dgvRoom.RowTemplate.Height = 28;
            this.dgvRoom.Size = new System.Drawing.Size(597, 269);
            this.dgvRoom.TabIndex = 6;
            this.dgvRoom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellDoubleClick);
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tabGeneral.Controls.Add(this.dgvGeneral);
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(603, 275);
            this.tabGeneral.TabIndex = 2;
            this.tabGeneral.Text = "General";
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.AllowUserToAddRows = false;
            this.dgvGeneral.AllowUserToDeleteRows = false;
            this.dgvGeneral.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.dgvGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeneral.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvGeneral.Location = new System.Drawing.Point(3, 3);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.ReadOnly = true;
            this.dgvGeneral.RowHeadersWidth = 62;
            this.dgvGeneral.RowTemplate.Height = 28;
            this.dgvGeneral.Size = new System.Drawing.Size(597, 269);
            this.dgvGeneral.TabIndex = 6;
            this.dgvGeneral.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneral_CellDoubleClick);
            // 
            // tabAdmins
            // 
            this.tabAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tabAdmins.Controls.Add(this.dgvAdmins);
            this.tabAdmins.Location = new System.Drawing.Point(4, 25);
            this.tabAdmins.Name = "tabAdmins";
            this.tabAdmins.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmins.Size = new System.Drawing.Size(603, 275);
            this.tabAdmins.TabIndex = 3;
            this.tabAdmins.Text = "Admins";
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.dgvAdmins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmins.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvAdmins.Location = new System.Drawing.Point(3, 3);
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersWidth = 62;
            this.dgvAdmins.RowTemplate.Height = 28;
            this.dgvAdmins.Size = new System.Drawing.Size(597, 269);
            this.dgvAdmins.TabIndex = 7;
            this.dgvAdmins.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmins_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnDelete.BorderRadius = 14;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(766, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 43);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminComplaints
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
            this.Name = "AdminComplaints";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestAttendance";
            this.Load += new System.EventHandler(this.AdminComplaints_Load);
            this.panelTop.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tbComplaints.ResumeLayout(false);
            this.tabPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.tabRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.tabAdmins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private CustomElements.RoundPanel roundPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private CustomElements.RoundButton btnDelete;
        private CustomElements.CustomTabControl tbComplaints;
        private System.Windows.Forms.TabPage tabPeople;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabAdmins;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.DataGridView dgvAdmins;
    }
}