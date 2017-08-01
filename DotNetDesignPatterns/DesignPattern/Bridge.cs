﻿using System;

namespace DesignPattern
{
    /// <summary>
    /// Bridge Design Pattern - Decouple an abstraction from its implementation so that the two can vary independently.
    /// </summary>
    public class Bridge
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The 'Abstraction' class
        /// </summary>
        class Abstraction
        {
            protected Implementor implementor;

            // Property
            public Implementor Implementor
            {
                set { implementor = value; }
            }

            public virtual void Operation()
            {
                implementor.Operation();
            }
        }

        /// <summary>
        /// The 'Implementor' abstract class
        /// </summary>
        abstract class Implementor
        {
            public abstract void Operation();
        }

        /// <summary>
        /// The 'RefinedAbstraction' class
        /// </summary>
        class RefinedAbstraction : Abstraction
        {
            public override void Operation()
            {
                implementor.Operation();
            }
        }

        /// <summary>
        /// The 'ConcreteImplementorA' class
        /// </summary>
        class ConcreteImplementorA : Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementorA Operation");
            }
        }

        /// <summary>
        /// The 'ConcreteImplementorB' class
        /// </summary>
        class ConcreteImplementorB : Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementorB Operation");
            }
        }
    }
}