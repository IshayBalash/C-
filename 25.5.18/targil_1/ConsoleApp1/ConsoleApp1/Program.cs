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
            Circle circle1 = new Circle();
            Console.WriteLine($"enter positn x");
            circle1.Positn_x = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter positn y");
            circle1.Positn_Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter radius");
            circle1.Radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter color");
            circle1.Color =Console.ReadLine();
            circle1.Printifo();


            Console.WriteLine("\n");
            Squre squre1 = new Squre();
            Console.WriteLine($"enter positn x");
            squre1.Positn_x = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter positn y");
            squre1.Positn_Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter lenght");
            squre1.Lenght = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter color");
            squre1.Color = Console.ReadLine();
            squre1.Printifo();
        }
    }
}
