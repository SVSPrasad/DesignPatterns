using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractPattern
{
    [TestFixture]
    class AbstractPatternTests
    {
        [Test]
        public void AbstractPatternTest()
        {
            IVehicleFactory honda = new HondaFactory();
            VehicleClient hondaclient;

            Console.WriteLine("******* Honda **********");
            hondaclient = new VehicleClient(honda, "Regular");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            hondaclient = new VehicleClient(honda, "Sports");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            IVehicleFactory hero = new HeroFactory();
            VehicleClient heroclient;

            Console.WriteLine("******* Hero **********");
            heroclient = new VehicleClient(hero, "Regular");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

            heroclient = new VehicleClient(hero, "Sports");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

        }
    }
}
