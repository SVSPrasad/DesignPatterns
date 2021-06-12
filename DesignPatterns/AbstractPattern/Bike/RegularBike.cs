using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractPattern
{
    class RegularBike : IBike
    {
        public string Name()
        {
            return "Vehicle Name : Regular Bike";
        }
    }
}
