using housing.Classes;
using housing.CustomElements;
using Microsoft.Web.WebView2.Core;
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

namespace housing
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            string location = "https://www.studenthousingholland.com/faq/";
            webView21.Source = new Uri(location);

            webView21.NavigationCompleted += WebView21_NavigationCompleted;

            ButtonDesignHelper.SetButtonStyles(btnClose);
            ButtonDesignHelper.SetImageButtonStyle(btnClose, btnClose.Image, housing.Properties.Resources.exit_invert);

        }

        private async void WebView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            // Scroll down the page by two times
            string script = "window.scrollBy(0, 40);";
            await webView21.ExecuteScriptAsync(script);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] files = Directory.GetFiles(desktopPath, "contact.txt", SearchOption.AllDirectories);

            if (files.Length > 0)
            {
                string fullPath = files.First();
                string[] lines = File.ReadAllLines(fullPath);

                try
                {
                    lbPhone.Text = string.IsNullOrEmpty(lines[0])
                        ? "Telephone Number: +3113 204 0149"
                        : "Telephone Number: " + lines[0];

                    lbWapp.Text = string.IsNullOrEmpty(lines[1])
                        ? "WhatsApp: +31 6 83 40 60 07"
                        : "WhatsApp: " + lines[1];

                    lbEmail.Text = string.IsNullOrEmpty(lines[2])
                        ? "Email Address: info@studenthousingholland.com"
                        : "Email Address: " + lines[2];

                    lbAddress.Text = string.IsNullOrEmpty(lines[3])
                        ? "Visiting address: Willem II 6A, 5038 BG, Tilburg"
                        : "Visiting address: " + lines[3];
                }
                catch (Exception)
                {
                }
            }
            else
            {
                RJMessageBox.Show("The file could not be read.");
            }
        }
    }
}
