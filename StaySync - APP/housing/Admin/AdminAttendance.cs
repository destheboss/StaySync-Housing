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
        public AdminAttendance()
        {
            InitializeComponent();
            #region COLORS DATAGRID
            dgvTenantStatus.BackgroundColor = Color.FromArgb(231, 34, 83);
            dgvTenantStatus.GridColor = Color.FromArgb(11, 7, 17);
            dgvTenantStatus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 34, 83);
            dgvTenantStatus.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvTenantStatus.DefaultCellStyle.ForeColor = Color.White;
            dgvTenantStatus.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvTenantStatus.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvTenantStatus.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTenantStatus.EnableHeadersVisualStyles = false;
            #endregion
        }

    }
}
