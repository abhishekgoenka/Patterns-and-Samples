using System;
using DesignPattern.Creational_Patterns;
using DesignPattern.Structural_Patterns;

namespace DesignPattern
{
    public class Program
    {
        static void Main()
        {
            #region Creational Patterns

            //Abstract Factory
            AbstractFactory abstractFactory = new AbstractFactory();
            abstractFactory.Execute();

            //Prototype
            PrototypePattern prototypePattern = new PrototypePattern();
            prototypePattern.Execute();

            #endregion

            #region Structural Patterns

            //Adapter
            AdapterPattern adapterPattern = new AdapterPattern();
            adapterPattern.Execute();

            //Bridge
            Bridge bridge = new Bridge();
            bridge.Execute();

            //proxy
            ProxyPattern proxyPattern = new ProxyPattern();
            proxyPattern.Execute();

            #endregion

            // Wait for user
            Console.ReadKey();
        }
    }
}