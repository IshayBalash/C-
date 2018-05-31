using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Bulding
    {
        private int v;

        public int NumberFloors { get; set; }

        public bool IsElevator { get; set; }


        public virtual string GetDetaiks()
        {
            return $"number of floors:{NumberFloors} elevator:{IsElevator}";
        }

        
        public Bulding(int numberfloors,bool iselevator)
        {
            NumberFloors = numberfloors;
            IsElevator = iselevator;
        }

        
    }
}
