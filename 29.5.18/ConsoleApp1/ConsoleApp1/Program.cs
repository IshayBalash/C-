using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulding[] HotelLIst = new Bulding[5];
            for (int i = 0; i < HotelLIst.Length; i++)
            {
                HotelLIst[i] = new Hotel(5, true);
            }


            HotelLIst[2].IsElevator = false;
            HotelLIst[3].NumberFloors = 1;


            foreach (Bulding item in HotelLIst)
            {
                Console.WriteLine(item.GetDetaiks());
            }

        }
    }
}
