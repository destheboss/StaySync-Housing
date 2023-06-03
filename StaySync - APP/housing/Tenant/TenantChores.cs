using housing.Classes;
using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing
{
    public partial class TenantChores : Form
    {
        private User loggedInUser = new User();
        private PersonManager manager;
        private ChoreManager choresManager;
        private int indexRow;
        public TenantChores(PersonManager m)
        {
            InitializeComponent();
            manager = m;
            choresManager = new ChoreManager(manager);
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
            #endregion

            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.attendance_invert);
            btnClose.Text = $"  {manager.CurrentUser.FirstName}";
        }

        private void TenantChores_Load(object sender, EventArgs e)
        {
            choresManager.LoadChoresFromFile();
            RefreshGrid();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChores.Rows[indexRow].Cells[0].Value != null)
                {
                    string cellValue = dgvChores.Rows[indexRow].Cells[0].Value.ToString();
                    int choreId;
                    if (Int32.TryParse(cellValue, out choreId))
                    {
                        Chore chore = choresManager.GetChore(choreId);
                        if (chore.AssignedPerson != null &&
                            chore.AssignedPerson.FirstName == loggedInUser.FirstName &&
                            chore.AssignedPerson.LastName == loggedInUser.LastName)
                        {
                            DialogResult result = RJMessageBox.Show("Are you sure you want to mark this chore as done?", "", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                choresManager.MarkChoreAsDone(choreId);
                                choresManager.WriteChoresToFile();
                                RefreshGrid();
                            }
                        }
                        else
                        {
                            RJMessageBox.Show("This chore is not for you!", "", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        RJMessageBox.Show("This chore is not for you!", "", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    RJMessageBox.Show("This chore is not for you!", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("This chore is not for you!", "", MessageBoxButtons.OK);
            }
        }

        private void RefreshGrid()
        {
            dgvChores.Rows.Clear();
            foreach (Chore c in choresManager.GetChores())
            {
                if (!c.IsCompleted)
                {
                    var choreName = c.ChoreName;
                    var assignedPerson = c.AssignedPerson != null
                                         ? $"{c.AssignedPerson.FirstName} {c.AssignedPerson.LastName}"
                                         : "None";
                    var id = c.ID;
                    dgvChores.Rows.Add(id, choreName, assignedPerson);
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            indexRow = dgvChores.CurrentCell.RowIndex;
            dgvChores.Rows[indexRow].Selected = true;
        }

        private void dgvChores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void dgvChores_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvChores.CurrentRow != null)
                {
                    var selectedChore = choresManager.GetChore(Convert.ToInt32(dgvChores.CurrentRow.Cells[0].Value));

                    string choreName = selectedChore.ChoreName;
                    string assignedPersonName = selectedChore.AssignedPerson != null
                        ? $"{selectedChore.AssignedPerson.FirstName} {selectedChore.AssignedPerson.LastName}"
                        : "None";

                    string message = $"▶ Assigned To: {assignedPersonName} ◀";

                    RJMessageBox.Show($"{message}", choreName, MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }
    }
}
