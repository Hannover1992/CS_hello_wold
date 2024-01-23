
using System;
using HelloWorld; // Include the namespace of the Greeter class

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            Console.WriteLine(greeter.GetGreeting());
        }
    }
}
