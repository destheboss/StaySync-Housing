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
                    int day, month, year;
                    if (!int.TryParse(cmbDay.Texts, out day) || cmbDay.SelectedItem == null)
                    {
                        RJMessageBox.Show("Please select a valid day.", "", MessageBoxButtons.OK);
                        return;
                    }
                    if (!int.TryParse(cmbMonth.Texts, out month) || cmbMonth.SelectedItem == null)
                    {
                        RJMessageBox.Show("Please select a valid month.", "", MessageBoxButtons.OK);
                        return;
                    }
                    if (!int.TryParse(cmbYear.Texts, out year) || cmbYear.SelectedItem == null)
                    {
                        RJMessageBox.Show("Please select a valid year.", "", MessageBoxButtons.OK);
                        return;
                    }

                    string startTime = cmbStartTime.Texts;
                    if (cmbStartTime.SelectedItem == null)
                    {
                        RJMessageBox.Show("Please select a valid start time.", "", MessageBoxButtons.OK);
                        return;
                    }

                    string endTime = cmbEndTime.Texts;
                    if (cmbEndTime.SelectedItem == null)
                    {
                        RJMessageBox.Show("Please select a valid end time.", "", MessageBoxButtons.OK);
                        return;
                    }

                    string title = tbxTitle.Texts.ToUpper();
                    string description = tbxDescription.Texts;

                    agenda.AddAgenda(day, month, year, startTime, endTime, title, description);
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
