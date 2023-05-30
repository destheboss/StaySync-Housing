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
    public class ComplaintManager
    {
        private List<Complaint> _complaints = new List<Complaint>();
        private List<Complaint> _writtenComplaints = new List<Complaint>();
        private int _currentId;

        public ComplaintManager()
        {
            _currentId = GetLastId() + 1;
        }

        private int GetLastId()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "complaints.txt";
            string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

            int lastId = 0;

            foreach (string filePath in files)
            {
                if (!File.Exists(filePath))
                {
                    continue;
                }

                try
                {
                    string lastLine = File.ReadLines(filePath).LastOrDefault();

                    if (string.IsNullOrEmpty(lastLine))
                    {
                        continue;
                    }

                    string[] parts = lastLine.Split(',');

                    if (int.TryParse(parts[0], out int id) && id > lastId)
                    {
                        lastId = id;
                    }
                }
                catch
                {
                    continue;
                }
            }

            return lastId;
        }

        public bool IsItEmpty(bool tenantRBTN, bool adminRBTN, bool roomRBTN, string tenant, string admin, string room)
        {
            return (tenantRBTN && string.IsNullOrEmpty(tenant)) ||
                   (adminRBTN && string.IsNullOrEmpty(admin)) ||
                   (roomRBTN && string.IsNullOrEmpty(room));
        }

        public void FileComplaint(string subject, string whoOrWhere, string complaintText)
        {
            User user = new User();
            FileComplaint(subject, "", whoOrWhere, complaintText);
        }

        public void FileComplaint(string subject, string complaintText)
        {
            User user = new User();
            FileComplaint(subject, "", "", complaintText);
        }

        private void FileComplaint(string subject, string from, string whoOrWhere, string complaintText)
        {
            User user = new User();
            Complaint complaint = new Complaint
            {
                ID = _currentId++,
                From = string.IsNullOrEmpty(from) ? $"{user.FirstName} {user.LastName}" : from,
                Subject = subject,
                WhoOrWhere = whoOrWhere,
                ComplaintText = complaintText
            };
            _complaints.Add(complaint);
        }

        public bool IsAnyRadioButtonChecked(bool tenantChecked, bool adminChecked, bool roomChecked)
        {
            return tenantChecked || adminChecked || roomChecked;
        }
        public void WriteComplaints()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "complaints.txt";
            string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        foreach (Complaint complaint in _complaints)
                        {
                            if (!_writtenComplaints.Contains(complaint))
                            {
                                sw.WriteLine(complaint.GetInfo());
                                _writtenComplaints.Add(complaint);
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
    }
}
