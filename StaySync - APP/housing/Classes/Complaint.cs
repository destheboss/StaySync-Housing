using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    internal class Complaint
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string WhoOrWhere { get; set; }
        public string ComplaintText { get; set; }
        public bool IsResolved { get; set; }

        public string GetInfo()
        {
            return $"{ID},{From},{Subject},{WhoOrWhere},{ComplaintText},{IsResolved}";
        }
    }
}