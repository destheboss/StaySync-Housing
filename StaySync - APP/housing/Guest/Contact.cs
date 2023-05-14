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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            string location = "https://www.studenthousingholland.com/faq/";
            webView21.Source = new Uri(location);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }
    }
}
