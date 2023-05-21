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
        private houseruleManager rules;
        public AdminRules()
        {
            InitializeComponent();
            rules = new houseruleManager();
            LoadRules();
        }

        private void RefreshRuleList()
        {
            this.lbxRules.Items.Clear();
            foreach (var rule in rules.GetRules())
            {
                this.lbxRules.Items.Add(rule.GetHouseRule());
            }
        }

        public void LoadRules()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string[] files = Directory.GetFiles(desktopPath, "rules.txt", SearchOption.AllDirectories);
                string fullPath = files.First();

                // Read all lines once and store them in lines array.
                string[] lines = File.ReadAllLines(fullPath);

                foreach (string line in lines)
                {
                    rules.AddHouseRule(line);
                    RefreshRuleList();
                }
            }
            catch (IOException ex)
            {
                RJMessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string rule = tbxMessage.Texts;
            if (!String.IsNullOrEmpty(rule))
            {
                rules.AddHouseRule(rule);
                RefreshRuleList();
                tbxMessage.Texts = "";
                RJMessageBox.Show("Rule added.", "", MessageBoxButtons.OK);
            }
            else
            {
                RJMessageBox.Show("Please supply a valid message.", "", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxRules.SelectedIndex > -1)
            {
                int index = this.lbxRules.SelectedIndex;
                {
                    index++;
                    rules.DeleteRule(index);
                    RJMessageBox.Show("Rule deleted.", "", MessageBoxButtons.OK);
                    RefreshRuleList();
                }
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
    }
}
