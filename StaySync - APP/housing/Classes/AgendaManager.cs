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
    public class AgendaManager
    {
        private List<Agenda> allAgendas;
        private int nextId = 1;

        public AgendaManager()
        {
            allAgendas = new List<Agenda>();
        }

        public void AddAgenda(int day, int month, int year, string start, string end, string title, string description)
        {
            Agenda newAgenda = new Agenda(nextId, day, month, year, start, end, title, description);
            allAgendas.Add(newAgenda);
            nextId++;
        }

        public void DeleteAgenda(int id)
        {
            Agenda AgendaToDelete = allAgendas.FirstOrDefault(e => e.ID == id);
            if (AgendaToDelete != null)
            {
                allAgendas.Remove(AgendaToDelete);
            }
        }

        public List<Agenda> GetAllAgendas()
        {
            return allAgendas;
        }

        public Agenda GetAgendaBasedOnId(int id)
        {
            return allAgendas.FirstOrDefault(e => e.ID == id);
        }

        public void WriteToFile()
        {
            StreamWriter sw = null;
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "agenda.txt";
                string[] files = Directory.GetFiles(desktopPath, fileName, SearchOption.AllDirectories);
                string fullPath = files.First();
                sw = new StreamWriter(fullPath, false);
                foreach (Agenda evt in allAgendas)
                {
                    sw.WriteLine($"{evt.ID};{evt.Day};{evt.Month};{evt.Year};{evt.Start};{evt.End};{evt.Title};{evt.Desc}");
                }
            }
            catch (IOException)
            {
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}