using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Shape 
    {

        public int Position_x { get; set; }

        public int Position_Y { get; set; }

        public string Color { get; set; }



        public virtual string PrintInfo()
        {
            return $"info:\npositin x:{Position_x}\npositin y:{Position_Y}\ncolor:{Color}";
        }

        abstract public string GetsetachPanim();

        abstract public string GetHikef();

        public Shape()//set defult valua
        {
            Position_x = 5;
            Position_Y = 10;
            Color = "blue";
        }

    }
}
