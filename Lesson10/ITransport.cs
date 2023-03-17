using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    internal interface ITransport
    {
        public int ShipTime { get; set; }
        public int MaxWeight { get; set; }
        public int MinWeight { get; set; }
        public CountryRestractionEnum CountryRestraction { get; set; }
    }
}
