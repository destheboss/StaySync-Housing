using housing.Classes;
using housing.CustomElements;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace housing
{
    public partial class AdminChores : Form
    {
        private ChoreManager _choreManager;
        private PersonManager _personManager;

        public AdminChores(PersonManager personManager)
        {
            _personManager = personManager;
            _choreManager = new ChoreManager(personManager);
            InitializeComponent();
            LoadChores();
        }

        private void adminchores_Load(object sender, EventArgs e)
        {
            RefreshChores();
        }
        public void LoadChores()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string[] files = Directory.GetFiles(desktopPath, "chores.txt", SearchOption.AllDirectories);
                string fullPath = files.First();

                string[] lines = File.ReadAllLines(fullPath);

                foreach (string line in lines)
                {
                    string[] choreInfo = line.Split(',');
                    int id = int.Parse(choreInfo[0]);
                    string choreName = choreInfo[1];
                    bool isCompleted = bool.Parse(choreInfo[4]);
                    if (choreInfo.Length > 2)
                    {
                        string assignedPersonFirstName = choreInfo[2];
                        string assignedPersonLastName = choreInfo[3];

                        Person assignedPerson = _personManager.GetPersonByFullName(assignedPersonFirstName, assignedPersonLastName);

                        Chore chore = _choreManager.AddChore(choreName, assignedPerson);
                        chore.IsCompleted = isCompleted;
                    }
                    else
                    {
                        Chore chore = _choreManager.AddChore(choreName, null);
                        chore.IsCompleted = isCompleted;
                    }
                }

                RefreshChores();
            }
            catch (IOException)
            {
                RJMessageBox.Show("The file could not be read.", "", MessageBoxButtons.OK);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxNewChore.Texts))
            {
                try
                {
                    Person randomPerson = _personManager.GetRandomPerson();
                    _choreManager.AddChore(tbxNewChore.Texts, randomPerson);
                    _choreManager.WriteChoresToFile();
                    RefreshChores();
                    tbxNewChore.Texts = "";
                    RJMessageBox.Show("Chore has been added.");
                }
                catch (Exception)
                {
                    RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                RJMessageBox.Show("Please fill in a chore before adding.", "", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedChoreInfo = (string)lbxChores.SelectedItem;
                var separatorIndex = selectedChoreInfo.IndexOf('|');
                if (separatorIndex >= 0)
                {
                    var choreId = int.Parse(selectedChoreInfo.Substring(0, separatorIndex).Trim()) - 1;
                    _choreManager.DeleteChore(choreId);
                    _choreManager.WriteChoresToFile();
                    RefreshChores();
                }
                else
                {
                    RJMessageBox.Show("Please select a chore first.");
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }

        private void RefreshChores()
        {
            try
            {
                lbxChores.Items.Clear();
                var chores = _choreManager.GetChores();
                foreach (var chore in chores)
                {
                    lbxChores.Items.Add(chore.GetChoreStatusInfo());
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void lbxChores_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lbxChores.SelectedItem != null)
                {
                    string selectedChoreInfo = lbxChores.SelectedItem.ToString();

                    int separatorIndex = selectedChoreInfo.IndexOf('|');
                    if (separatorIndex >= 0)
                    {
                        int choreId;
                        if (int.TryParse(selectedChoreInfo.Substring(0, separatorIndex).Trim(), out choreId))
                        {
                            choreId--;

                            Chore selectedChore = _choreManager.GetChoreById(choreId);

                            if (selectedChore != null)
                            {
                                RJMessageBox.Show($"{selectedChore.GetChoreInfoBasedOnId()} - Status: {(selectedChore.IsCompleted ? "Completed" : "Not Completed")}", "", MessageBoxButtons.OK);
                                return;
                            }
                        }
                    }
                }

                RJMessageBox.Show("Invalid chore selected.", "", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }
    }
}