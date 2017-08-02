using System;

namespace DesignPattern.Structural_Patterns
{
    /// <summary>
    ///     Proxy : Provide a surrogate or placeholder for another object to control access to it.
    /// </summary>
    internal class ProxyPattern
    {
        /// <summary>
        ///     Entry point into console application.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("================== Start Proxy Pattern ======================");

            // Create proxy and request a service
            var proxy = new Proxy();
            proxy.Request();

            Console.WriteLine("================== End Prototype Pattern   ======================");
        }

        /// <summary>
        ///     The 'Subject' abstract class
        /// </summary>
        private abstract class Subject
        {
            public abstract void Request();
        }

        /// <summary>
        ///     The 'RealSubject' class
        /// </summary>
        private class RealSubject : Subject
        {
            public override void Request()
            {
                Console.WriteLine("Called RealSubject.Request()");
            }
        }

        /// <summary>
        ///     The 'Proxy' class
        /// </summary>
        private class Proxy : Subject
        {
            private RealSubject _realSubject;

            public override void Request()
            {
                // Use 'lazy initialization'
                if (_realSubject == null)
                    _realSubject = new RealSubject();

                _realSubject.Request();
            }
        }
    }
}