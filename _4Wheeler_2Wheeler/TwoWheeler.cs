using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Wheeler_2Wheeler
{
    internal class TwoWheeler : Vehicle, IExterior
    {
        public int FrontBreak { get; set; }
        public int RearBreak { get; set; }

        public void ExteriorDesign(Motorcycle m)
        {
            Console.WriteLine("\n ===================== Motorcycle Detail's ======================== \n");
            Console.WriteLine($"ModelNo: {m.ModelNo}, \nMakeYear: {m.MakeYear}, \nNumOfGear: {m.NumOfGear}, " +
                $"\nNumOfSeat: {m.NumOfSeat}, \nCapacity: {m.EngineCapacity} CC, \nType: {m.Type}, \nMaximum Power: " +
                $"{m.BPH} BPH, \nMax Torque: {m.NM} NM, \nMilege: {m.KMPL} KMPL, \nCooling: {m.Cooling}");

        }
    }
}
