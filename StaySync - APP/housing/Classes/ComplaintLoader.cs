    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    internal class ComplaintLoader
    {
        public bool IsItYourself(Person p)
        {
            User u = new User();
            return $"{p.FirstName} {p.LastName}" == $"{u.FirstName} {u.LastName}";
        }

        public bool IsItATenant(Person p)
        {
            return p.IsAdmin == "no";
        }

        public string WriteTenant(Person p, int i = 0)
        {
            return $"{(i != 0 ? p.RoomNumber + " " : "")}{p.FirstName} {p.LastName}";
        }

        public string WriteAdmin(Person p)
        {
            return $"{p.FirstName} {p.LastName}";
        }
    }
}