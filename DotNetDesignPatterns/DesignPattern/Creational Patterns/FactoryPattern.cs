using System;
using System.Collections.Generic;

namespace DesignPattern.Creational_Patterns
{
    /// <summary>
    ///     Factory Method : Define an interface for creating an object, but let subclasses decide which class to instantiate.
    ///     Factory Method lets a class defer instantiation to subclasses.
    /// </summary>
    public class FactoryPattern
    {
        /// <summary>
        ///     Entry point into console application.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("================== Start Bilder Pattern ======================");

            // Note: constructors call Factory Method
            var documents = new Document[1];

            documents[0] = new Resume();

            // Display document pages
            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (var page in document.Pages)
                    Console.WriteLine(" " + page.GetType().Name);
            }

            Console.WriteLine("================== End Bridge Pattern ======================");
        }

        /// <summary>
        ///     The 'Product' abstract class
        /// </summary>
        private abstract class Page
        {
        }

        /// <summary>
        ///     A 'ConcreteProduct' class
        /// </summary>
        private class SkillsPage : Page
        {
        }

        /// <summary>
        ///     The 'Creator' abstract class
        /// </summary>
        private abstract class Document
        {
            // Constructor calls abstract Factory method
            protected Document()
            {
                // ReSharper disable once VirtualMemberCallInConstructor
                CreatePages();
            }

            public List<Page> Pages { get; } = new List<Page>();

            // Factory Method
            public abstract void CreatePages();
        }

        /// <summary>
        ///     A 'ConcreteCreator' class
        /// </summary>
        private class Resume : Document
        {
            // Factory Method implementation
            public override void CreatePages()
            {
                Pages.Add(new SkillsPage());
                //Pages.Add(new EducationPage());
                //Pages.Add(new ExperiencePage());
            }
        }
    }
}