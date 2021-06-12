using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractPattern
{
    interface IVehicleFactory // Abstract Factory
    {
        IBike GetBike(string Bike);
        IScooter GetScooter(string Scooter);
    }
}
