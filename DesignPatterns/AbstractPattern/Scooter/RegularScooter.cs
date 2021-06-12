using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractPattern
{
    class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Vehicle Name : Regular Scooter";
        }
    }
}
