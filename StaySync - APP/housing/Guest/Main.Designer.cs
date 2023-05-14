namespace housing
{
    partial class Main
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnAnnounce = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelBackground = new housing.CustomElements.RoundPanel();
            this.Forgotbtn = new housing.CustomElements.RoundButton();
            this.btnLogin = new housing.CustomElements.RoundButton();
            this.tbxCodeInput = new housing.CustomElements.RoundTextBox();
            this.pictureQR = new System.Windows.Forms.PictureBox();
            this.lbWelcome = new housing.CustomElements.RoundLabel();
            this.panelSideMenu.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelInformation);
            this.panelSideMenu.Controls.Add(this.btnInformation);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(225, 573);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelInformation.Controls.Add(this.btnContact);
            this.panelInformation.Controls.Add(this.btnRules);
            this.panelInformation.Controls.Add(this.btnAnnounce);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformation.Location = new System.Drawing.Point(0, 137);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(225, 122);
            this.panelInformation.TabIndex = 14;
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.ForeColor = System.Drawing.Color.Silver;
            this.btnContact.Location = new System.Drawing.Point(0, 80);
            this.btnContact.Name = "btnContact";
            this.btnContact.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnContact.Size = new System.Drawing.Size(225, 40);
            this.btnContact.TabIndex = 3;
            this.btnContact.Text = "Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnRules
            // 
            this.btnRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.ForeColor = System.Drawing.Color.Silver;
            this.btnRules.Location = new System.Drawing.Point(0, 40);
            this.btnRules.Name = "btnRules";
            this.btnRules.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRules.Size = new System.Drawing.Size(225, 40);
            this.btnRules.TabIndex = 1;
            this.btnRules.Text = "House Rules";
            this.btnRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnAnnounce
            // 
            this.btnAnnounce.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnounce.FlatAppearance.BorderSize = 0;
            this.btnAnnounce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAnnounce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnounce.ForeColor = System.Drawing.Color.Silver;
            this.btnAnnounce.Location = new System.Drawing.Point(0, 0);
            this.btnAnnounce.Name = "btnAnnounce";
            this.btnAnnounce.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAnnounce.Size = new System.Drawing.Size(225, 40);
            this.btnAnnounce.TabIndex = 0;
            this.btnAnnounce.Text = "Announcements";
            this.btnAnnounce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnounce.UseVisualStyleBackColor = true;
            this.btnAnnounce.Click += new System.EventHandler(this.btnAnnounce_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.ForeColor = System.Drawing.Color.Silver;
            this.btnInformation.Image = global::housing.Properties.Resources.question;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(0, 92);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInformation.Size = new System.Drawing.Size(225, 45);
            this.btnInformation.TabIndex = 13;
            this.btnInformation.Text = "  Information";
            this.btnInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = global::housing.Properties.Resources.logout;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 528);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(225, 45);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 92);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::housing.Properties.Resources.LOGO2;
            this.pictureBox1.Location = new System.Drawing.Point(19, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.panelChildForm.Controls.Add(this.panelBackground);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(225, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1041, 573);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelBackground.BackgroundImage = global::housing.Properties.Resources.background1;
            this.panelBackground.BorderColor = System.Drawing.Color.White;
            this.panelBackground.BorderWidth = 5;
            this.panelBackground.Controls.Add(this.Forgotbtn);
            this.panelBackground.Controls.Add(this.btnLogin);
            this.panelBackground.Controls.Add(this.tbxCodeInput);
            this.panelBackground.Controls.Add(this.pictureQR);
            this.panelBackground.Controls.Add(this.lbWelcome);
            this.panelBackground.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelBackground.IsBorder = false;
            this.panelBackground.IsFill = true;
            this.panelBackground.Location = new System.Drawing.Point(15, 15);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Radius = 20;
            this.panelBackground.Size = new System.Drawing.Size(1011, 543);
            this.panelBackground.TabIndex = 0;
            // 
            // Forgotbtn
            // 
            this.Forgotbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.Forgotbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.Forgotbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.Forgotbtn.BorderRadius = 14;
            this.Forgotbtn.BorderSize = 0;
            this.Forgotbtn.FlatAppearance.BorderSize = 0;
            this.Forgotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forgotbtn.Font = new System.Drawing.Font("Cascadia Code", 12.75F);
            this.Forgotbtn.ForeColor = System.Drawing.Color.White;
            this.Forgotbtn.Location = new System.Drawing.Point(515, 437);
            this.Forgotbtn.Name = "Forgotbtn";
            this.Forgotbtn.Size = new System.Drawing.Size(150, 40);
            this.Forgotbtn.TabIndex = 4;
            this.Forgotbtn.Text = "RESET";
            this.Forgotbtn.TextColor = System.Drawing.Color.White;
            this.Forgotbtn.UseVisualStyleBackColor = false;
            this.Forgotbtn.Click += new System.EventHandler(this.Forgotbtn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnLogin.BorderRadius = 14;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cascadia Code", 12.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(353, 437);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxCodeInput
            // 
            this.tbxCodeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxCodeInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tbxCodeInput.BorderFocusColor = System.Drawing.Color.White;
            this.tbxCodeInput.BorderRadius = 14;
            this.tbxCodeInput.BorderSize = 2;
            this.tbxCodeInput.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodeInput.ForeColor = System.Drawing.Color.White;
            this.tbxCodeInput.Location = new System.Drawing.Point(383, 369);
            this.tbxCodeInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodeInput.Multiline = false;
            this.tbxCodeInput.Name = "tbxCodeInput";
            this.tbxCodeInput.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxCodeInput.PasswordChar = true;
            this.tbxCodeInput.PlaceholderColor = System.Drawing.Color.White;
            this.tbxCodeInput.PlaceholderText = "< ID >";
            this.tbxCodeInput.Size = new System.Drawing.Size(250, 32);
            this.tbxCodeInput.TabIndex = 2;
            this.tbxCodeInput.Texts = "";
            this.tbxCodeInput.UnderlinedStyle = true;
            this.tbxCodeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCodeInput_KeyPress);
            // 
            // pictureQR
            // 
            this.pictureQR.BackColor = System.Drawing.Color.Transparent;
            this.pictureQR.Image = global::housing.Properties.Resources.QR;
            this.pictureQR.Location = new System.Drawing.Point(412, 67);
            this.pictureQR.Name = "pictureQR";
            this.pictureQR.Size = new System.Drawing.Size(193, 191);
            this.pictureQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQR.TabIndex = 1;
            this.pictureQR.TabStop = false;
            // 
            // lbWelcome
            // 
            this.lbWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.lbWelcome.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.White;
            this.lbWelcome.Location = new System.Drawing.Point(241, 282);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(535, 46);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Hello Guest! Please scan the QR code to LOG IN!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1266, 573);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelInformation.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnAnnounce;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnContact;
        private CustomElements.RoundPanel panelBackground;
        private CustomElements.RoundTextBox tbxCodeInput;
        private System.Windows.Forms.PictureBox pictureQR;
        private CustomElements.RoundLabel lbWelcome;
        private CustomElements.RoundButton Forgotbtn;
        private CustomElements.RoundButton btnLogin;
    }
}

