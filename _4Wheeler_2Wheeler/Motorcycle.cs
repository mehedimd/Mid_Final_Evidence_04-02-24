using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Wheeler_2Wheeler
{
    internal sealed class Motorcycle : TwoWheeler
    {
        public double BPH { get; set; }
        public double KMPL { get; set; }
        public double NM { get; set; }
        public string Cooling { get; set; }

        public Motorcycle()
        {
            Type = VehicleType.TwoWheeler;
        }
    }
}
