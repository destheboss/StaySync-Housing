using CsvHelper;
using housing;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace housing
{
    public class ForgetManager
    {
        private int randomNumber;

        public bool IsPhoneValid(string phoneNumber)
        {
            if (String.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Enter a phone number first.");
                return false;
            }
            foreach (char c in phoneNumber)
            {
                if (c == '+')
                {
                    if (phoneNumber.Length == 12)
                    {
                        return true;
                    }
                }
            }
            MessageBox.Show("Invalid phone number try again.");
            return false;
        }

        public void GenerateNumber()
        {
            Random random = new Random();
            this.randomNumber = random.Next(1000000, 10000000);
        }

        public void ItIsSMSTime(string phoneNumber)
        {
            //might make it a seperate class to make sure
            WebClient client = new WebClient();
            string to, message;
            to = phoneNumber;
            message = Convert.ToString(this.randomNumber);
            string baseURL = "https://platform.clickatell.com/messages/http/send?apiKey=cBmEQv2yRreYo9d9SVK2cA==&to=" + to + "'&content=" + message + "'";
            client.OpenRead(baseURL);
            MessageBox.Show("An SMS has been sent containing a code");
        }

        public bool IsRandomNumberCorrect(int input)
        {
            return input == this.randomNumber;
        }

        public void SearchData(string phone, List<Person> persons)
        {
            foreach (Person p in persons)
            {
                if (p.DoesThePhoneMatch(phone) == true)
                {
                    p.GetReadyToMail();
                    break;
                }
            }
        }

        public void ItIsMailTime(string email, int code)
        {
            var to = email;
            var from = "implement@svenverstegen.tech";
            var subject = "your QR code";
            var password = "poeppoep";
            var host = "mail.svenverstegen.tech";
            var port = 587;

            using (var client = new SmtpClient())
            {

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = "<img src='http://i499309.hera.fhict.nl/Images/" + code + ".png'/> <h1>" + code + "</h1>",
                    TextBody = "{formData.ID}\r\n{ formData.subject}\r\n{formData.body}\r\n{formData.Email}"
                };


                var message = new MimeMessage();

                message.From.Add(new MailboxAddress("noReply", from));
                message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", to));
                message.Subject = subject;
                message.Body = bodyBuilder.ToMessageBody();

                try
                {
                    client.Connect(host, port, MailKit.Security.SecureSocketOptions.None);
                    client.Authenticate(from, password);
                    client.Send(message);
                    client.Disconnect(true);
                    MessageBox.Show("A mail containing a picture of your code as well as the code itself has been send to your email adress.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
