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

namespace housing.Classes
{
    public partial class CreateEvent : Form
    {
        private AgendaManager agenda;
        public CreateEvent(AgendaManager agenda)
        {
            InitializeComponent();
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.agenda = agenda;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            agenda.AddAgenda(Convert.ToInt32(cmbDay.Texts),
                             Convert.ToInt32(cmbMonth.Texts),
                             Convert.ToInt32(cmbYear.Texts),
                             cmbStartTime.Texts,
                             cmbEndTime.Texts,
                             tbxTitle.Texts.ToUpper(),
                             tbxDescription.Texts);
            cmbDay.SelectedItem = null;
            cmbMonth.SelectedItem = null;
            cmbYear.SelectedItem = null;
            cmbStartTime.SelectedItem = null;
            cmbEndTime.SelectedItem = null;
            tbxTitle.Texts = "";
            tbxDescription.Texts = "";
            RJMessageBox.Show("The event was created.", "", MessageBoxButtons.OK);
            agenda.WriteToFile();
        }
    }
}
