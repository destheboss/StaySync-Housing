namespace housing.Classes
{
    partial class Forgot
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCaption = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCode = new System.Windows.Forms.Panel();
            this.tbxCode = new housing.CustomElements.RoundTextBox();
            this.btnVerify = new housing.CustomElements.RoundButton();
            this.tbxNumber = new housing.CustomElements.RoundTextBox();
            this.btnSend = new housing.CustomElements.RoundButton();
            this.panel2.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.panelCode);
            this.panel2.Controls.Add(this.labelCaption);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lbPhoneNumber);
            this.panel2.Controls.Add(this.tbxNumber);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 233);
            this.panel2.TabIndex = 17;
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.labelCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.labelCaption.Location = new System.Drawing.Point(16, 10);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(112, 16);
            this.labelCaption.TabIndex = 47;
            this.labelCaption.Text = "< FORGOT PAGE >";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(371, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lbPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lbPhoneNumber.Location = new System.Drawing.Point(74, 68);
            this.lbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(200, 18);
            this.lbPhoneNumber.TabIndex = 43;
            this.lbPhoneNumber.Text = "Enter your phone number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Enter the received code:";
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.label1);
            this.panelCode.Controls.Add(this.tbxCode);
            this.panelCode.Controls.Add(this.btnVerify);
            this.panelCode.Location = new System.Drawing.Point(19, 36);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(372, 175);
            this.panelCode.TabIndex = 48;
            // 
            // tbxCode
            // 
            this.tbxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxCode.BorderFocusColor = System.Drawing.Color.White;
            this.tbxCode.BorderRadius = 10;
            this.tbxCode.BorderSize = 2;
            this.tbxCode.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxCode.ForeColor = System.Drawing.Color.Black;
            this.tbxCode.Location = new System.Drawing.Point(58, 58);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCode.Multiline = false;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxCode.PasswordChar = false;
            this.tbxCode.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxCode.PlaceholderText = "< code >";
            this.tbxCode.Size = new System.Drawing.Size(256, 33);
            this.tbxCode.TabIndex = 45;
            this.tbxCode.Texts = "";
            this.tbxCode.UnderlinedStyle = false;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnVerify.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnVerify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnVerify.BorderRadius = 14;
            this.btnVerify.BorderSize = 0;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerify.Location = new System.Drawing.Point(116, 106);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(140, 43);
            this.btnVerify.TabIndex = 44;
            this.btnVerify.Text = "Verify";
            this.btnVerify.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // tbxNumber
            // 
            this.tbxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxNumber.BorderFocusColor = System.Drawing.Color.White;
            this.tbxNumber.BorderRadius = 10;
            this.tbxNumber.BorderSize = 2;
            this.tbxNumber.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxNumber.ForeColor = System.Drawing.Color.Black;
            this.tbxNumber.Location = new System.Drawing.Point(77, 94);
            this.tbxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNumber.Multiline = false;
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxNumber.PasswordChar = false;
            this.tbxNumber.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxNumber.PlaceholderText = "< number >";
            this.tbxNumber.Size = new System.Drawing.Size(256, 33);
            this.tbxNumber.TabIndex = 37;
            this.tbxNumber.Texts = "";
            this.tbxNumber.UnderlinedStyle = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnSend.BorderRadius = 14;
            this.btnSend.BorderSize = 0;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.Location = new System.Drawing.Point(135, 142);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 43);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send Code";
            this.btnSend.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(417, 239);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Forgot";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.Label label1;
        private CustomElements.RoundTextBox tbxCode;
        private CustomElements.RoundButton btnVerify;
        private System.Windows.Forms.Label lbPhoneNumber;
        private CustomElements.RoundTextBox tbxNumber;
        private CustomElements.RoundButton btnSend;
    }
}