using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string Vehicle);
    }
}
