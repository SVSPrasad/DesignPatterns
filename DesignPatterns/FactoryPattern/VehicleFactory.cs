using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string Vehicle);

        public int GetTankCapacityInMilliLiters(int capacity)
        {
            return capacity * 1000;
        }
    }
}
