using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    class Scooter : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Miles driven by Sooter " + miles);
        }
    }
}
