﻿using housing.Classes;
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
    public partial class TenantAttendance : Form
    {
        private AttendanceManager attendanceManager;
        private User user = new User();
        private int indexRow;
        private PersonManager manager;
        public TenantAttendance(PersonManager m)
        {
            InitializeComponent();
            this.manager = m;
            attendanceManager = new AttendanceManager(manager.GetList());
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
            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.attendance_invert);

            btnClose.Text = $"  {manager.CurrentUser.FirstName}";
            btnAbsent.Visible = false;
            btnPresent.Visible = false;
        }
        private void tenantattendance_Load(object sender, EventArgs e)
        {
            attendanceManager.LoadAttendanceFromFile();
            RefreshGrid();
        }

        private void dgvTenantStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = dgvTenantStatus.CurrentCell.RowIndex;
            dgvTenantStatus.Rows[indexRow].Selected = true;

            string selectedPersonName = dgvTenantStatus.Rows[indexRow].Cells[0].Value.ToString();
            string currentUserName = manager.CurrentUser.FirstName + " " + manager.CurrentUser.LastName;

            btnAbsent.Visible = selectedPersonName == currentUserName;
            btnPresent.Visible = selectedPersonName == currentUserName;
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = user.FirstName + " " + user.LastName;

                string gettingName = dgvTenantStatus.Rows[indexRow].Cells[0].Value.ToString();
                if (gettingName == fullName)
                {
                    attendanceManager.ChangeUserStatus(gettingName, "Absent");
                    RJMessageBox.Show($"You changed your status to < Absent >", "", MessageBoxButtons.OK);

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
                else
                {
                    RJMessageBox.Show("Please choose the correct person!", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = user.FirstName + " " + user.LastName;

                string gettingName = dgvTenantStatus.Rows[indexRow].Cells[0].Value.ToString();
                if (gettingName == fullName)
                {

                    attendanceManager.ChangeUserStatus(gettingName, "Present");
                    RJMessageBox.Show($"You changed your status to < Present >", "", MessageBoxButtons.OK);

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
                else
                {
                    RJMessageBox.Show("Please choose the correct person!", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK);
            }

        }

        private void RefreshGrid()
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

        private void tenantattendance_Leave(object sender, EventArgs e)
        {
            attendanceManager.SaveAttendanceFile();
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
