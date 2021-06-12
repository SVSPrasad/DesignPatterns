using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatterns.FactoryPattern
{
    [TestFixture]
    public class FatoryPatternTests
    {
        /*
         * The factory method design pattern abstract the process of object creation and allows 
         * the object to be created at run-time when it is required
         * In Factory pattern, we create the object without exposing the creation logic
         * In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate.
         * The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses
         */

        [Test]
        public void FactoryPatternTest()
        {
            VehicleFactory factory = new ConcreteVehicle();
           // ConcreteVehicle factory = new ConcreteVehicle();

            IVehicle scooter = factory.GetVehicle("Scooter");
            scooter.Drive(100);

            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive(400);

        }

    }
}
