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
            int result1=Calc.Sum(2, 4);
            Console.WriteLine($"the result of 2+4={result1}");
            int result2 = Calc.Sum(2, 4, 6);
            Console.WriteLine($"the result of 2+4+6={result2}");
            double result3 = Calc.Sum(2.4 ,8.3);
            Console.WriteLine($"the result of 2.4+8.3={result3}");

        }
    }
}
