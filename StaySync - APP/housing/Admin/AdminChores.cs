using housing.Classes;
using housing.CustomElements;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.attendance_invert);

            #region COLORS DATAGRID
            dgvChores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 34, 83);
            dgvChores.DefaultCellStyle.SelectionForeColor = dgvChores.DefaultCellStyle.ForeColor;
            dgvChores.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 34, 83);
            dgvChores.RowHeadersDefaultCellStyle.SelectionForeColor = dgvChores.RowHeadersDefaultCellStyle.ForeColor;
            dgvChores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvChores.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dgvChores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvChores.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dgvChores.BackgroundColor = Color.FromArgb(231, 34, 83);
            dgvChores.GridColor = Color.FromArgb(11, 7, 17);
            dgvChores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 34, 83);
            dgvChores.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvChores.DefaultCellStyle.ForeColor = Color.White;
            dgvChores.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvChores.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvChores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChores.EnableHeadersVisualStyles = false;
            dgvChores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvChores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvChores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvChores.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn column in dgvChores.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in dgvChores.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewRow row in dgvChores.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            dgvChores.CellFormatting += DgvChores_CellFormatting;
            #endregion
            btnClose.Text = $"  {_personManager.CurrentUser.LastName}";
        }

        private void adminchores_Load(object sender, EventArgs e)
        {
            RefreshChores();
        }

        private void DgvChores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Assuming the 'Status' column is at index 3
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                string statusValue = e.Value.ToString();

                if (statusValue == "Completed")
                {
                    e.CellStyle.BackColor = Color.FromArgb(231, 34, 83);
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (statusValue == "Not Completed")
                {
                    e.CellStyle.BackColor = Color.FromArgb(11, 7, 17);
                    e.CellStyle.ForeColor = Color.White;
                }
            }
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

                dgvChores.AutoGenerateColumns = false;
                dgvChores.Columns.Clear();

                dgvChores.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID",
                    Visible = false,
                });
                dgvChores.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ChoreName",
                    HeaderText = "Chore",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvChores.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "AssignedPersonFullName",
                    HeaderText = "Assigned To",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvChores.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CompletedStatus",
                    HeaderText = "Status",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });

                dgvChores.DataSource = new BindingList<Chore>(_choreManager.AllChores);
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
                if (dgvChores.CurrentRow != null)
                {
                    DialogResult result = RJMessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var selectedChore = (Chore)dgvChores.CurrentRow.DataBoundItem;
                        _choreManager.DeleteChore(selectedChore.ID);
                        _choreManager.WriteChoresToFile();
                        RefreshChores();
                    }
                }
                else
                {
                    RJMessageBox.Show("Please select a chore first.", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Please select a chore first.", "", MessageBoxButtons.OK);
            }
        }

        private void RefreshChores()
        {
            try
            {
                dgvChores.DataSource = null;
                dgvChores.DataSource = new BindingList<Chore>(_choreManager.AllChores);
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }

        private void dgvChores_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvChores.CurrentRow != null)
                {
                    var selectedChore = (Chore)dgvChores.CurrentRow.DataBoundItem;

                    string message = $"▶ Assigned To: {selectedChore.AssignedPersonFullName} ◀\n"
                                   + $"Status: {(selectedChore.IsCompleted ? "Completed" : "Not Completed")}\n";

                    RJMessageBox.Show($"{message}", $"{selectedChore.ChoreName}", MessageBoxButtons.OK);
                    return;
                }

                RJMessageBox.Show("No chore selected.", "", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }
        private void FocusEvent(object sender, EventArgs e)
        {
            btnClose.Focus();
        }
    }
}