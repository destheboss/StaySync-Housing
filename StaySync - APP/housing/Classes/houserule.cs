using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    internal class houserule
    {
        public int ID { get; set; }
        public string HouseRule { get; set; }
        public houserule(int id, string houserule)
        {
            this.ID = id;
            this.HouseRule = houserule;
        }

        public string GetHouseRule()
        {
            return $"  ■ {this.HouseRule}";
        }

        public string GetHouseRuleMessage()
        {
            return $"▶ {this.HouseRule} ◀";
        }

        public string WriteHouseRuleMessage()
        {
            return $"{this.HouseRule}";
        }
    }
}
