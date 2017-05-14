using System;

/// <summary>
/// Convert the interface of a class into another interface clients expect. 
/// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
/// </summary>
public class AdapterPattern
{
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
        // Showing the Adapteee in standalone mode
        Adaptee first = new Adaptee();
        Console.Write("Before the new standard\nPrecise reading: ");
        Console.WriteLine(first.SpecificRequest(5, 3));

        // What the client really wants
        ITarget second = new Adapter();
        Console.WriteLine("\nMoving to the new standard");
        Console.WriteLine(second.Request(5));
    }

    // Existing way requests are implemented
    public class Adaptee
    {
        // Provide full precision
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }

    // Required standard for requests
    interface ITarget
    {
        // Rough estimate required
        string Request(int i);
    }

    // Implementing the required standard via Adaptee
    public class Adapter : Adaptee, ITarget
    {
        public string Request(int i)
        {
            return "Rough estimate is " + (int)Math.Round(SpecificRequest(i, 3));
        }
    }
}

