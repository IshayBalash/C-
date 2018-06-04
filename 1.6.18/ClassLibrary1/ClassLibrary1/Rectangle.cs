using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class  Rectangle:Shape,IDrawable
    {

        public int Hight { get; set; }
        public int Width { get; set; }





        /////////////////functions.//////////////////////
        public override string GetHikef()
        {
            return "rectangle gethikef function is on";
        }

        public override string GetsetachPanim()
        {
            return "rectangle getdetachpanim function is on";
        }

        public override string PrintInfo()
        {
            return base.PrintInfo() + $"\nrectangle hight:{Hight}\n" +
                $"rectangle width:{Width}\n";
        }

        public void Draw()
        {
            for (int i = 0; i < Hight; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();

            }
        }


        /////////ctor/////////
        public Rectangle(int Hightparam =10,int Widthparam=5)//defult value
        {
            Hight = Hightparam;
            Width = Widthparam;

        }
    }
}
