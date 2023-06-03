using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing
{
    public partial class AdminRules : Form
    {
        private PersonManager _manager;
        private houseruleManager rules;
        public AdminRules(PersonManager manager)
        {
            InitializeComponent();
            _manager = manager;
            rules = new houseruleManager();
            LoadRules();

            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.attendance_invert);

            btnClose.Text = $"  {_manager.CurrentUser.LastName}";
        }

        private void RefreshRuleList()
        {
            try
            {
                this.lbxRules.Items.Clear();
                foreach (var rule in rules.GetRules())
                {
                    this.lbxRules.Items.Add(rule);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }

        public void LoadRules()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string[] files = Directory.GetFiles(desktopPath, "rules.txt", SearchOption.AllDirectories);
                string fullPath = files.First();

                string[] lines = File.ReadAllLines(fullPath);

                foreach (string line in lines)
                {
                    rules.AddHouseRule(line);
                    RefreshRuleList();
                }
            }
            catch (IOException)
            {
                RJMessageBox.Show("The file could not be read.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string rule = tbxMessage.Texts;
                if (!String.IsNullOrEmpty(rule))
                {
                    houserule newRule = rules.AddHouseRule(rule);
                    this.lbxRules.Items.Add(newRule);
                    tbxMessage.Texts = "";
                    RJMessageBox.Show("Rule added.", "", MessageBoxButtons.OK);
                }
                else
                {
                    RJMessageBox.Show("Please supply a valid message.", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxRules.SelectedIndex > -1)
                {
                    DialogResult result = RJMessageBox.Show("Are you sure you want to delete this rule?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        houserule ruleToDelete = (houserule)lbxRules.SelectedItem;
                        rules.DeleteRule(ruleToDelete);
                        RJMessageBox.Show("Rule deleted.", "", MessageBoxButtons.OK);
                        RefreshRuleList();
                    }
                }
                else
                {
                    RJMessageBox.Show("Please select a rule first.", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }

        private void AdminRules_Leave(object sender, EventArgs e)
        {
            rules.WriteRules();
        }

        private void AdminRules_ParentChanged(object sender, EventArgs e)
        {
            rules.WriteRules();
        }

        private void FocusEvent(object sender, EventArgs e)
        {
            btnClose.Focus();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            btnClose.Focus();
        }
    }
}
