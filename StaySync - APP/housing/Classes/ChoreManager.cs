using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace housing.Classes
{
    internal class ChoreManager
    {
        private int choreSeeder;
        public List<Chore> AllChores { get; set; }
        private PersonManager _personManager;

        public ChoreManager(PersonManager personManager)
        {
            _personManager = personManager;
            this.AllChores = new List<Chore>();
        }

        public Chore AddChore(string choreName, Person assignedPerson)
        {
            Chore chore = new Chore(choreSeeder, choreName, assignedPerson);
            AllChores.Add(chore);
            choreSeeder++;
            return chore;
        }

        public Chore[] GetChores()
        {
            return this.AllChores.ToArray();
        }
        public Chore GetChoreById(int id)
        {
            return AllChores.FirstOrDefault(chore => chore.ID == id);
        }

        public Chore GetChore(int id)
        {
            return this.AllChores.FirstOrDefault(chore => chore.ID == id);
        }

        public void DeleteChore(int id)
        {
            var choreToDelete = AllChores.FirstOrDefault(c => c.ID == id);
            if (choreToDelete != null)
            {
                AllChores.Remove(choreToDelete);
            }
        }

        public void WriteChoresToFile()
        {
            StreamWriter sw = null;
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "chores.txt";
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);
                string fullPath = files.First();
                sw = new StreamWriter(fullPath, false);
                foreach (Chore chore in AllChores)
                {
                    var firstName = chore.AssignedPerson?.FirstName ?? "None";
                    var lastName = chore.AssignedPerson?.LastName ?? "None";
                    sw.WriteLine($"{chore.ID},{chore.ChoreName},{firstName},{lastName},{chore.IsCompleted}");
                }
            }
            catch (IOException)
            { }
            finally
            { if (sw != null) { sw.Close(); } }
        }


        public void MarkChoreAsDone(int choreId)
        {
            var chore = GetChore(choreId);
            if (chore != null)
            {
                chore.IsCompleted = true;
            }
        }

        public void LoadChoresFromFile()
        {
            StreamReader sr = null;
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "chores.txt";
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);
                string fullPath = files.First();
                sr = new StreamReader(fullPath);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var splitLine = line.Split(',');
                    int id = Int32.Parse(splitLine[0]);
                    string choreName = splitLine[1];
                    string firstName = splitLine[2];
                    string lastName = splitLine[3];
                    bool isCompleted = Boolean.Parse(splitLine[4]);
                    Person assignedPerson = firstName != "None" && lastName != "None"
                        ? _personManager.GetPersonByFullName(firstName, lastName)
                        : null;
                    Chore chore = new Chore(id, choreName, assignedPerson) { IsCompleted = isCompleted };
                    AllChores.Add(chore);
                }
            }
            catch (IOException)
            {
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}