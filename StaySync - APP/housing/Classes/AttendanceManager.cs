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
    internal class AttendanceManager
    {
        private List<Person> people;
        private DateTime time;

        public AttendanceManager(IEnumerable<Person> people)
        {
            this.people = new List<Person>(people.Where(p => p.IsAdmin == "no"));
            this.time = DateTime.Now;
        }

        public List<Person> GetFilteredPersons(string searchName)
        {
            return this.people.Where(p => p.FirstName == searchName || p.FirstName + " " + p.LastName == searchName).ToList();
        }

        public string ChangePresent(string present)
        {
            if (present == "Present")
            {
                return "Present";
            }
            return "Absent";
        }

        public void ChangeUserStatus(string gettingName, string changestatus)
        {
            foreach (Person p in people)
            {
                if (gettingName == p.FirstName + " " + p.LastName)
                {
                    p.IsPresent = ChangePresent(changestatus);
                }
            }
        }

        public void RefreshPersonList(List<Person> personlist)
        {
            for (int i = 0; i < personlist.Count; i++)
            {
                Person p = personlist[i];
                for (int a = 0; a < people.Count; a++)
                {
                    Person person = people[a];
                    if (p.FirstName + " " + p.LastName == person.FirstName + " " + person.LastName)
                    {
                        personlist[i] = people[a];
                        break;
                    }
                }
            }
        }

        public void SaveAttendanceFile()
        {
            StreamWriter sw = null;
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "attendance.txt";
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);
                string fullPath = files.First();

                sw = new StreamWriter(fullPath, append: false);
                sw.WriteLine($"Date: {time}");
                foreach (Person p in people)
                {
                    sw.WriteLine($"{p.FirstName},{p.LastName},{p.IsPresent}");
                }
            }
            catch (IOException)
            {
                RJMessageBox.Show("Something went wrong", "", MessageBoxButtons.OK);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void LoadAttendanceFromFile()
        {
            StreamReader sr = null;
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "attendance.txt";
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);
                string fullPath = files.First();

                sr = new StreamReader(fullPath);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var splitLine = line.Split(',');
                    if (splitLine.Length < 3) continue;

                    string firstName = splitLine[0].Trim();
                    string lastName = splitLine[1].Trim();
                    string isPresentString = splitLine[2].Trim();

                    Person person = people.Find(p => p.FirstName == firstName && p.LastName == lastName);
                    if (person != null)
                    {
                        person.IsPresent = isPresentString;
                    }
                }
            }
            catch (IOException)
            {
                RJMessageBox.Show("Something went wrong", "", MessageBoxButtons.OK);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public List<Person> GetPeople()
        {
            return this.people;
        }
    }
}