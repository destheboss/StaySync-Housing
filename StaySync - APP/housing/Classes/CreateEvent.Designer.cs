namespace housing.Classes
{
    partial class CreateEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescription = new housing.CustomElements.RoundTextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.tbxTitle = new housing.CustomElements.RoundTextBox();
            this.cmbEndTime = new housing.CustomElements.CustomComboBox();
            this.cmbStartTime = new housing.CustomElements.CustomComboBox();
            this.cmbYear = new housing.CustomElements.CustomComboBox();
            this.cmbMonth = new housing.CustomElements.CustomComboBox();
            this.cmbDay = new housing.CustomElements.CustomComboBox();
            this.btnCreate = new housing.CustomElements.RoundButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.labelCaption);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbxDescription);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.lbEndTime);
            this.panel2.Controls.Add(this.lbStartTime);
            this.panel2.Controls.Add(this.lbYear);
            this.panel2.Controls.Add(this.lbMonth);
            this.panel2.Controls.Add(this.lbDay);
            this.panel2.Controls.Add(this.tbxTitle);
            this.panel2.Controls.Add(this.cmbEndTime);
            this.panel2.Controls.Add(this.cmbStartTime);
            this.panel2.Controls.Add(this.cmbYear);
            this.panel2.Controls.Add(this.cmbMonth);
            this.panel2.Controls.Add(this.cmbDay);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 450);
            this.panel2.TabIndex = 17;
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.labelCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.labelCaption.Location = new System.Drawing.Point(20, 10);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(119, 16);
            this.labelCaption.TabIndex = 47;
            this.labelCaption.Text = "< CREATE EVENT >";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(617, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Description";
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxDescription.BorderFocusColor = System.Drawing.Color.White;
            this.tbxDescription.BorderRadius = 0;
            this.tbxDescription.BorderSize = 2;
            this.tbxDescription.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxDescription.ForeColor = System.Drawing.Color.Black;
            this.tbxDescription.Location = new System.Drawing.Point(23, 274);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxDescription.PasswordChar = false;
            this.tbxDescription.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxDescription.PlaceholderText = "< add a description >";
            this.tbxDescription.Size = new System.Drawing.Size(612, 107);
            this.tbxDescription.TabIndex = 44;
            this.tbxDescription.Texts = "";
            this.tbxDescription.UnderlinedStyle = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(20, 178);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(48, 18);
            this.lbTitle.TabIndex = 43;
            this.lbTitle.Text = "TITLE";
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lbEndTime.ForeColor = System.Drawing.Color.White;
            this.lbEndTime.Location = new System.Drawing.Point(340, 113);
            this.lbEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(104, 18);
            this.lbEndTime.TabIndex = 42;
            this.lbEndTime.Text = "< END TIME >";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lbStartTime.ForeColor = System.Drawing.Color.White;
            this.lbStartTime.Location = new System.Drawing.Point(20, 113);
            this.lbStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(120, 18);
            this.lbStartTime.TabIndex = 41;
            this.lbStartTime.Text = "< START TIME >";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lbYear.ForeColor = System.Drawing.Color.White;
            this.lbYear.Location = new System.Drawing.Point(432, 45);
            this.lbYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(40, 18);
            this.lbYear.TabIndex = 40;
            this.lbYear.Text = "YEAR";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lbMonth.ForeColor = System.Drawing.Color.White;
            this.lbMonth.Location = new System.Drawing.Point(226, 45);
            this.lbMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(48, 18);
            this.lbMonth.TabIndex = 39;
            this.lbMonth.Text = "MONTH";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lbDay.ForeColor = System.Drawing.Color.White;
            this.lbDay.Location = new System.Drawing.Point(20, 45);
            this.lbDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(32, 18);
            this.lbDay.TabIndex = 38;
            this.lbDay.Text = "DAY";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxTitle.BorderFocusColor = System.Drawing.Color.White;
            this.tbxTitle.BorderRadius = 0;
            this.tbxTitle.BorderSize = 2;
            this.tbxTitle.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxTitle.ForeColor = System.Drawing.Color.Black;
            this.tbxTitle.Location = new System.Drawing.Point(23, 204);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTitle.Multiline = false;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxTitle.PasswordChar = false;
            this.tbxTitle.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxTitle.PlaceholderText = "< title >";
            this.tbxTitle.Size = new System.Drawing.Size(612, 33);
            this.tbxTitle.TabIndex = 37;
            this.tbxTitle.Texts = "";
            this.tbxTitle.UnderlinedStyle = false;
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbEndTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbEndTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbEndTime.BorderSize = 1;
            this.cmbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndTime.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.cmbEndTime.ForeColor = System.Drawing.Color.Black;
            this.cmbEndTime.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbEndTime.Items.AddRange(new object[] {
            "00:00",
            "00:15",
            "00:30",
            "00:45",
            "01:00",
            "01:15",
            "01:30",
            "01:45",
            "02:00",
            "02:15",
            "02:30",
            "02:45",
            "03:00",
            "03:15",
            "03:30",
            "03:45",
            "04:00",
            "04:15",
            "04:30",
            "04:45",
            "05:00",
            "05:15",
            "05:30",
            "05:45",
            "06:00",
            "06:15",
            "06:30",
            "06:45",
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "20:00",
            "20:15",
            "20:30",
            "20:45",
            "21:00",
            "21:15",
            "21:30",
            "21:45",
            "22:00",
            "22:15",
            "22:30",
            "22:45",
            "23:00",
            "23:15",
            "23:30",
            "23:45"});
            this.cmbEndTime.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbEndTime.ListTextColor = System.Drawing.Color.Black;
            this.cmbEndTime.Location = new System.Drawing.Point(337, 137);
            this.cmbEndTime.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Padding = new System.Windows.Forms.Padding(1);
            this.cmbEndTime.Size = new System.Drawing.Size(298, 30);
            this.cmbEndTime.TabIndex = 35;
            this.cmbEndTime.Texts = "XX:XX";
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStartTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbStartTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbStartTime.BorderSize = 1;
            this.cmbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartTime.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.cmbStartTime.ForeColor = System.Drawing.Color.Black;
            this.cmbStartTime.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbStartTime.Items.AddRange(new object[] {
            "00:00",
            "00:15",
            "00:30",
            "00:45",
            "01:00",
            "01:15",
            "01:30",
            "01:45",
            "02:00",
            "02:15",
            "02:30",
            "02:45",
            "03:00",
            "03:15",
            "03:30",
            "03:45",
            "04:00",
            "04:15",
            "04:30",
            "04:45",
            "05:00",
            "05:15",
            "05:30",
            "05:45",
            "06:00",
            "06:15",
            "06:30",
            "06:45",
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "20:00",
            "20:15",
            "20:30",
            "20:45",
            "21:00",
            "21:15",
            "21:30",
            "21:45",
            "22:00",
            "22:15",
            "22:30",
            "22:45",
            "23:00",
            "23:15",
            "23:30",
            "23:45"});
            this.cmbStartTime.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbStartTime.ListTextColor = System.Drawing.Color.Black;
            this.cmbStartTime.Location = new System.Drawing.Point(23, 137);
            this.cmbStartTime.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Padding = new System.Windows.Forms.Padding(1);
            this.cmbStartTime.Size = new System.Drawing.Size(298, 30);
            this.cmbStartTime.TabIndex = 36;
            this.cmbStartTime.Texts = "XX:XX";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbYear.BorderSize = 1;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.cmbYear.ForeColor = System.Drawing.Color.Black;
            this.cmbYear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbYear.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbYear.ListTextColor = System.Drawing.Color.Black;
            this.cmbYear.Location = new System.Drawing.Point(435, 69);
            this.cmbYear.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Padding = new System.Windows.Forms.Padding(1);
            this.cmbYear.Size = new System.Drawing.Size(200, 30);
            this.cmbYear.TabIndex = 35;
            this.cmbYear.Texts = "XXXX";
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbMonth.BorderSize = 1;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.cmbMonth.ForeColor = System.Drawing.Color.Black;
            this.cmbMonth.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMonth.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbMonth.ListTextColor = System.Drawing.Color.Black;
            this.cmbMonth.Location = new System.Drawing.Point(229, 69);
            this.cmbMonth.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Padding = new System.Windows.Forms.Padding(1);
            this.cmbMonth.Size = new System.Drawing.Size(200, 30);
            this.cmbMonth.TabIndex = 34;
            this.cmbMonth.Texts = "XX";
            // 
            // cmbDay
            // 
            this.cmbDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbDay.BorderSize = 1;
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.cmbDay.ForeColor = System.Drawing.Color.Black;
            this.cmbDay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.cmbDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.cmbDay.ListTextColor = System.Drawing.Color.Black;
            this.cmbDay.Location = new System.Drawing.Point(23, 69);
            this.cmbDay.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Padding = new System.Windows.Forms.Padding(1);
            this.cmbDay.Size = new System.Drawing.Size(200, 30);
            this.cmbDay.TabIndex = 33;
            this.cmbDay.Texts = "XX";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnCreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnCreate.BorderRadius = 14;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(257, 394);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 43);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(663, 456);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateEvent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CustomElements.RoundTextBox tbxDescription;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbDay;
        private CustomElements.RoundTextBox tbxTitle;
        private CustomElements.CustomComboBox cmbEndTime;
        private CustomElements.CustomComboBox cmbStartTime;
        private CustomElements.CustomComboBox cmbYear;
        private CustomElements.CustomComboBox cmbMonth;
        private CustomElements.CustomComboBox cmbDay;
        private CustomElements.RoundButton btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelCaption;
    }
}