using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections;
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
    public partial class AdminAgenda : Form
    {
        private AgendaManager manager;
        public AdminAgenda()
        {
            InitializeComponent();
            manager = new AgendaManager();
            LoadAgendas();
        }

        private void RefreshAgendaList()
        {
            try
            {
                lbxEvents.Items.Clear();
                foreach (var agenda in manager.GetAllAgendas())
                {
                    lbxEvents.Items.Add(agenda.GetAgendaInfo());
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        public void LoadAgendas()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string[] files = Directory.GetFiles(desktopPath, "agenda.txt", SearchOption.AllDirectories);
                string fullPath = files.First();

                string[] lines = File.ReadAllLines(fullPath);

                foreach (string line in lines)
                {
                    string[] agendaData = line.Split(';');
                    if (agendaData.Length >= 8)
                    {
                        int day, month, year;
                        if (int.TryParse(agendaData[1], out day) &&
                            int.TryParse(agendaData[2], out month) &&
                            int.TryParse(agendaData[3], out year))
                        {
                            manager.AddAgenda(
                                day,
                                month,
                                year,
                                agendaData[4],
                                agendaData[5],
                                agendaData[6],
                                agendaData[7]
                            );
                        }
                    }
                }
                RefreshAgendaList();
            }
            catch (IOException)
            {
                RJMessageBox.Show("The file could not be read.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                CreateEvent addAgenda = new CreateEvent(manager);
                addAgenda.Show();
                addAgenda.FormClosed += new FormClosedEventHandler(CreateEvent_FormClosed);
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void CreateEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshAgendaList();
        }

        private void lbxEvents_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lbxEvents.SelectedItem != null)
                {
                    string selectedInfo = lbxEvents.SelectedItem.ToString();
                    if (int.TryParse(selectedInfo.Split('╠')[0], out int selectedId))
                    {
                        Agenda selectedAgenda = manager.GetAgendaBasedOnId(selectedId);
                        if (selectedAgenda != null)
                        {
                            RJMessageBox.Show(selectedAgenda.DescriptionList, selectedAgenda.Title);
                        }
                        else
                        {
                            RJMessageBox.Show("Selected agenda not found.");
                        }
                    }
                    else
                    {
                        RJMessageBox.Show("Could not parse selected item.");
                    }
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxEvents.SelectedIndex > -1)
                {
                    string selectedInfo = lbxEvents.SelectedItem.ToString();
                    if (int.TryParse(selectedInfo.Split('╠')[0], out int selectedId))
                    {
                        Agenda selectedAgenda = manager.GetAgendaBasedOnId(selectedId);
                        if (selectedAgenda != null)
                        {
                            manager.DeleteAgenda(selectedId);
                            RJMessageBox.Show("Agenda deleted.", "", MessageBoxButtons.OK);
                            RefreshAgendaList();
                        }
                    }
                }
                else
                {
                    RJMessageBox.Show("Please select an event first.");
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void AdminAgenda_Leave(object sender, EventArgs e)
        {
            manager.WriteToFile();
        }

        private void AdminAgenda_ParentChanged(object sender, EventArgs e)
        {
            manager.WriteToFile();
        }
    }
}
