using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatterns.FactoryPattern
{
    [TestFixture]
    public class FatoryPatternTests
    {
        [Test]
        public void Test1()
        {
            VehicleFactory factory = new ConcreteVehicle();

            IVehicle scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive(20);

        }

    }
}
