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
    internal class ComplaintViewerManager
    {
        private List<Complaint> _complaints = new List<Complaint>();
        private int _currentId = 1;

        public List<Complaint> Complaints => _complaints;

        public int Count => _complaints.Count;

        public void LoadComplaints()
        {
            _complaints.Clear();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "complaints.txt";
            string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);


            foreach (string filePath in files)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            var parts = line.Split(',');
                            if (parts.Length >= 6)
                            {
                                bool isResolved = bool.Parse(parts[5]);

                                if (isResolved)
                                {
                                    continue;
                                }

                                var complaint = new Complaint
                                {
                                    ID = _currentId++,
                                    From = parts[1],
                                    Subject = parts[2],
                                    WhoOrWhere = parts[3],
                                    ComplaintText = parts[4],
                                    IsResolved = isResolved
                                };
                                _complaints.Add(complaint);
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

        public void ResolveComplaint(int id)
        {
            var complaint = _complaints.FirstOrDefault(c => c.ID == id);
            if (complaint != null)
            {
                complaint.IsResolved = true;
                SaveComplaints();
            }
        }

        public void SaveComplaints()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "complaints.txt";
            string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        foreach (var complaint in _complaints)
                        {
                            sw.WriteLine(complaint.GetInfo());
                        }
                    }
                }
                catch (IOException)
                {
                    RJMessageBox.Show("The file could not be written.");
                }
            }
        }
    }
}
