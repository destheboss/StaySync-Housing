using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using housing.CustomElements;


namespace housing
{
    public class PersonManager
    {
        private List<Person> _persons;

        public bool IsTheInputAcceptable(string input)
        {
            return !String.IsNullOrEmpty(input);
        }

        public void LoadUpList()
        {
            this._persons = new List<Person>();
            FileStream fs = null;
            StreamReader sr = null;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "tenants.txt";
            bool fileFound = false;
            while (!fileFound)
            {
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    try
                    {
                        fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                        sr = new StreamReader(fs);
                        string s = sr.ReadLine();
                        while (s != null && !string.IsNullOrEmpty(s))
                        {
                            char delimiter = ',';
                            string[] words = s.Split(delimiter);
                            Person p = new Person();
                            p.FirstName = words[0];
                            p.LastName = words[1];
                            p.Code = Convert.ToInt32(words[2]);
                            p.Phone = words[3];
                            p.Email = words[4];
                            p.IsAdmin = words[5];
                            p.RoomNumber = Convert.ToInt32(words[6]);
                            p.IsPresent = words[7];
                            this._persons.Add(p);
                            s = sr.ReadLine();
                        }
                    }
                    finally
                    {
                        if (sr != null)
                        {
                            sr.Close();
                        }
                    }
                    fileFound = true;
                }
                else
                {
                    RJMessageBox.Show("The file could not be read.", "", MessageBoxButtons.OK);
                }
            }
        }

        public List<Person> GetList()
        {
            return this._persons;
        }

        public bool IsThePersonInTheCSV(int code)
        {
            foreach (Person p in this._persons)
            {
                if (p.DoesTheCodeMatch(code))
                {
                    p.CreateUser();
                    RJMessageBox.Show("Welcome back!", "", MessageBoxButtons.OK);
                    return true;
                }
            }
            return false;
        }

        public bool IsThePersonAdmin()
        {
                User User = new User();
            return User.IsItAdmin();
        }

        public Person GetPersonByFullName(string firstName, string lastName)
        {
            return _persons.FirstOrDefault(person =>
                person.FirstName.Trim().ToLower() == firstName.Trim().ToLower() &&
                person.LastName.Trim().ToLower() == lastName.Trim().ToLower()
            );
        }

        public List<Person> GetPersons()
        {
            return _persons;
        }
        public Person GetRandomPerson()
        {
            var tenants = _persons.Where(p => p.IsAdmin.ToLower() == "no").ToList();
            if (tenants.Any())
            {
                Random rand = new Random();
                int index = rand.Next(tenants.Count);
                return tenants[index];
            }
            else
            {
                return null;
            }
        }
    }
}
