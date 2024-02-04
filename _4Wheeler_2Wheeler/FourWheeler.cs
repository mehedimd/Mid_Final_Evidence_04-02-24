using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Wheeler_2Wheeler
{
    internal class FourWheeler : Vehicle, IInterior
    {
        public int NumOfDoor { get; set; }

        public void InteriorDesign(Car c)
        {
            Console.WriteLine("\n===================== Car Detail's ======================== \n");
            Console.WriteLine($"ModelNo: {c.ModelNo},\nMakeYear: {c.MakeYear}, \nNumOfGear: {c.NumOfGear}, " +
                $"\nNumOfSeat: {c.NumOfSeat}, \nCapacity: {c.EngineCapacity} CC, \nType: {c.Type}, \nNumOfDoor: {c.NumOfDoor}");
        }
    }
}
