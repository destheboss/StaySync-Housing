using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    internal class contact
    {
        public string Number { get; set; }
        public string WappNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public contact(string number, string wappNumber, string email, string address)
        {
            this.Number = number;
            this.WappNumber = wappNumber;
            this.Email = email;
            this.Address = address;
        }

        public string GetNumber() { return this.Number; }
        public string GetWappNumber() { return this.WappNumber; }
        public string GetEmail() { return this.Email; }
        public string GetAddress() { return this.Address; }
    }
}
