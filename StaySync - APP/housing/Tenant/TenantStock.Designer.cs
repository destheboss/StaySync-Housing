namespace housing
{
    partial class TenantStock
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
            this.CMBitem = new housing.CustomElements.CustomComboBox();
            this.CMBcategory = new housing.CustomElements.CustomComboBox();
            this.btnRemoveStock = new housing.CustomElements.RoundButton();
            this.BTNaddStock = new housing.CustomElements.RoundButton();
            this.TBCcategory = new housing.CustomElements.CustomTabControl();
            this.LVfoodItems = new System.Windows.Forms.TabPage();
            this.LVcleaningItems = new System.Windows.Forms.TabPage();
            this.LVtablewareItems = new System.Windows.Forms.TabPage();
            this.LVtoiletriesItems = new System.Windows.Forms.TabPage();
            this.roundPanelListBox1 = new housing.CustomElements.RoundPanelListBox();
            this.tbxAddOrRemove = new housing.CustomElements.RoundTextBox();
            this.panelTop.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TBCcategory.SuspendLayout();
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
            this.panel2.Controls.Add(this.tbxAddOrRemove);
            this.panel2.Controls.Add(this.roundPanelListBox1);
            this.panel2.Controls.Add(this.CMBitem);
            this.panel2.Controls.Add(this.CMBcategory);
            this.panel2.Controls.Add(this.btnRemoveStock);
            this.panel2.Controls.Add(this.BTNaddStock);
            this.panel2.Location = new System.Drawing.Point(13, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 396);
            this.panel2.TabIndex = 18;
            // 
            // CMBitem
            // 
            this.CMBitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CMBitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.CMBitem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.CMBitem.BorderSize = 1;
            this.CMBitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CMBitem.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.CMBitem.ForeColor = System.Drawing.Color.White;
            this.CMBitem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.CMBitem.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CMBitem.ListTextColor = System.Drawing.Color.White;
            this.CMBitem.Location = new System.Drawing.Point(611, 165);
            this.CMBitem.MinimumSize = new System.Drawing.Size(200, 30);
            this.CMBitem.Name = "CMBitem";
            this.CMBitem.Padding = new System.Windows.Forms.Padding(1);
            this.CMBitem.Size = new System.Drawing.Size(254, 30);
            this.CMBitem.TabIndex = 33;
            this.CMBitem.Texts = "";
            // 
            // CMBcategory
            // 
            this.CMBcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CMBcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.CMBcategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.CMBcategory.BorderSize = 1;
            this.CMBcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CMBcategory.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.CMBcategory.ForeColor = System.Drawing.Color.White;
            this.CMBcategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.CMBcategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CMBcategory.ListTextColor = System.Drawing.Color.White;
            this.CMBcategory.Location = new System.Drawing.Point(611, 125);
            this.CMBcategory.MinimumSize = new System.Drawing.Size(200, 30);
            this.CMBcategory.Name = "CMBcategory";
            this.CMBcategory.Padding = new System.Windows.Forms.Padding(1);
            this.CMBcategory.Size = new System.Drawing.Size(254, 30);
            this.CMBcategory.TabIndex = 32;
            this.CMBcategory.Texts = "";
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnRemoveStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnRemoveStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnRemoveStock.BorderRadius = 14;
            this.btnRemoveStock.BorderSize = 0;
            this.btnRemoveStock.FlatAppearance.BorderSize = 0;
            this.btnRemoveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStock.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStock.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveStock.Location = new System.Drawing.Point(746, 254);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(121, 43);
            this.btnRemoveStock.TabIndex = 18;
            this.btnRemoveStock.Text = "Stock ↓";
            this.btnRemoveStock.TextColor = System.Drawing.Color.White;
            this.btnRemoveStock.UseVisualStyleBackColor = false;
            // 
            // BTNaddStock
            // 
            this.BTNaddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.BTNaddStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.BTNaddStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.BTNaddStock.BorderRadius = 14;
            this.BTNaddStock.BorderSize = 0;
            this.BTNaddStock.FlatAppearance.BorderSize = 0;
            this.BTNaddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNaddStock.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddStock.ForeColor = System.Drawing.Color.White;
            this.BTNaddStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNaddStock.Location = new System.Drawing.Point(608, 254);
            this.BTNaddStock.Name = "BTNaddStock";
            this.BTNaddStock.Size = new System.Drawing.Size(121, 43);
            this.BTNaddStock.TabIndex = 11;
            this.BTNaddStock.Text = "Stock ↑";
            this.BTNaddStock.TextColor = System.Drawing.Color.White;
            this.BTNaddStock.UseVisualStyleBackColor = false;
            // 
            // TBCcategory
            // 
            this.TBCcategory.Controls.Add(this.LVfoodItems);
            this.TBCcategory.Controls.Add(this.LVcleaningItems);
            this.TBCcategory.Controls.Add(this.LVtablewareItems);
            this.TBCcategory.Controls.Add(this.LVtoiletriesItems);
            this.TBCcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBCcategory.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCcategory.Location = new System.Drawing.Point(0, 0);
            this.TBCcategory.Name = "TBCcategory";
            this.TBCcategory.SelectedIndex = 0;
            this.TBCcategory.Size = new System.Drawing.Size(509, 312);
            this.TBCcategory.TabIndex = 35;
            // 
            // LVfoodItems
            // 
            this.LVfoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.LVfoodItems.Location = new System.Drawing.Point(4, 25);
            this.LVfoodItems.Name = "LVfoodItems";
            this.LVfoodItems.Padding = new System.Windows.Forms.Padding(3);
            this.LVfoodItems.Size = new System.Drawing.Size(501, 283);
            this.LVfoodItems.TabIndex = 0;
            this.LVfoodItems.Text = "Food";
            // 
            // LVcleaningItems
            // 
            this.LVcleaningItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.LVcleaningItems.Location = new System.Drawing.Point(4, 25);
            this.LVcleaningItems.Name = "LVcleaningItems";
            this.LVcleaningItems.Padding = new System.Windows.Forms.Padding(3);
            this.LVcleaningItems.Size = new System.Drawing.Size(381, 269);
            this.LVcleaningItems.TabIndex = 1;
            this.LVcleaningItems.Text = "Cleaning";
            // 
            // LVtablewareItems
            // 
            this.LVtablewareItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.LVtablewareItems.Location = new System.Drawing.Point(4, 25);
            this.LVtablewareItems.Name = "LVtablewareItems";
            this.LVtablewareItems.Padding = new System.Windows.Forms.Padding(3);
            this.LVtablewareItems.Size = new System.Drawing.Size(381, 269);
            this.LVtablewareItems.TabIndex = 2;
            this.LVtablewareItems.Text = "Tableware";
            // 
            // LVtoiletriesItems
            // 
            this.LVtoiletriesItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.LVtoiletriesItems.Location = new System.Drawing.Point(4, 25);
            this.LVtoiletriesItems.Name = "LVtoiletriesItems";
            this.LVtoiletriesItems.Padding = new System.Windows.Forms.Padding(3);
            this.LVtoiletriesItems.Size = new System.Drawing.Size(381, 269);
            this.LVtoiletriesItems.TabIndex = 3;
            this.LVtoiletriesItems.Text = "Bathroom";
            // 
            // roundPanelListBox1
            // 
            this.roundPanelListBox1.Controls.Add(this.TBCcategory);
            this.roundPanelListBox1.Location = new System.Drawing.Point(48, 40);
            this.roundPanelListBox1.Name = "roundPanelListBox1";
            this.roundPanelListBox1.Size = new System.Drawing.Size(509, 312);
            this.roundPanelListBox1.TabIndex = 0;
            // 
            // tbxAddOrRemove
            // 
            this.tbxAddOrRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxAddOrRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxAddOrRemove.BorderFocusColor = System.Drawing.Color.White;
            this.tbxAddOrRemove.BorderRadius = 0;
            this.tbxAddOrRemove.BorderSize = 2;
            this.tbxAddOrRemove.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxAddOrRemove.ForeColor = System.Drawing.Color.White;
            this.tbxAddOrRemove.Location = new System.Drawing.Point(611, 206);
            this.tbxAddOrRemove.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddOrRemove.Multiline = false;
            this.tbxAddOrRemove.Name = "tbxAddOrRemove";
            this.tbxAddOrRemove.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxAddOrRemove.PasswordChar = false;
            this.tbxAddOrRemove.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxAddOrRemove.PlaceholderText = "< increment number >";
            this.tbxAddOrRemove.Size = new System.Drawing.Size(254, 33);
            this.tbxAddOrRemove.TabIndex = 35;
            this.tbxAddOrRemove.Texts = "";
            this.tbxAddOrRemove.UnderlinedStyle = false;
            // 
            // TenantStock
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
            this.Name = "TenantStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestAttendance";
            this.panelTop.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TBCcategory.ResumeLayout(false);
            this.roundPanelListBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private CustomElements.RoundPanel roundPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private CustomElements.CustomComboBox CMBitem;
        private CustomElements.CustomComboBox CMBcategory;
        private CustomElements.RoundButton btnRemoveStock;
        private CustomElements.RoundButton BTNaddStock;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private CustomElements.CustomTabControl TBCcategory;
        private System.Windows.Forms.TabPage LVfoodItems;
        private System.Windows.Forms.TabPage LVcleaningItems;
        private System.Windows.Forms.TabPage LVtablewareItems;
        private System.Windows.Forms.TabPage LVtoiletriesItems;
        private CustomElements.RoundTextBox tbxAddOrRemove;
    }
}