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
            try
            {
                if (!string.IsNullOrWhiteSpace(tbxTitle.Texts) && !string.IsNullOrWhiteSpace(tbxDescription.Texts))
                {
                    agenda.AddAgenda(Convert.ToInt32(cmbDay.Texts),
                                 Convert.ToInt32(cmbMonth.Texts),
                                 Convert.ToInt32(cmbYear.Texts),
                                 cmbStartTime.Texts,
                                 cmbEndTime.Texts,
                                 tbxTitle.Texts.ToUpper(),
                                 tbxDescription.Texts);
                    RJMessageBox.Show("The event was created.", "", MessageBoxButtons.OK);
                }
                else
                {
                    RJMessageBox.Show("Please fill in the information first.", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {

                RJMessageBox.Show("Please fill in the information first.", "", MessageBoxButtons.OK);
            }

            cmbDay.SelectedItem = "XX";
            cmbMonth.SelectedItem = "XX";
            cmbYear.SelectedItem = "XXXX";
            cmbStartTime.SelectedItem = "XX:XX";
            cmbEndTime.SelectedItem = "XX:XX";
            tbxTitle.Texts = "";
            tbxDescription.Texts = "";
            agenda.WriteToFile();
        }
    }
}
