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
    public partial class AdminAttendance : Form
    {
        private PersonManager manager;
        private AttendanceManager attendanceManager;
        private int indexRow;
        public AdminAttendance(PersonManager m)
        {
            InitializeComponent();
            this.manager = m;
            attendanceManager = new AttendanceManager(manager.GetList());

            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.attendance_invert);
            #region COLORS DATAGRID
            dgvTenantStatus.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 34, 83);
            dgvTenantStatus.DefaultCellStyle.SelectionForeColor = dgvTenantStatus.DefaultCellStyle.ForeColor;
            dgvTenantStatus.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 34, 83);
            dgvTenantStatus.RowHeadersDefaultCellStyle.SelectionForeColor = dgvTenantStatus.RowHeadersDefaultCellStyle.ForeColor;
            dgvTenantStatus.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTenantStatus.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dgvTenantStatus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTenantStatus.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dgvTenantStatus.BackgroundColor = Color.FromArgb(231, 34, 83);
            dgvTenantStatus.GridColor = Color.FromArgb(11, 7, 17);
            dgvTenantStatus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 34, 83);
            dgvTenantStatus.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvTenantStatus.DefaultCellStyle.ForeColor = Color.White;
            dgvTenantStatus.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvTenantStatus.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvTenantStatus.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTenantStatus.EnableHeadersVisualStyles = false;
            dgvTenantStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvTenantStatus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvTenantStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTenantStatus.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTenantStatus.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn column in dgvTenantStatus.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in dgvTenantStatus.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewRow row in dgvTenantStatus.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            #endregion

            dgvTenantStatus.DoubleClick += dgvTenantStatus_DoubleClick;
            btnClose.Text = $"  {manager.CurrentUser.LastName}";
        }
        private void adminattendance_Load(object sender, EventArgs e)
        {
            attendanceManager.LoadAttendanceFromFile();
            RefreshGrid();
        }

        private void dgvTenantStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = dgvTenantStatus.CurrentCell.RowIndex;
            dgvTenantStatus.Rows[indexRow].Selected = true;
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            try
            {
                string gettingName = dgvTenantStatus.Rows[indexRow].Cells[0].Value.ToString();
                attendanceManager.ChangeUserStatus(gettingName, "Absent");
                RJMessageBox.Show($"You changed {gettingName}'s status to < absent >", "", MessageBoxButtons.OK);

                int selectedRow = indexRow;

                attendanceManager.RefreshPersonList(manager.GetList());
                RefreshGrid();
                attendanceManager.SaveAttendanceFile();

                if (selectedRow < dgvTenantStatus.Rows.Count)
                {
                    dgvTenantStatus.Rows[selectedRow].Selected = true;
                    dgvTenantStatus.CurrentCell = dgvTenantStatus[0, selectedRow];
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong", "", MessageBoxButtons.OK);
            }
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            try
            {
                string gettingName = dgvTenantStatus.Rows[indexRow].Cells[0].Value.ToString();
                attendanceManager.ChangeUserStatus(gettingName, "Present");
                RJMessageBox.Show($"You changed {gettingName}'s status to < present >", "", MessageBoxButtons.OK);

                int selectedRow = indexRow;

                attendanceManager.RefreshPersonList(manager.GetList());
                RefreshGrid();
                attendanceManager.SaveAttendanceFile();

                if (selectedRow < dgvTenantStatus.Rows.Count)
                {
                    dgvTenantStatus.Rows[selectedRow].Selected = true;
                    dgvTenantStatus.CurrentCell = dgvTenantStatus[0, selectedRow];
                }
            }
            catch (Exception)
            {

                RJMessageBox.Show("Something went wrong", "", MessageBoxButtons.OK);
            }
        }

        private void AdminAttendance_Leave(object sender, EventArgs e)
        {
            attendanceManager.SaveAttendanceFile();
        }

        private void RefreshGrid()
        {
            try
            {
                dgvTenantStatus.Rows.Clear();
                foreach (Person p in attendanceManager.GetPeople())
                {
                    dgvTenantStatus.Rows.Add(p.FirstName + " " + p.LastName, p.IsPresent);
                }
                for (int i = 0; i < dgvTenantStatus.Rows.Count; i++)
                {
                    if (dgvTenantStatus.Rows[i].Cells[1].Value.ToString() == "Absent")
                    {
                        dgvTenantStatus.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(11, 7, 17);
                    }
                    else
                    {
                        dgvTenantStatus.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(231, 34, 83);
                    }
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbxSearchName.Texts;

                dgvTenantStatus.Rows.Clear();

                var allPeople = attendanceManager.GetPeople();

                var filteredPeople = string.IsNullOrEmpty(searchText)
                    ? allPeople
                    : allPeople.Where(p => p.FirstName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 || p.LastName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

                foreach (Person person in filteredPeople)
                {
                    dgvTenantStatus.Rows.Add(person.FirstName + " " + person.LastName, person.IsPresent);
                }
                for (int i = 0; i < dgvTenantStatus.Rows.Count; i++)
                {
                    if (dgvTenantStatus.Rows[i].Cells[1].Value.ToString() == "Absent")
                    {
                        dgvTenantStatus.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(11, 7, 17);
                    }
                    else
                    {
                        dgvTenantStatus.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(231, 34, 83);
                    }
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }
        }

        private void dgvTenantStatus_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvTenantStatus.CurrentRow != null)
                {
                    string fullName = dgvTenantStatus.CurrentRow.Cells[0].Value.ToString();
                    string status = dgvTenantStatus.CurrentRow.Cells[1].Value.ToString();

                    string message = $"▶ {status} ◀\n";

                    RJMessageBox.Show($"{message}", $"{fullName}", MessageBoxButtons.OK);
                }
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

        private void moreInfo_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("You can also use double clicks to get more information!", "", MessageBoxButtons.OK);
        }
    }
}
