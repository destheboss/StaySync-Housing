namespace housing
{
    partial class Announce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announce));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.roundPanel1 = new housing.CustomElements.RoundPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxAnnouncementIndex = new housing.CustomElements.RoundTextBox();
            this.roundPanelListBox1 = new housing.CustomElements.RoundPanelListBox();
            this.lbxAnnouncements = new System.Windows.Forms.ListBox();
            this.btnRefresh = new housing.CustomElements.RoundButton();
            this.lblSelectAnn = new System.Windows.Forms.Label();
            this.roundButton1 = new housing.CustomElements.RoundButton();
            this.tbxCodeInput = new housing.CustomElements.RoundTextBox();
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
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(911, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(130, 53);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "  Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundPanel1.BackgroundImage")));
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
            this.panel2.Controls.Add(this.tbxAnnouncementIndex);
            this.panel2.Controls.Add(this.roundPanelListBox1);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lblSelectAnn);
            this.panel2.Controls.Add(this.roundButton1);
            this.panel2.Location = new System.Drawing.Point(13, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 396);
            this.panel2.TabIndex = 14;
            // 
            // tbxAnnouncementIndex
            // 
            this.tbxAnnouncementIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxAnnouncementIndex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tbxAnnouncementIndex.BorderFocusColor = System.Drawing.Color.White;
            this.tbxAnnouncementIndex.BorderRadius = 12;
            this.tbxAnnouncementIndex.BorderSize = 2;
            this.tbxAnnouncementIndex.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAnnouncementIndex.ForeColor = System.Drawing.Color.White;
            this.tbxAnnouncementIndex.Location = new System.Drawing.Point(643, 199);
            this.tbxAnnouncementIndex.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAnnouncementIndex.Multiline = false;
            this.tbxAnnouncementIndex.Name = "tbxAnnouncementIndex";
            this.tbxAnnouncementIndex.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxAnnouncementIndex.PasswordChar = false;
            this.tbxAnnouncementIndex.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxAnnouncementIndex.PlaceholderText = "< number >";
            this.tbxAnnouncementIndex.Size = new System.Drawing.Size(121, 32);
            this.tbxAnnouncementIndex.TabIndex = 17;
            this.tbxAnnouncementIndex.Texts = "";
            this.tbxAnnouncementIndex.UnderlinedStyle = true;
            // 
            // roundPanelListBox1
            // 
            this.roundPanelListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.roundPanelListBox1.Controls.Add(this.lbxAnnouncements);
            this.roundPanelListBox1.Location = new System.Drawing.Point(38, 65);
            this.roundPanelListBox1.Name = "roundPanelListBox1";
            this.roundPanelListBox1.Size = new System.Drawing.Size(565, 272);
            this.roundPanelListBox1.TabIndex = 16;
            // 
            // lbxAnnouncements
            // 
            this.lbxAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.lbxAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAnnouncements.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAnnouncements.ForeColor = System.Drawing.Color.White;
            this.lbxAnnouncements.FormattingEnabled = true;
            this.lbxAnnouncements.ItemHeight = 16;
            this.lbxAnnouncements.Location = new System.Drawing.Point(0, 0);
            this.lbxAnnouncements.Name = "lbxAnnouncements";
            this.lbxAnnouncements.Size = new System.Drawing.Size(565, 272);
            this.lbxAnnouncements.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnRefresh.BorderRadius = 14;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(766, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 43);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblSelectAnn
            // 
            this.lblSelectAnn.AutoSize = true;
            this.lblSelectAnn.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectAnn.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAnn.ForeColor = System.Drawing.Color.White;
            this.lblSelectAnn.Location = new System.Drawing.Point(642, 173);
            this.lblSelectAnn.Name = "lblSelectAnn";
            this.lblSelectAnn.Size = new System.Drawing.Size(217, 21);
            this.lblSelectAnn.TabIndex = 13;
            this.lblSelectAnn.Text = "Select Announcement No.\r\n";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.roundButton1.BorderRadius = 14;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundButton1.Location = new System.Drawing.Point(643, 238);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(244, 43);
            this.roundButton1.TabIndex = 15;
            this.roundButton1.Text = "More Details";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // tbxCodeInput
            // 
            this.tbxCodeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxCodeInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.tbxCodeInput.BorderFocusColor = System.Drawing.Color.White;
            this.tbxCodeInput.BorderRadius = 12;
            this.tbxCodeInput.BorderSize = 2;
            this.tbxCodeInput.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodeInput.ForeColor = System.Drawing.Color.White;
            this.tbxCodeInput.Location = new System.Drawing.Point(643, 199);
            this.tbxCodeInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodeInput.Multiline = false;
            this.tbxCodeInput.Name = "tbxCodeInput";
            this.tbxCodeInput.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxCodeInput.PasswordChar = false;
            this.tbxCodeInput.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxCodeInput.PlaceholderText = "announcement no.";
            this.tbxCodeInput.Size = new System.Drawing.Size(168, 32);
            this.tbxCodeInput.TabIndex = 14;
            this.tbxCodeInput.Texts = "";
            this.tbxCodeInput.UnderlinedStyle = true;
            // 
            // Announce
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
            this.Name = "Announce";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestAnnounce";
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
        private CustomElements.RoundButton btnRefresh;
        private System.Windows.Forms.Label lblSelectAnn;
        private CustomElements.RoundButton roundButton1;
        private CustomElements.RoundTextBox tbxCodeInput;
        private System.Windows.Forms.Panel panel2;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private System.Windows.Forms.ListBox lbxAnnouncements;
        private CustomElements.RoundTextBox tbxAnnouncementIndex;
    }
}