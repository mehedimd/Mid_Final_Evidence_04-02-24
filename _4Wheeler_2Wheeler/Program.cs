 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Wheeler_2Wheeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------- Answer 01 ------------------------------
            // console color change
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            // =============================== Create Car Object =============================
            Car c1 = new Car()
            {
                ModelNo = "C1",
                MakeYear = 2015,
                EngineCapacity = 5,
                NumOfDoor = 4,
                NumOfGear = 7,
                NumOfSeat = 8

            };
            // ================================= Print Car Details ================================
            c1.InteriorDesign(c1);

            // ============================Create Motorcycle Object==========================

            Motorcycle m1 = new Motorcycle()
            {
                ModelNo = "m25",
                MakeYear = 2020,
                EngineCapacity = 3000,
                NumOfGear = 5,
                NumOfSeat = 3,
                BPH = 500,
                KMPL = 600,
                NM = 650,
                FrontBreak = 2,
                RearBreak = 1,
                Cooling = "Cooling available "
            };
            // ================================== Print Motorcycle Details =====================================
            m1.ExteriorDesign(m1);





            Console.ReadKey();
        }
    }
}
