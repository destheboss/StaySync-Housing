using CsvHelper;
using housing;
using housing.CustomElements;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
                RJMessageBox.Show("Enter a phone number first.");
                return false;
            }
            string pattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
            if (Regex.IsMatch(phoneNumber, pattern))
            {
                return true;
            }
            RJMessageBox.Show("Invalid phone number try again.");
            return false;
        }

        public void GenerateNumber()
        {
            Random random = new Random();
            this.randomNumber = random.Next(100000, 1000000);
        }

        public void ItIsSMSTime(string phoneNumber)
        {
            WebClient client = new WebClient();
            string to, message;
            to = phoneNumber;
            message = Convert.ToString(this.randomNumber);
            string baseURL = "https://platform.clickatell.com/messages/http/send?apiKey=GYJ6ChDFTZmLgzO2-erqRw==&to=" + to + "'&content=" + "Your verification code is: " + message;
            client.OpenRead(baseURL);
            RJMessageBox.Show("An SMS has been sent containing a code");
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
            var from = "help.staysync@gmail.com";
            var subject = "Your QR code";
            var password = "dpinlfdbxlxaduyx";
            var host = "smtp.gmail.com";
            var port = 587;

            using (var client = new SmtpClient())
            {

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = "<img src='http://i499309.hera.fhict.nl/Images/" + code + ".png'/> <h1>" + code + "</h1>",
                    TextBody = "{formData.ID}\r\n{ formData.subject}\r\n{formData.body}\r\n{formData.Email}"
                };


                var message = new MimeMessage();

                message.From.Add(new MailboxAddress("StaySync Support", from));
                message.To.Add(new MailboxAddress("Claudiu Gabriel Badea", to));
                message.Subject = subject;
                message.Body = bodyBuilder.ToMessageBody();

                try
                {
                    client.Connect(host, port, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate(from, password);
                    client.Send(message);
                    client.Disconnect(true);
                }
                catch (Exception)
                {
                    RJMessageBox.Show("Something went wrong.");
                }
            }
        }
    }
}
