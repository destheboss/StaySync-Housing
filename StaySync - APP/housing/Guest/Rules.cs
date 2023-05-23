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
    public partial class Rules : Form
    {
        private houseruleManager rules;
        public Rules()
        {
            InitializeComponent();
            rules = new houseruleManager();
            LoadRules();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshRuleList()
        {
            try
            {
                this.lbHouseRules.Items.Clear();
                foreach (var rule in rules.GetRules())
                {
                    this.lbHouseRules.Items.Add(rule.GetHouseRule());
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
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbHouseRules.SelectedIndex > -1)
                {
                    int index = this.lbHouseRules.SelectedIndex;
                    if (index > -1)
                    {
                        index++;
                        RJMessageBox.Show(rules.GetRuleInfoBasedOnId(index));
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshRuleList();
        }

        private void lbHouseRules_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lbHouseRules.SelectedIndex > -1)
                {
                    int index = this.lbHouseRules.SelectedIndex;
                    if (index > -1)
                    {
                        index++;
                        RJMessageBox.Show(rules.GetRuleInfoBasedOnId(index));

                    }
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }
    }
}
