using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle
    {
        public int Positn_x { get; set; }
        public int Positn_Y { get; set; }
        public string Color { get; set; }

        #region raduios
        private int raduios;
        public int Radius
        {
            get { return raduios; }
            set {
                if (value > 0)
                {
                    raduios = value;
                }
                else {
                    raduios = 5;
                        }
                
                
                 }
        }

        #endregion


        public void Printifo()
        {
            Console.WriteLine("circle info:");
            Console.WriteLine($"position x:{Positn_x}");
            Console.WriteLine($"position y:{Positn_Y}");
            Console.WriteLine($"color:{Color}");
            Console.WriteLine($"radius:{Radius}");
        }

        public double CalacSerface() {
            return Math.Pow(Radius,2)+(Math.PI);
        }

        public double CalacHikef()
        {
            return (Radius * 2) * Math.PI;
        }


        public Circle()
        {
            Console.WriteLine("a circle has been made");
        }

    }
}
