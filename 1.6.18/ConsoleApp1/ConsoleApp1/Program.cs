using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square Squre1 = new Square(15);
            Console.WriteLine(Squre1.PrintInfo());
            Console.WriteLine(Squre1.GetHikef());
            Console.WriteLine(Squre1.GetsetachPanim());
            Squre1.Draw();
            Console.WriteLine("\n");
            Rectangle Rectangle1 = new Rectangle(7,10);
            Console.WriteLine(Rectangle1.PrintInfo());
            Console.WriteLine(Rectangle1.GetHikef());
            Console.WriteLine(Rectangle1.GetsetachPanim());
            Rectangle1.Draw();
            Console.ReadLine();

        }
    }
}
