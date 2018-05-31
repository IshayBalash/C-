using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hotel : Bulding
    {
        public int Rooms { get; set; }
        public int TakenRooms { get; set; }
        public Enum_country Country { get; set; }
        public List<Enum_services> Services { get; set; }


        public override string GetDetaiks()
        {
            return base.GetDetaiks() + $"number of rooms: {NumberFloors} number of taken rooms: {NumberFloors} country: {Country} services: {Services[0]},{Services[1]},{Services[2]}";
        }


        public Hotel(int numberfloors, bool iselevator) : base(numberfloors, iselevator)
        {
            Rooms = 100;//-defult value
            TakenRooms = 10;//-defult value
            Country = Enum_country.Fracne;//-defult value
            Services = new List<Enum_services>();
            Services.Add(Enum_services.breakfast)  ;
            Services.Add(Enum_services.gym);
            Services.Add(Enum_services.pool);

        }
    }
}
