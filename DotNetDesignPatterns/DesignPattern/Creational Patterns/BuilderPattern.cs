using System;
using System.Collections.Generic;

namespace DesignPattern.Creational_Patterns
{
    /// <summary>
    ///     Builder : Separate the construction of a complex object from its representation so that the same construction
    ///     process can create different representations.
    /// </summary>
    internal class BuilderPattern
    {
        /// <summary>
        ///     Entry point into console application.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("================== Start Bilder Pattern ======================");

            // Create shop with vehicle builders
            var shop = new Shop();

            // Construct and display vehicles
            VehicleBuilder builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.WriteLine("================== End Bridge Pattern ======================");
        }


        /// <summary>
        ///     The 'Director' class
        /// </summary>
        private class Shop
        {
            // Builder uses a complex series of steps
            public void Construct(VehicleBuilder vehicleBuilder)
            {
                vehicleBuilder.BuildFrame();
                vehicleBuilder.BuildEngine();
                vehicleBuilder.BuildWheels();
                vehicleBuilder.BuildDoors();
            }
        }

        /// <summary>
        ///     The 'Builder' abstract class
        /// </summary>
        private abstract class VehicleBuilder
        {
            protected Vehicle vehicle;

            // Gets vehicle instance
            public Vehicle Vehicle => vehicle;

            // Abstract build methods
            public abstract void BuildFrame();

            public abstract void BuildEngine();
            public abstract void BuildWheels();
            public abstract void BuildDoors();
        }

        /// <summary>
        ///     The 'ConcreteBuilder1' class
        /// </summary>
        private class MotorCycleBuilder : VehicleBuilder
        {
            public MotorCycleBuilder()
            {
                vehicle = new Vehicle("MotorCycle");
            }

            public override void BuildFrame()
            {
                vehicle["frame"] = "MotorCycle Frame";
            }

            public override void BuildEngine()
            {
                vehicle["engine"] = "500 cc";
            }

            public override void BuildWheels()
            {
                vehicle["wheels"] = "2";
            }

            public override void BuildDoors()
            {
                vehicle["doors"] = "0";
            }
        }

        /// <summary>
        ///     The 'Product' class
        /// </summary>
        private class Vehicle
        {
            private readonly Dictionary<string, string> _parts =
                new Dictionary<string, string>();

            private readonly string _vehicleType;

            // Constructor
            public Vehicle(string vehicleType)
            {
                _vehicleType = vehicleType;
            }

            // Indexer
            public string this[string key]
            {
                set => _parts[key] = value;
            }

            public void Show()
            {
                Console.WriteLine("\n---------------------------");
                Console.WriteLine("Vehicle Type: {0}", _vehicleType);
                Console.WriteLine(" Frame : {0}", _parts["frame"]);
                Console.WriteLine(" Engine : {0}", _parts["engine"]);
                Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
                Console.WriteLine(" #Doors : {0}", _parts["doors"]);
            }
        }
    }
}