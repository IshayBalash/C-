using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    delegate Boolean funckHandler(int num1, int num2);
    class Calc
    {
        public event  funckHandler CalcAction;


        public bool  CalcFunk(int num1, int num2)
        {
            if (CalcAction != null)
            {
                bool result = CalcAction(num1, num2);
                return result;

            }
            else
            {
                Console.WriteLine("what the fuck");
                return false;
            }
            
        }
    }
}
