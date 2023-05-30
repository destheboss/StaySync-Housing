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
            this.LBLdisplayInfo = new housing.CustomElements.RoundLabel();
            this.tbxAddOrRemove = new housing.CustomElements.RoundTextBox();
            this.roundPanelListBox1 = new housing.CustomElements.RoundPanelListBox();
            this.TBCcategory = new housing.CustomElements.CustomTabControl();
            this.TPfoodItems = new System.Windows.Forms.TabPage();
            this.LVfoodItems = new System.Windows.Forms.ListView();
            this.TPcleaningItems = new System.Windows.Forms.TabPage();
            this.LVcleaningItems = new System.Windows.Forms.ListView();
            this.TPtablewareItems = new System.Windows.Forms.TabPage();
            this.LVtablewareItems = new System.Windows.Forms.ListView();
            this.TPtoiletriesItems = new System.Windows.Forms.TabPage();
            this.LVbathroomItems = new System.Windows.Forms.ListView();
            this.CMBitem = new housing.CustomElements.CustomComboBox();
            this.CMBcategory = new housing.CustomElements.CustomComboBox();
            this.btnRemoveStock = new housing.CustomElements.RoundButton();
            this.btnAddStock = new housing.CustomElements.RoundButton();
            this.panelTop.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundPanelListBox1.SuspendLayout();
            this.TBCcategory.SuspendLayout();
            this.TPfoodItems.SuspendLayout();
            this.TPcleaningItems.SuspendLayout();
            this.TPtablewareItems.SuspendLayout();
            this.TPtoiletriesItems.SuspendLayout();
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
            this.panel2.Controls.Add(this.LBLdisplayInfo);
            this.panel2.Controls.Add(this.tbxAddOrRemove);
            this.panel2.Controls.Add(this.roundPanelListBox1);
            this.panel2.Controls.Add(this.CMBitem);
            this.panel2.Controls.Add(this.CMBcategory);
            this.panel2.Controls.Add(this.btnRemoveStock);
            this.panel2.Controls.Add(this.btnAddStock);
            this.panel2.Location = new System.Drawing.Point(13, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 396);
            this.panel2.TabIndex = 18;
            // 
            // LBLdisplayInfo
            // 
            this.LBLdisplayInfo.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLdisplayInfo.ForeColor = System.Drawing.Color.White;
            this.LBLdisplayInfo.Location = new System.Drawing.Point(608, 274);
            this.LBLdisplayInfo.Name = "LBLdisplayInfo";
            this.LBLdisplayInfo.Size = new System.Drawing.Size(259, 43);
            this.LBLdisplayInfo.TabIndex = 44;
            this.LBLdisplayInfo.Text = "Stock Information";
            // 
            // tbxAddOrRemove
            // 
            this.tbxAddOrRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxAddOrRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.tbxAddOrRemove.BorderFocusColor = System.Drawing.Color.White;
            this.tbxAddOrRemove.BorderRadius = 0;
            this.tbxAddOrRemove.BorderSize = 2;
            this.tbxAddOrRemove.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxAddOrRemove.ForeColor = System.Drawing.Color.Black;
            this.tbxAddOrRemove.Location = new System.Drawing.Point(611, 164);
            this.tbxAddOrRemove.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddOrRemove.Multiline = false;
            this.tbxAddOrRemove.Name = "tbxAddOrRemove";
            this.tbxAddOrRemove.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxAddOrRemove.PasswordChar = false;
            this.tbxAddOrRemove.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbxAddOrRemove.PlaceholderText = "< number >";
            this.tbxAddOrRemove.Size = new System.Drawing.Size(254, 33);
            this.tbxAddOrRemove.TabIndex = 43;
            this.tbxAddOrRemove.Texts = "";
            this.tbxAddOrRemove.UnderlinedStyle = false;
            this.tbxAddOrRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddOrRemove_KeyPress);
            // 
            // roundPanelListBox1
            // 
            this.roundPanelListBox1.Controls.Add(this.TBCcategory);
            this.roundPanelListBox1.Location = new System.Drawing.Point(48, 40);
            this.roundPanelListBox1.Name = "roundPanelListBox1";
            this.roundPanelListBox1.Size = new System.Drawing.Size(509, 312);
            this.roundPanelListBox1.TabIndex = 38;
            // 
            // TBCcategory
            // 
            this.TBCcategory.Controls.Add(this.TPfoodItems);
            this.TBCcategory.Controls.Add(this.TPcleaningItems);
            this.TBCcategory.Controls.Add(this.TPtablewareItems);
            this.TBCcategory.Controls.Add(this.TPtoiletriesItems);
            this.TBCcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBCcategory.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCcategory.Location = new System.Drawing.Point(0, 0);
            this.TBCcategory.Name = "TBCcategory";
            this.TBCcategory.SelectedIndex = 0;
            this.TBCcategory.Size = new System.Drawing.Size(509, 312);
            this.TBCcategory.TabIndex = 35;
            // 
            // TPfoodItems
            // 
            this.TPfoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.TPfoodItems.Controls.Add(this.LVfoodItems);
            this.TPfoodItems.Location = new System.Drawing.Point(4, 25);
            this.TPfoodItems.Name = "TPfoodItems";
            this.TPfoodItems.Padding = new System.Windows.Forms.Padding(3);
            this.TPfoodItems.Size = new System.Drawing.Size(501, 283);
            this.TPfoodItems.TabIndex = 0;
            this.TPfoodItems.Text = "Food";
            // 
            // LVfoodItems
            // 
            this.LVfoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.LVfoodItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVfoodItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVfoodItems.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.LVfoodItems.ForeColor = System.Drawing.Color.Black;
            this.LVfoodItems.HideSelection = false;
            this.LVfoodItems.Location = new System.Drawing.Point(3, 3);
            this.LVfoodItems.Name = "LVfoodItems";
            this.LVfoodItems.Size = new System.Drawing.Size(495, 277);
            this.LVfoodItems.TabIndex = 25;
            this.LVfoodItems.UseCompatibleStateImageBehavior = false;
            // 
            // TPcleaningItems
            // 
            this.TPcleaningItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.TPcleaningItems.Controls.Add(this.LVcleaningItems);
            this.TPcleaningItems.Location = new System.Drawing.Point(4, 25);
            this.TPcleaningItems.Name = "TPcleaningItems";
            this.TPcleaningItems.Padding = new System.Windows.Forms.Padding(3);
            this.TPcleaningItems.Size = new System.Drawing.Size(501, 283);
            this.TPcleaningItems.TabIndex = 1;
            this.TPcleaningItems.Text = "Cleaning";
            // 
            // LVcleaningItems
            // 
            this.LVcleaningItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.LVcleaningItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVcleaningItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVcleaningItems.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.LVcleaningItems.ForeColor = System.Drawing.Color.Black;
            this.LVcleaningItems.HideSelection = false;
            this.LVcleaningItems.Location = new System.Drawing.Point(3, 3);
            this.LVcleaningItems.Name = "LVcleaningItems";
            this.LVcleaningItems.Size = new System.Drawing.Size(495, 277);
            this.LVcleaningItems.TabIndex = 25;
            this.LVcleaningItems.UseCompatibleStateImageBehavior = false;
            // 
            // TPtablewareItems
            // 
            this.TPtablewareItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.TPtablewareItems.Controls.Add(this.LVtablewareItems);
            this.TPtablewareItems.Location = new System.Drawing.Point(4, 25);
            this.TPtablewareItems.Name = "TPtablewareItems";
            this.TPtablewareItems.Padding = new System.Windows.Forms.Padding(3);
            this.TPtablewareItems.Size = new System.Drawing.Size(501, 283);
            this.TPtablewareItems.TabIndex = 2;
            this.TPtablewareItems.Text = "Tableware";
            // 
            // LVtablewareItems
            // 
            this.LVtablewareItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.LVtablewareItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVtablewareItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVtablewareItems.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.LVtablewareItems.ForeColor = System.Drawing.Color.Black;
            this.LVtablewareItems.HideSelection = false;
            this.LVtablewareItems.Location = new System.Drawing.Point(3, 3);
            this.LVtablewareItems.Name = "LVtablewareItems";
            this.LVtablewareItems.Size = new System.Drawing.Size(495, 277);
            this.LVtablewareItems.TabIndex = 25;
            this.LVtablewareItems.UseCompatibleStateImageBehavior = false;
            // 
            // TPtoiletriesItems
            // 
            this.TPtoiletriesItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.TPtoiletriesItems.Controls.Add(this.LVbathroomItems);
            this.TPtoiletriesItems.Location = new System.Drawing.Point(4, 25);
            this.TPtoiletriesItems.Name = "TPtoiletriesItems";
            this.TPtoiletriesItems.Padding = new System.Windows.Forms.Padding(3);
            this.TPtoiletriesItems.Size = new System.Drawing.Size(501, 283);
            this.TPtoiletriesItems.TabIndex = 3;
            this.TPtoiletriesItems.Text = "Bathroom";
            // 
            // LVbathroomItems
            // 
            this.LVbathroomItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.LVbathroomItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVbathroomItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVbathroomItems.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.LVbathroomItems.ForeColor = System.Drawing.Color.Black;
            this.LVbathroomItems.HideSelection = false;
            this.LVbathroomItems.Location = new System.Drawing.Point(3, 3);
            this.LVbathroomItems.Name = "LVbathroomItems";
            this.LVbathroomItems.Size = new System.Drawing.Size(495, 277);
            this.LVbathroomItems.TabIndex = 25;
            this.LVbathroomItems.UseCompatibleStateImageBehavior = false;
            // 
            // CMBitem
            // 
            this.CMBitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CMBitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.CMBitem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.CMBitem.BorderSize = 1;
            this.CMBitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBitem.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.CMBitem.ForeColor = System.Drawing.Color.Black;
            this.CMBitem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.CMBitem.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.CMBitem.ListTextColor = System.Drawing.Color.Black;
            this.CMBitem.Location = new System.Drawing.Point(611, 123);
            this.CMBitem.MinimumSize = new System.Drawing.Size(200, 30);
            this.CMBitem.Name = "CMBitem";
            this.CMBitem.Padding = new System.Windows.Forms.Padding(1);
            this.CMBitem.Size = new System.Drawing.Size(254, 30);
            this.CMBitem.TabIndex = 42;
            this.CMBitem.Texts = "Product";
            // 
            // CMBcategory
            // 
            this.CMBcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CMBcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.CMBcategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.CMBcategory.BorderSize = 1;
            this.CMBcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBcategory.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.CMBcategory.ForeColor = System.Drawing.Color.Black;
            this.CMBcategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.CMBcategory.Items.AddRange(new object[] {
            "Foods",
            "Cleaning products",
            "Bathroom",
            "Tableware"});
            this.CMBcategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.CMBcategory.ListTextColor = System.Drawing.Color.Black;
            this.CMBcategory.Location = new System.Drawing.Point(611, 83);
            this.CMBcategory.MinimumSize = new System.Drawing.Size(200, 30);
            this.CMBcategory.Name = "CMBcategory";
            this.CMBcategory.Padding = new System.Windows.Forms.Padding(1);
            this.CMBcategory.Size = new System.Drawing.Size(254, 30);
            this.CMBcategory.TabIndex = 41;
            this.CMBcategory.Texts = "Category";
            this.CMBcategory.OnSelectedIndexChanged += new System.EventHandler(this.CMBcategory_OnSelectedIndexChanged);
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
            this.btnRemoveStock.Image = global::housing.Properties.Resources.down;
            this.btnRemoveStock.Location = new System.Drawing.Point(746, 212);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(121, 43);
            this.btnRemoveStock.TabIndex = 40;
            this.btnRemoveStock.TextColor = System.Drawing.Color.White;
            this.btnRemoveStock.UseVisualStyleBackColor = false;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnAddStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnAddStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(34)))), ((int)(((byte)(83)))));
            this.btnAddStock.BorderRadius = 14;
            this.btnAddStock.BorderSize = 0;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Image = global::housing.Properties.Resources.up7;
            this.btnAddStock.Location = new System.Drawing.Point(608, 212);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(121, 43);
            this.btnAddStock.TabIndex = 39;
            this.btnAddStock.TextColor = System.Drawing.Color.White;
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
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
            this.Load += new System.EventHandler(this.TenantStock_Load);
            this.Leave += new System.EventHandler(this.TenantStock_Leave);
            this.panelTop.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.roundPanelListBox1.ResumeLayout(false);
            this.TBCcategory.ResumeLayout(false);
            this.TPfoodItems.ResumeLayout(false);
            this.TPcleaningItems.ResumeLayout(false);
            this.TPtablewareItems.ResumeLayout(false);
            this.TPtoiletriesItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private CustomElements.RoundPanel roundPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private CustomElements.RoundLabel LBLdisplayInfo;
        private CustomElements.RoundTextBox tbxAddOrRemove;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private CustomElements.CustomTabControl TBCcategory;
        private System.Windows.Forms.TabPage TPfoodItems;
        private System.Windows.Forms.ListView LVfoodItems;
        private System.Windows.Forms.TabPage TPcleaningItems;
        private System.Windows.Forms.ListView LVcleaningItems;
        private System.Windows.Forms.TabPage TPtablewareItems;
        private System.Windows.Forms.ListView LVtablewareItems;
        private System.Windows.Forms.TabPage TPtoiletriesItems;
        private System.Windows.Forms.ListView LVbathroomItems;
        private CustomElements.CustomComboBox CMBitem;
        private CustomElements.CustomComboBox CMBcategory;
        private CustomElements.RoundButton btnRemoveStock;
        private CustomElements.RoundButton btnAddStock;
    }
}