using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    class Bike : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Miles driven by Bike " + miles);
        }
    }
}
