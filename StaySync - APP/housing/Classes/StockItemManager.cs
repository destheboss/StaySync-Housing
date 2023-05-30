using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing.Classes
{
    internal class StockItemManager
    {
        private Dictionary<int, List<StockItem>> _allItems = new Dictionary<int, List<StockItem>>();
        private string _latestTransaction;

        public void LoadUpLists()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "stockItem.txt";
            string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath, false))
                    {
                        string s = sr.ReadLine();
                        while (s != null)
                        {
                            char delimiter = ',';
                            string[] words = s.Split(delimiter);
                            StockItem n = new StockItem();
                            n.Name = words[0];
                            n.Amount = Convert.ToInt32(words[1]);
                            n.ListNumber = Convert.ToInt32(words[2]);
                            n.Description = words[3];

                            if (!_allItems.ContainsKey(n.ListNumber))
                            {
                                _allItems[n.ListNumber] = new List<StockItem>();
                            }

                            _allItems[n.ListNumber].Add(n);
                            s = sr.ReadLine();
                        }
                    }
                }
                catch (IOException)
                {
                    RJMessageBox.Show("The file could not be read.");
                }
            }
        }

        public List<string> LoadTransactionLogs()
        {
            var transactionLogs = new List<string>();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "transaction.txt";
            string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string logLine = sr.ReadLine();
                        while (logLine != null)
                        {
                            transactionLogs.Add(logLine);
                            logLine = sr.ReadLine();
                        }
                    }
                }
                catch (IOException)
                {
                    RJMessageBox.Show("The file could not be read.");
                }
            }
            return transactionLogs;
        }

        public List<StockItem> GetTheList(int index)
        {
            if (_allItems.ContainsKey(index))
                return _allItems[index];

            return new List<StockItem>();
        }

        public bool AreTheInputsOkay(string category, string item, int amount)
        {
            return !(String.IsNullOrEmpty(category) || String.IsNullOrEmpty(item) || amount <= 0);
        }

        public bool CanWeRemove(int listsIndex, int index, int amount)
        {
            if (!_allItems.ContainsKey(listsIndex))
                return false;

            List<StockItem> list = _allItems[listsIndex];
            if (index >= list.Count)
                return false;

            StockItem item = list[index];
            return item.Amount >= amount;
        }

        public void RemoveAndUpdate(int listsIndex, int index, int amount)
        {
            if (CanWeRemove(listsIndex, index, amount))
            {
                _allItems[listsIndex][index].Amount -= amount;
            }
        }

        public void AddAndUpdate(int listsIndex, int index, int amount)
        {
            if (_allItems.ContainsKey(listsIndex) && index < _allItems[listsIndex].Count)
            {
                _allItems[listsIndex][index].Amount += amount;
            }
        }

        public StockItem GetItem(int index, int listIndex)
        {
            if (_allItems.ContainsKey(listIndex) && index < _allItems[listIndex].Count)
            {
                return _allItems[listIndex][index];
            }
            return null;
        }

        public void UpdateTheTextfile()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "stockItem.txt";
            string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        foreach (List<StockItem> list in _allItems.Values)
                        {
                            foreach (StockItem i in list)
                            {
                                sw.WriteLine(i.GetInfo());
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    RJMessageBox.Show("The file could not be read.");
                }
            }
        }

        public void AddChangeToList(string name, int category, int item, string upOrDown, int amount)
        {
            DateTime time = DateTime.Now;
            List<StockItem> categoryThatHasBeenUpdated = _allItems[category];
            _latestTransaction = $"{time}: {name} has {upOrDown} {categoryThatHasBeenUpdated[item].Name} by {amount}.";
        }

        public void WriteTransactionsToFile()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "transaction.txt";
            string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        if (!string.IsNullOrEmpty(_latestTransaction))
                        {
                            sw.WriteLine(_latestTransaction);
                        }
                    }
                }
                catch (IOException)
                {
                    RJMessageBox.Show("The file could not be read.");
                }
            }
        }
    }
}
