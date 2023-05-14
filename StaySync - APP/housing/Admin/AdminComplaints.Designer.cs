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
            this.noneRbtn = new housing.CustomElements.CustomRadioButton();
            this.byTenantCMB = new housing.CustomElements.CustomComboBox();
            this.byNoneRbtn = new housing.CustomElements.CustomRadioButton();
            this.byTenantRbtn = new housing.CustomElements.CustomRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanelListBox1 = new housing.CustomElements.RoundPanelListBox();
            this.complaintsLB = new System.Windows.Forms.ListBox();
            this.roomCMB = new housing.CustomElements.CustomComboBox();
            this.adminCMB = new housing.CustomElements.CustomComboBox();
            this.tenantCMB = new housing.CustomElements.CustomComboBox();
            this.generalRbtn = new housing.CustomElements.CustomRadioButton();
            this.roomRbtn = new housing.CustomElements.CustomRadioButton();
            this.adminRbtn = new housing.CustomElements.CustomRadioButton();
            this.tenantRbtn = new housing.CustomElements.CustomRadioButton();
            this.lbName = new System.Windows.Forms.Label();
            this.btnDelete = new housing.CustomElements.RoundButton();
            this.btnSort = new housing.CustomElements.RoundButton();
            this.panelTop.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundPanelListBox1.SuspendLayout();
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
            this.panel2.Controls.Add(this.noneRbtn);
            this.panel2.Controls.Add(this.byTenantCMB);
            this.panel2.Controls.Add(this.byNoneRbtn);
            this.panel2.Controls.Add(this.byTenantRbtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.roundPanelListBox1);
            this.panel2.Controls.Add(this.roomCMB);
            this.panel2.Controls.Add(this.adminCMB);
            this.panel2.Controls.Add(this.tenantCMB);
            this.panel2.Controls.Add(this.generalRbtn);
            this.panel2.Controls.Add(this.roomRbtn);
            this.panel2.Controls.Add(this.adminRbtn);
            this.panel2.Controls.Add(this.tenantRbtn);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSort);
            this.panel2.Location = new System.Drawing.Point(13, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 396);
            this.panel2.TabIndex = 18;
            // 
            // noneRbtn
            // 
            this.noneRbtn.AutoSize = true;
            this.noneRbtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.noneRbtn.ForeColor = System.Drawing.Color.White;
            this.noneRbtn.Location = new System.Drawing.Point(30, 217);
            this.noneRbtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.noneRbtn.Name = "noneRbtn";
            this.noneRbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.noneRbtn.Size = new System.Drawing.Size(68, 21);
            this.noneRbtn.TabIndex = 42;
            this.noneRbtn.TabStop = true;
            this.noneRbtn.Text = "None";
            this.noneRbtn.UnCheckedColor = System.Drawing.Color.White;
            this.noneRbtn.UseVisualStyleBackColor = true;
            // 
            // byTenantCMB
            // 
            this.byTenantCMB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.byTenantCMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.byTenantCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.byTenantCMB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.byTenantCMB.BorderSize = 1;
            this.byTenantCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.byTenantCMB.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.byTenantCMB.ForeColor = System.Drawing.Color.White;
            this.byTenantCMB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.byTenantCMB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.byTenantCMB.ListTextColor = System.Drawing.Color.White;
            this.byTenantCMB.Location = new System.Drawing.Point(239, 303);
            this.byTenantCMB.MinimumSize = new System.Drawing.Size(200, 30);
            this.byTenantCMB.Name = "byTenantCMB";
            this.byTenantCMB.Padding = new System.Windows.Forms.Padding(1);
            this.byTenantCMB.Size = new System.Drawing.Size(227, 30);
            this.byTenantCMB.TabIndex = 41;
            this.byTenantCMB.Texts = "";
            // 
            // byNoneRbtn
            // 
            this.byNoneRbtn.AutoSize = true;
            this.byNoneRbtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.byNoneRbtn.ForeColor = System.Drawing.Color.White;
            this.byNoneRbtn.Location = new System.Drawing.Point(30, 352);
            this.byNoneRbtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.byNoneRbtn.Name = "byNoneRbtn";
            this.byNoneRbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.byNoneRbtn.Size = new System.Drawing.Size(68, 21);
            this.byNoneRbtn.TabIndex = 38;
            this.byNoneRbtn.TabStop = true;
            this.byNoneRbtn.Text = "None";
            this.byNoneRbtn.UnCheckedColor = System.Drawing.Color.White;
            this.byNoneRbtn.UseVisualStyleBackColor = true;
            // 
            // byTenantRbtn
            // 
            this.byTenantRbtn.AutoSize = true;
            this.byTenantRbtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.byTenantRbtn.ForeColor = System.Drawing.Color.White;
            this.byTenantRbtn.Location = new System.Drawing.Point(30, 311);
            this.byTenantRbtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.byTenantRbtn.Name = "byTenantRbtn";
            this.byTenantRbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.byTenantRbtn.Size = new System.Drawing.Size(84, 21);
            this.byTenantRbtn.TabIndex = 37;
            this.byTenantRbtn.TabStop = true;
            this.byTenantRbtn.Text = "Tenant";
            this.byTenantRbtn.UnCheckedColor = System.Drawing.Color.White;
            this.byTenantRbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(25, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sort by SENDER:";
            // 
            // roundPanelListBox1
            // 
            this.roundPanelListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.roundPanelListBox1.Controls.Add(this.complaintsLB);
            this.roundPanelListBox1.Location = new System.Drawing.Point(504, 17);
            this.roundPanelListBox1.Name = "roundPanelListBox1";
            this.roundPanelListBox1.Size = new System.Drawing.Size(383, 208);
            this.roundPanelListBox1.TabIndex = 35;
            // 
            // complaintsLB
            // 
            this.complaintsLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.complaintsLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.complaintsLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complaintsLB.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintsLB.ForeColor = System.Drawing.Color.White;
            this.complaintsLB.FormattingEnabled = true;
            this.complaintsLB.ItemHeight = 16;
            this.complaintsLB.Location = new System.Drawing.Point(0, 0);
            this.complaintsLB.Name = "complaintsLB";
            this.complaintsLB.Size = new System.Drawing.Size(383, 208);
            this.complaintsLB.TabIndex = 10;
            // 
            // roomCMB
            // 
            this.roomCMB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.roomCMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.roomCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.roomCMB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.roomCMB.BorderSize = 1;
            this.roomCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.roomCMB.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.roomCMB.ForeColor = System.Drawing.Color.White;
            this.roomCMB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.roomCMB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.roomCMB.ListTextColor = System.Drawing.Color.White;
            this.roomCMB.Location = new System.Drawing.Point(239, 134);
            this.roomCMB.MinimumSize = new System.Drawing.Size(200, 30);
            this.roomCMB.Name = "roomCMB";
            this.roomCMB.Padding = new System.Windows.Forms.Padding(1);
            this.roomCMB.Size = new System.Drawing.Size(227, 30);
            this.roomCMB.TabIndex = 34;
            this.roomCMB.Texts = "";
            // 
            // adminCMB
            // 
            this.adminCMB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adminCMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adminCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.adminCMB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.adminCMB.BorderSize = 1;
            this.adminCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.adminCMB.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.adminCMB.ForeColor = System.Drawing.Color.White;
            this.adminCMB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.adminCMB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.adminCMB.ListTextColor = System.Drawing.Color.White;
            this.adminCMB.Location = new System.Drawing.Point(239, 94);
            this.adminCMB.MinimumSize = new System.Drawing.Size(200, 30);
            this.adminCMB.Name = "adminCMB";
            this.adminCMB.Padding = new System.Windows.Forms.Padding(1);
            this.adminCMB.Size = new System.Drawing.Size(227, 30);
            this.adminCMB.TabIndex = 33;
            this.adminCMB.Texts = "";
            // 
            // tenantCMB
            // 
            this.tenantCMB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tenantCMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tenantCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tenantCMB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tenantCMB.BorderSize = 1;
            this.tenantCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.tenantCMB.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tenantCMB.ForeColor = System.Drawing.Color.White;
            this.tenantCMB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tenantCMB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.tenantCMB.ListTextColor = System.Drawing.Color.White;
            this.tenantCMB.Location = new System.Drawing.Point(239, 54);
            this.tenantCMB.MinimumSize = new System.Drawing.Size(200, 30);
            this.tenantCMB.Name = "tenantCMB";
            this.tenantCMB.Padding = new System.Windows.Forms.Padding(1);
            this.tenantCMB.Size = new System.Drawing.Size(227, 30);
            this.tenantCMB.TabIndex = 32;
            this.tenantCMB.Texts = "";
            // 
            // generalRbtn
            // 
            this.generalRbtn.AutoSize = true;
            this.generalRbtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.generalRbtn.ForeColor = System.Drawing.Color.White;
            this.generalRbtn.Location = new System.Drawing.Point(30, 181);
            this.generalRbtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.generalRbtn.Name = "generalRbtn";
            this.generalRbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.generalRbtn.Size = new System.Drawing.Size(92, 21);
            this.generalRbtn.TabIndex = 31;
            this.generalRbtn.TabStop = true;
            this.generalRbtn.Text = "General";
            this.generalRbtn.UnCheckedColor = System.Drawing.Color.White;
            this.generalRbtn.UseVisualStyleBackColor = true;
            // 
            // roomRbtn
            // 
            this.roomRbtn.AutoSize = true;
            this.roomRbtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.roomRbtn.ForeColor = System.Drawing.Color.White;
            this.roomRbtn.Location = new System.Drawing.Point(30, 143);
            this.roomRbtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.roomRbtn.Name = "roomRbtn";
            this.roomRbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.roomRbtn.Size = new System.Drawing.Size(68, 21);
            this.roomRbtn.TabIndex = 30;
            this.roomRbtn.TabStop = true;
            this.roomRbtn.Text = "Room";
            this.roomRbtn.UnCheckedColor = System.Drawing.Color.White;
            this.roomRbtn.UseVisualStyleBackColor = true;
            // 
            // adminRbtn
            // 
            this.adminRbtn.AutoSize = true;
            this.adminRbtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.adminRbtn.ForeColor = System.Drawing.Color.White;
            this.adminRbtn.Location = new System.Drawing.Point(30, 103);
            this.adminRbtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.adminRbtn.Name = "adminRbtn";
            this.adminRbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminRbtn.Size = new System.Drawing.Size(76, 21);
            this.adminRbtn.TabIndex = 29;
            this.adminRbtn.TabStop = true;
            this.adminRbtn.Text = "Admin";
            this.adminRbtn.UnCheckedColor = System.Drawing.Color.White;
            this.adminRbtn.UseVisualStyleBackColor = true;
            // 
            // tenantRbtn
            // 
            this.tenantRbtn.AutoSize = true;
            this.tenantRbtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tenantRbtn.ForeColor = System.Drawing.Color.White;
            this.tenantRbtn.Location = new System.Drawing.Point(30, 62);
            this.tenantRbtn.MinimumSize = new System.Drawing.Size(0, 21);
            this.tenantRbtn.Name = "tenantRbtn";
            this.tenantRbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tenantRbtn.Size = new System.Drawing.Size(84, 21);
            this.tenantRbtn.TabIndex = 28;
            this.tenantRbtn.TabStop = true;
            this.tenantRbtn.Text = "Tenant";
            this.tenantRbtn.UnCheckedColor = System.Drawing.Color.White;
            this.tenantRbtn.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.lbName.Location = new System.Drawing.Point(25, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(188, 25);
            this.lbName.TabIndex = 19;
            this.lbName.Text = "Sort by SUBJECT:";
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
            this.btnDelete.Location = new System.Drawing.Point(766, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 43);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSort.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSort.BorderRadius = 14;
            this.btnSort.BorderSize = 0;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSort.Location = new System.Drawing.Point(639, 244);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(121, 43);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Sort";
            this.btnSort.TextColor = System.Drawing.Color.White;
            this.btnSort.UseVisualStyleBackColor = false;
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
            this.panelTop.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.roundPanelListBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private CustomElements.RoundPanel roundPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private CustomElements.CustomComboBox roomCMB;
        private CustomElements.CustomComboBox adminCMB;
        private CustomElements.CustomComboBox tenantCMB;
        private CustomElements.CustomRadioButton generalRbtn;
        private CustomElements.CustomRadioButton roomRbtn;
        private CustomElements.CustomRadioButton adminRbtn;
        private CustomElements.CustomRadioButton tenantRbtn;
        private System.Windows.Forms.Label lbName;
        private CustomElements.RoundButton btnDelete;
        private CustomElements.RoundButton btnSort;
        private CustomElements.CustomComboBox byTenantCMB;
        private CustomElements.CustomRadioButton byNoneRbtn;
        private CustomElements.CustomRadioButton byTenantRbtn;
        private System.Windows.Forms.Label label1;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private System.Windows.Forms.ListBox complaintsLB;
        private CustomElements.CustomRadioButton noneRbtn;
    }
}