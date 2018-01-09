using System;

namespace CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use salutation class for a Walmart Greeter.
            Salutation oldGuy = new Salutation("Welcome to Walmart!", "Thanks for Shopping at Walmart!");
            // Get the guy to talk....
            Console.WriteLine(oldGuy.Greet());
            Console.WriteLine(oldGuy.SayFareWell());
        }
    }
}
