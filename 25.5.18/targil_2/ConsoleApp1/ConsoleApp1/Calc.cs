using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     static class Calc
    {
        private static DateTime time;
        static  Calc()
        {
            time = DateTime.Now;
            Console.WriteLine($"the time is :{time}");
        }

        public static int Sum(int param1,int param2)
        {
            return param1 + param2;
        }

        public static int Sum(int param1, int param2,int param3)
        {
            return param1 + param2+param3;
        }

        public static double Sum(double param1, double param2)
        {
            return param1 + param2;
        }

    }
}
