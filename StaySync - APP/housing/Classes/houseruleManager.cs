using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing.Classes
{
    internal class houseruleManager
    {
        private int ruleSeeder;
        public List<houserule> houserules { get; set; }

        public houseruleManager()
        {
            this.houserules = new List<houserule>();
        }

        public houserule AddHouseRule(string houserule)
        {
            this.ruleSeeder++;
            houserule newRule = new houserule(ruleSeeder, houserule);
            this.houserules.Add(newRule);
            return newRule;
        }

        public houserule[] GetRules()
        {
            return this.houserules.ToArray();
        }

        public houserule GetRule(int id)
        {
            foreach (var rule in this.houserules)
            {
                if (id == rule.ID)
                    return rule;
            }
            return null;
        }

        public string GetRuleInfoBasedOnId(int id)
        {
            var rule = this.GetRule(id);
            return rule.GetHouseRuleMessage();
        }

        public void DeleteRule(houserule ruleToDelete)
        {
            this.houserules.Remove(ruleToDelete);
        }

        public void WriteRules()
        {
            StreamWriter sw = null;
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "rules.txt";
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);
                string fullPath = files.First();
                sw = new StreamWriter(fullPath, false);
                foreach (houserule rule in houserules)
                {
                    sw.WriteLine(rule.WriteHouseRuleMessage());
                }
            }
            catch (IOException)
            { }
            finally
            { if (sw != null) { sw.Close(); } }
        }
    }
}
