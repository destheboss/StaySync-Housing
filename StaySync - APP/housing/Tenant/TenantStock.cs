using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing
{
    public partial class TenantStock : Form
    {
        private User _user = new User();
        private StockItemManager _itemManager = new StockItemManager();
        public TenantStock()
        {
            InitializeComponent();
            InitializeListView(LVfoodItems);
            InitializeListView(LVcleaningItems);
            InitializeListView(LVbathroomItems);
            InitializeListView(LVtablewareItems);

            this.LVfoodItems.SelectedIndexChanged += new System.EventHandler(this.LVItems_SelectedIndexChanged);
            this.LVcleaningItems.SelectedIndexChanged += new System.EventHandler(this.LVItems_SelectedIndexChanged);
            this.LVbathroomItems.SelectedIndexChanged += new System.EventHandler(this.LVItems_SelectedIndexChanged);
            this.LVtablewareItems.SelectedIndexChanged += new System.EventHandler(this.LVItems_SelectedIndexChanged);
        }

        private void InitializeListView(ListView listView)
        {
            listView.View = View.Details;
            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.FullRowSelect = true;
            listView.Columns.Add("", -2);
            listView.MultiSelect = false;
            listView.Scrollable = false;
        }

        private void TenantStock_Load(object sender, EventArgs e)
        {
            this._itemManager.LoadUpLists();
            RefreshListBoxes();
        }

        public void RefreshListBoxes()
        {
            RefreshListView(LVfoodItems, 0);
            RefreshListView(LVcleaningItems, 1);
            RefreshListView(LVbathroomItems, 2);
            RefreshListView(LVtablewareItems, 3);
        }

        public void RefreshListView(ListView listView, int categoryIndex)
        {
            listView.Items.Clear();
            List<StockItem> items = this._itemManager.GetTheList(categoryIndex);
            foreach (StockItem item in items)
            {
                ListViewItem listViewItem = new ListViewItem("╠ " + item.Name);
                listView.Items.Add(listViewItem);
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CMBcategory.Texts) || string.IsNullOrWhiteSpace(CMBitem.Texts) || string.IsNullOrWhiteSpace(tbxAddOrRemove.Texts))
                {
                    RJMessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!int.TryParse(tbxAddOrRemove.Texts, out int amount) || amount <= 0)
                {
                    RJMessageBox.Show("Please enter a valid value.");
                    return;
                }

                int categoryIndex = CMBcategory.SelectedIndex;
                int itemIndex = CMBitem.SelectedIndex;

                if (categoryIndex == -1 || itemIndex == -1)
                {
                    RJMessageBox.Show("Please select a valid category and item.");
                    return;
                }

                if (_itemManager.AreTheInputsOkay(CMBcategory.Texts, CMBitem.Texts, amount))
                {
                    _itemManager.AddAndUpdate(categoryIndex, itemIndex, amount);
                    _itemManager.AddChangeToList(_user.GetName(), categoryIndex, itemIndex, "increased", amount);
                    RefreshListBoxes();
                    RJMessageBox.Show("Stock has been increased!");
                }
                else
                {
                    RJMessageBox.Show("Please fill in all fields correctly.");
                }

                CMBcategory.SelectedIndex = 0;
                CMBitem.SelectedIndex = 0;
                tbxAddOrRemove.Texts = string.Empty;
                _itemManager.UpdateTheTextfile();
                _itemManager.WriteTransactionsToFile();
                UpdateSelectedStockDisplay();
            }
            catch (Exception)
            {
                RJMessageBox.Show("Please fill in all fields correctly.");
            }
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CMBcategory.Texts) || string.IsNullOrWhiteSpace(CMBitem.Texts) || string.IsNullOrWhiteSpace(tbxAddOrRemove.Texts))
                {
                    RJMessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!int.TryParse(tbxAddOrRemove.Texts, out int amount) || amount <= 0)
                {
                    RJMessageBox.Show("Please enter a valid value.");
                    return;
                }

                int categoryIndex = CMBcategory.SelectedIndex;
                int itemIndex = CMBitem.SelectedIndex;

                if (categoryIndex == -1 || itemIndex == -1)
                {
                    RJMessageBox.Show("Please select a valid category and item.");
                    return;
                }

                if (_itemManager.AreTheInputsOkay(CMBcategory.Texts, CMBitem.Texts, amount))
                {
                    if (_itemManager.CanWeRemove(categoryIndex, itemIndex, amount))
                    {
                        _itemManager.RemoveAndUpdate(categoryIndex, itemIndex, amount);
                        _itemManager.AddChangeToList(_user.GetName(), categoryIndex, itemIndex, "decreased", amount);
                        RefreshListBoxes();
                        RJMessageBox.Show("Stock has been decreased!");
                    }
                    else
                    {
                        RJMessageBox.Show("You're trying to remove too much stock!");
                    }
                }
                else
                {
                    RJMessageBox.Show("Please fill in all fields correctly.");
                }

                CMBcategory.SelectedIndex = 0;
                CMBitem.SelectedIndex = 0;
                tbxAddOrRemove.Texts = string.Empty;
                _itemManager.UpdateTheTextfile();
                _itemManager.WriteTransactionsToFile();
                UpdateSelectedStockDisplay();
            }
            catch (Exception)
            {
                RJMessageBox.Show("Please fill in all fields correctly.");
            }
        }

        private void UpdateSelectedStockDisplay()
        {
            if (LVfoodItems.SelectedIndices.Count > 0)
            {
                StockItem s = _itemManager.GetItem(LVfoodItems.SelectedIndices[0], 0);
                LBLdisplayInfo.Text = s.GetLeft();
            }
            else if (LVcleaningItems.SelectedIndices.Count > 0)
            {
                StockItem s = _itemManager.GetItem(LVcleaningItems.SelectedIndices[0], 1);
                LBLdisplayInfo.Text = s.GetLeft();
            }
            else if (LVbathroomItems.SelectedIndices.Count > 0)
            {
                StockItem s = _itemManager.GetItem(LVbathroomItems.SelectedIndices[0], 2);
                LBLdisplayInfo.Text = s.GetLeft();
            }
            else if (LVtablewareItems.SelectedIndices.Count > 0)
            {
                StockItem s = _itemManager.GetItem(LVtablewareItems.SelectedIndices[0], 3);
                LBLdisplayInfo.Text = s.GetLeft();
            }
        }

        private void LVItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView senderListView = (ListView)sender;
            if (senderListView.SelectedIndices.Count <= 0)
            {
                return;
            }

            int selectedIndex = senderListView.SelectedIndices[0];
            if (selectedIndex >= 0)
            {
                int categoryIndex = -1;
                if (senderListView == LVfoodItems)
                {
                    categoryIndex = 0;
                }
                else if (senderListView == LVcleaningItems)
                {
                    categoryIndex = 1;
                }
                else if (senderListView == LVbathroomItems)
                {
                    categoryIndex = 2;
                }
                else if (senderListView == LVtablewareItems)
                {
                    categoryIndex = 3;
                }

                if (categoryIndex != -1)
                {
                    StockItem s = this._itemManager.GetItem(selectedIndex, categoryIndex);
                    LBLdisplayInfo.Text = s.GetLeft();
                }
            }
        }

        private void CMBcategory_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CMBitem.Enabled = true;
            List<StockItem> items = this._itemManager.GetTheList(CMBcategory.SelectedIndex);
            CMBitem.Items.Clear();
            foreach (StockItem item in items)
            {
                CMBitem.Items.Add(item.Name);
            }
        }

        private void TenantStock_Leave(object sender, EventArgs e)
        {
            this._itemManager.UpdateTheTextfile();
        }

        private void tbxAddOrRemove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
