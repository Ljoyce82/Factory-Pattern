using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   public static class VehicleFactory
    {
        public static IVehicle GetRide(string numberOfWheels)
        {
            while (true)
            {
                switch(numberOfWheels.ToLower())
                {
                    case "4":
                        return new Car();

                    case "2":
                        return new Motorcycle();

                    default:
                        Console.WriteLine("Please choose 2 or 4 wheels");
                        numberOfWheels = Console.ReadLine();
                        break;
                }

            }
        }
    }
}
