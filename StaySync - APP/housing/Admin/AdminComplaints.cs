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
using System.IO;

namespace housing
{
    public partial class AdminComplaints : Form
    {
        private PersonManager _personManager;
        private ComplaintViewerManager _manager = new ComplaintViewerManager();
        public AdminComplaints(PersonManager m)
        {
            InitializeComponent();
            _personManager = m;
            InitializeDataGridView(dgvPeople);
            InitializeDataGridView(dgvRoom);
            InitializeDataGridView(dgvGeneral);
            InitializeDataGridView(dgvAdmins);

            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.attendance_invert);
            btnClose.Text = $"  {_personManager.CurrentUser.LastName}";
        }

        private void InitializeDataGridView(DataGridView dataGridView)
        {
            #region FORMATTING
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 34, 83);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 34, 83);
            dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 34, 83);
            dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = dataGridView.RowHeadersDefaultCellStyle.ForeColor;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridView.GridColor = Color.FromArgb(11, 7, 17);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 34, 83);
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dataGridView.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            #endregion

            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns["ID"].Visible = false;
            dataGridView.Columns.Add("From", "From");
            dataGridView.Columns.Add("Subject", "Subject");
            dataGridView.Columns.Add("WhoOrWhere", "Who/Where");
            dataGridView.Columns.Add("ComplaintText", "Complaint");

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AdminComplaints_Load(object sender, EventArgs e)
        {
            ReloadComplaints();
        }

        private void dgvAboutYou_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowComplaintDetails(dgvPeople);
        }

        private void dgvRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowComplaintDetails(dgvRoom);
        }

        private void dgvGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowComplaintDetails(dgvGeneral);
        }

        private void dgvAdmins_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowComplaintDetails(dgvAdmins);
        }

        private void ShowComplaintDetails(DataGridView dataGridView)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView.SelectedRows[0];

                    string from = Convert.ToString(row.Cells["From"].Value);
                    string subject = Convert.ToString(row.Cells["Subject"].Value);
                    string whoOrWhere = Convert.ToString(row.Cells["WhoOrWhere"].Value);
                    string complaintText = Convert.ToString(row.Cells["ComplaintText"].Value);

                    if (string.IsNullOrEmpty(whoOrWhere))
                    {
                        whoOrWhere = "-";
                    }

                    string formattedText = $"▶ {from} ◀ \nSubject: {subject} \nWho/Where: {whoOrWhere} \nComplaint: {complaintText}";

                    RJMessageBox.Show(formattedText, "Complaint Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView currentDataGridView = GetCurrentDataGridView();
                if (currentDataGridView != null && currentDataGridView.SelectedRows.Count > 0)
                {
                    DialogResult result = RJMessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = currentDataGridView.SelectedRows[0];
                        int complaintId = Convert.ToInt32(row.Cells["ID"].Value);
                        _manager.ResolveComplaint(complaintId);
                        ReloadComplaints();
                    }
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.");
            }
        }

        private void ReloadComplaints()
        {
            ClearDataGrids();
            _manager.LoadComplaints();
            List<Complaint> complaints = _manager.Complaints;
            foreach (Complaint c in complaints)
            {
                AddComplaintToGrid(c);
            }
        }

        private void ClearDataGrids()
        {
            dgvPeople.Rows.Clear();
            dgvRoom.Rows.Clear();
            dgvGeneral.Rows.Clear();
            dgvAdmins.Rows.Clear();
        }

        private void AddComplaintToGrid(Complaint c)
        {
            string whoOrWhere = string.IsNullOrEmpty(c.WhoOrWhere) ? "-" : c.WhoOrWhere;
            if (c.Subject == "GENERAL")
            {
                dgvGeneral.Rows.Add(c.ID, c.From, c.Subject, whoOrWhere, c.ComplaintText);
            }
            else if (c.Subject == "ROOM")
            {
                dgvRoom.Rows.Add(c.ID, c.From, c.Subject, whoOrWhere, c.ComplaintText);
            }
            else if (c.Subject == "TENANT")
            {
                dgvPeople.Rows.Add(c.ID, c.From, c.Subject, whoOrWhere, c.ComplaintText);
            }
            else if (c.Subject == "ADMIN")
            {
                dgvAdmins.Rows.Add(c.ID, c.From, c.Subject, whoOrWhere, c.ComplaintText);
            }
        }

        private DataGridView GetCurrentDataGridView()
        {
            if (tbComplaints.SelectedTab == tabGeneral)
            {
                return dgvGeneral;
            }
            else if (tbComplaints.SelectedTab == tabRoom)
            {
                return dgvRoom;
            }
            else if (tbComplaints.SelectedTab == tabPeople)
            {
                return dgvPeople;
            }
            else if (tbComplaints.SelectedTab == tabAdmins)
            {
                return dgvAdmins;
            }

            return null;
        }

        private void moreInfo_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("You can also use double clicks to get more information!", "", MessageBoxButtons.OK);
        }
    }
}
