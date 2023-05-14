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
        public TenantChores()
        {
            InitializeComponent();
            #region COLORS DATAGRID
            dgvChores.BackgroundColor = Color.FromArgb(231, 34, 83);
            dgvChores.GridColor = Color.FromArgb(11, 7, 17);
            dgvChores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 34, 83);
            dgvChores.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvChores.DefaultCellStyle.ForeColor = Color.White;
            dgvChores.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvChores.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvChores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChores.EnableHeadersVisualStyles = false;
            #endregion
        }

    }
}
