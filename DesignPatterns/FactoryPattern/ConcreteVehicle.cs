using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    class ConcreteVehicle : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicle)
        {
           switch(vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new Exception();

            }
        }
    }
}
