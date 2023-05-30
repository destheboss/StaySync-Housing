using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    internal class contactManager
    {
        public List<contact> contacts { get; set; }

        public contactManager()
        {
            this.contacts = new List<contact>();
        }

        public void AddContact(string number, string wappnumber, string email, string address)
        {
            this.contacts.Add(new contact(number, wappnumber, email, address));
        }

        public contact[] GetContacts()
        {
            return this.contacts.ToArray();
        }

        public void DeleteContacts()
        {
            foreach (var item in this.GetContacts())
            {
                this.contacts.Remove(item);
            }
        }

        public void Write()
        {
            StreamWriter sw = null;
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "contact.txt";
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);

                if (files.Length > 0)
                {
                    string fullPath = files.First();
                    sw = new StreamWriter(fullPath, false);

                    foreach (contact item in contacts)
                    {
                        sw.WriteLine(item.GetNumber());
                        sw.WriteLine(item.GetWappNumber());
                        sw.WriteLine(item.GetEmail());
                        sw.WriteLine(item.GetAddress());
                    }
                }
                else
                {
                    RJMessageBox.Show("The file couldn not be read.");
                }
            }
            catch (IOException) { }
            finally { if (sw != null) { sw.Close(); } }
        }
    }
}
