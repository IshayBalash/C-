using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Square:Shape,IDrawable
    {
        public int Lenght { get; set; }

        /////////////////functions.//////////////////////
        public override string GetHikef()
        {
            return "squre gethikef function is on";
        }

        public override string GetsetachPanim()
        {
            return "squre getdetachpanim function is on";
        }

        public override string PrintInfo()
        {
            return base.PrintInfo() + $"\nsqure lenght:{Lenght}\n";
        }

        public void Draw(){
            for (int i = 0; i < Lenght; i++)
            {
                for (int j = 0; j < Lenght; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();

            }
        }


        /////////ctor/////////
        public Square(int Lenghtparam=5)//defult value
        {
            Lenght = Lenghtparam;
                
        }

    }
}
