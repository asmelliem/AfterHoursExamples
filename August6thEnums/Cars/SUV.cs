using August6thEnums.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace August6thEnums.Cars
{
    public class SUV : IAutomobile
    {
        public int Mileage { get ; set ; }
        public CarType Type { get ; set; }

        public void VroomVroom()
        {
            Console.WriteLine("I go vroom vroom loudly");
        }
    }
}
