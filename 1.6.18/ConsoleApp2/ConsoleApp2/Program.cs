using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc Calc1 = new Calc();
            Console.WriteLine("--------calc 1--------");
            /*
            Calc1.CalcAction += (int num1, int num2) =>
              {
                  if (num1 > num2)
                  {
                      
                      return true;
                  }
                  else
                  {
                      
                      return false;
                  }
              };
              */
            bool result = Calc1.CalcFunk(4, 2);
            Console.WriteLine($"{result}");
            
           
        }
    }
}
