using System;

namespace DesignPattern.Creational_Patterns
{
    /// <summary>
    ///     Prototype Pattern : Specify the kind of objects to create using a prototypical instance, and create new objects by
    ///     copying this prototype.
    /// </summary>
    public class PrototypePattern
    {
        /// <summary>
        ///     Entry point into console application.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("================== Start Prototype Pattern ======================");

            // Create two instances and clone each

            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1) p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2) p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            Console.WriteLine("================== End Prototype Pattern   ======================");
        }

        /// <summary>
        ///     The 'Prototype' abstract class
        /// </summary>
        private abstract class Prototype
        {
            // Constructor
            protected Prototype(string id)
            {
                Id = id;
            }

            // Gets id
            public string Id { get; }

            public abstract Prototype Clone();
        }

        /// <summary>
        ///     A 'ConcretePrototype' class
        /// </summary>
        private class ConcretePrototype1 : Prototype
        {
            // Constructor
            public ConcretePrototype1(string id)
                : base(id)
            {
            }

            // Returns a shallow copy
            public override Prototype Clone()
            {
                return (Prototype) MemberwiseClone();
            }
        }

        /// <summary>
        ///     A 'ConcretePrototype' class
        /// </summary>
        private class ConcretePrototype2 : Prototype
        {
            // Constructor
            public ConcretePrototype2(string id)
                : base(id)
            {
            }

            // Returns a shallow copy
            public override Prototype Clone()
            {
                return (Prototype) MemberwiseClone();
            }
        }
    }
}