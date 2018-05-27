using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Squre
    {
        public int Positn_x { get; set; }
        public int Positn_Y { get; set; }
        public string Color { get; set; }

        #region lenght
        private int lenght;
        public int Lenght
        {
            get { return lenght; }
            set
            {
                if (value > 0)
                {
                    lenght = value;
                }
                else
                {
                    lenght = 5;
                }


            }
        }

        #endregion


        public void Printifo()
        {
            Console.WriteLine("circ info:");
            Console.WriteLine($"position x:{Positn_x}");
            Console.WriteLine($"position y:{Positn_Y}");
            Console.WriteLine($"color:{Color}");
            Console.WriteLine($"lenght:{Lenght}");
        }

        public double CalacSerface()
        {
            return Lenght * lenght;
        }

        public double CalacHikef()
        {
            return (lenght * 4); 
        }

        public Squre()
        {
            Console.WriteLine("a squre has been made");
        }
    }
}
