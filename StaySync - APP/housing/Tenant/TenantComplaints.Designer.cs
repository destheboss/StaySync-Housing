namespace housing
{
    partial class TenantComplaints
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
            this.roomCMB = new housing.CustomElements.CustomComboBox();
            this.adminCMB = new housing.CustomElements.CustomComboBox();
            this.tenantCMB = new housing.CustomElements.CustomComboBox();
            this.generalRbtn = new housing.CustomElements.CustomRadioButton();
            this.roomRbtn = new housing.CustomElements.CustomRadioButton();
            this.adminRbtn = new housing.CustomElements.CustomRadioButton();
            this.tenantRbtn = new housing.CustomElements.CustomRadioButton();
            this.tbxComplaint = new housing.CustomElements.RoundTextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSubmit = new housing.CustomElements.RoundButton();
            this.btnViewComplaints = new housing.CustomElements.RoundButton();
            this.panelTop.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnClose.Text = "  Tenant";
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
            this.panel2.Controls.Add(this.roomCMB);
            this.panel2.Controls.Add(this.adminCMB);
            this.panel2.Controls.Add(this.tenantCMB);
            this.panel2.Controls.Add(this.generalRbtn);
            this.panel2.Controls.Add(this.roomRbtn);
            this.panel2.Controls.Add(this.adminRbtn);
            this.panel2.Controls.Add(this.tenantRbtn);
            this.panel2.Controls.Add(this.tbxComplaint);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.btnViewComplaints);
            this.panel2.Location = new System.Drawing.Point(13, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 396);
            this.panel2.TabIndex = 17;
            // 
            // roomCMB
            // 
            this.roomCMB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.roomCMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.roomCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.roomCMB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.roomCMB.BorderSize = 1;
            this.roomCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomCMB.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.roomCMB.ForeColor = System.Drawing.Color.Black;
            this.roomCMB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.roomCMB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.roomCMB.ListTextColor = System.Drawing.Color.Black;
            this.roomCMB.Location = new System.Drawing.Point(239, 168);
            this.roomCMB.MinimumSize = new System.Drawing.Size(200, 30);
            this.roomCMB.Name = "roomCMB";
            this.roomCMB.Padding = new System.Windows.Forms.Padding(1);
            this.roomCMB.Size = new System.Drawing.Size(227, 30);
            this.roomCMB.TabIndex = 34;
            this.roomCMB.Texts = "Room";
            // 
            // adminCMB
            // 
            this.adminCMB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adminCMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.adminCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.adminCMB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.adminCMB.BorderSize = 1;
            this.adminCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminCMB.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.adminCMB.ForeColor = System.Drawing.Color.Black;
            this.adminCMB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.adminCMB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.adminCMB.ListTextColor = System.Drawing.Color.Black;
            this.adminCMB.Location = new System.Drawing.Point(239, 128);
            this.adminCMB.MinimumSize = new System.Drawing.Size(200, 30);
            this.adminCMB.Name = "adminCMB";
            this.adminCMB.Padding = new System.Windows.Forms.Padding(1);
            this.adminCMB.Size = new System.Drawing.Size(227, 30);
            this.adminCMB.TabIndex = 33;
            this.adminCMB.Texts = "Admin";
            // 
            // tenantCMB
            // 
            this.tenantCMB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tenantCMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tenantCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tenantCMB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tenantCMB.BorderSize = 1;
            this.tenantCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tenantCMB.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tenantCMB.ForeColor = System.Drawing.Color.Black;
            this.tenantCMB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tenantCMB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tenantCMB.ListTextColor = System.Drawing.Color.Black;
            this.tenantCMB.Location = new System.Drawing.Point(239, 88);
            this.tenantCMB.MinimumSize = new System.Drawing.Size(200, 30);
            this.tenantCMB.Name = "tenantCMB";
            this.tenantCMB.Padding = new System.Windows.Forms.Padding(1);
            this.tenantCMB.Size = new System.Drawing.Size(227, 30);
            this.tenantCMB.TabIndex = 32;
            this.tenantCMB.Texts = "Tenant";
            // 
            // generalRbtn
            // 
            this.generalRbtn.AutoSize = true;
            this.generalRbtn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.generalRbtn.ForeColor = System.Drawing.Color.White;
            this.generalRbtn.Location = new System.Drawing.Point(30, 215);
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
            this.roomRbtn.Location = new System.Drawing.Point(30, 177);
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
            this.adminRbtn.Location = new System.Drawing.Point(30, 137);
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
            this.tenantRbtn.Location = new System.Drawing.Point(30, 96);
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
            // tbxComplaint
            // 
            this.tbxComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxComplaint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tbxComplaint.BorderFocusColor = System.Drawing.Color.White;
            this.tbxComplaint.BorderRadius = 14;
            this.tbxComplaint.BorderSize = 2;
            this.tbxComplaint.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComplaint.ForeColor = System.Drawing.Color.White;
            this.tbxComplaint.Location = new System.Drawing.Point(501, 86);
            this.tbxComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.tbxComplaint.Multiline = true;
            this.tbxComplaint.Name = "tbxComplaint";
            this.tbxComplaint.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxComplaint.PasswordChar = false;
            this.tbxComplaint.PlaceholderColor = System.Drawing.Color.Black;
            this.tbxComplaint.PlaceholderText = "< complaint >";
            this.tbxComplaint.Size = new System.Drawing.Size(386, 183);
            this.tbxComplaint.TabIndex = 27;
            this.tbxComplaint.Texts = "";
            this.tbxComplaint.UnderlinedStyle = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.lbName.Location = new System.Drawing.Point(25, 46);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(243, 25);
            this.lbName.TabIndex = 19;
            this.lbName.Text = "Subject of complaint:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSubmit.BorderRadius = 14;
            this.btnSubmit.BorderSize = 0;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Location = new System.Drawing.Point(766, 290);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 43);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnViewComplaints
            // 
            this.btnViewComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnViewComplaints.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnViewComplaints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnViewComplaints.BorderRadius = 14;
            this.btnViewComplaints.BorderSize = 0;
            this.btnViewComplaints.FlatAppearance.BorderSize = 0;
            this.btnViewComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewComplaints.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewComplaints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnViewComplaints.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewComplaints.Location = new System.Drawing.Point(294, 226);
            this.btnViewComplaints.Name = "btnViewComplaints";
            this.btnViewComplaints.Size = new System.Drawing.Size(172, 43);
            this.btnViewComplaints.TabIndex = 11;
            this.btnViewComplaints.Text = "View Complaints";
            this.btnViewComplaints.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnViewComplaints.UseVisualStyleBackColor = false;
            this.btnViewComplaints.Click += new System.EventHandler(this.btnViewComplaints_Click);
            // 
            // TenantComplaints
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
            this.Name = "TenantComplaints";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestAttendance";
            this.Load += new System.EventHandler(this.TenantComplaints_Load);
            this.panelTop.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private CustomElements.RoundPanel roundPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private CustomElements.RoundButton btnSubmit;
        private CustomElements.RoundButton btnViewComplaints;
        private CustomElements.RoundTextBox tbxComplaint;
        private CustomElements.CustomRadioButton generalRbtn;
        private CustomElements.CustomRadioButton roomRbtn;
        private CustomElements.CustomRadioButton adminRbtn;
        private CustomElements.CustomRadioButton tenantRbtn;
        private CustomElements.CustomComboBox roomCMB;
        private CustomElements.CustomComboBox adminCMB;
        private CustomElements.CustomComboBox tenantCMB;
    }
}