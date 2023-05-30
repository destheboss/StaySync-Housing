using housing.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing.Classes
{
    public partial class ComplaintViewer : Form
    {
        private User _user = new User();
        private ComplaintViewerManager _manager = new ComplaintViewerManager();

        public ComplaintViewer()
        {
            InitializeComponent();
            InitializeDataGridView(dgvAboutYou);
            InitializeDataGridView(dgvRoom);
            InitializeDataGridView(dgvGeneral);
            this.btnClose.DialogResult = DialogResult.Cancel;
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
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
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
   

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComplaintViewer_Load(object sender, EventArgs e)
        {
            this._manager.LoadComplaints();
            List<Complaint> complaints = this._manager.Complaints;
            foreach (Complaint c in complaints)
            {
                string whoOrWhere = string.IsNullOrEmpty(c.WhoOrWhere) ? "-" : c.WhoOrWhere;

                if (c.Subject == "GENERAL")
                {
                    dgvGeneral.Rows.Add(c.ID, c.From, c.Subject, whoOrWhere, c.ComplaintText);
                }

                if (c.Subject == "ROOM")
                {
                    dgvRoom.Rows.Add(c.ID, c.From, c.Subject, whoOrWhere, c.ComplaintText);
                }

                if (c.Subject == "TENANT" && whoOrWhere == this._user.GetName())
                {
                    dgvAboutYou.Rows.Add(c.ID, c.From, c.Subject, whoOrWhere, c.ComplaintText);
                }
            }
        }

        private void dgvAboutYou_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowComplaintDetails(dgvAboutYou);
        }

        private void dgvRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowComplaintDetails(dgvRoom);
        }

        private void dgvGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowComplaintDetails(dgvGeneral);
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

                    RJMessageBox.Show(formattedText, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                RJMessageBox.Show("Something went wrong.");
            }
        }
    }
}