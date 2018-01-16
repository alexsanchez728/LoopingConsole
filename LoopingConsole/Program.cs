using System;
using System.Collections.Generic;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = new List<Child> // List of Child instances
            {
                new Child { Name = "Suzy", Troubled = false },
                new Child { Name = "Sam", Troubled = false }
                // ^ using object initializers inside of initializing a List
            };

            foreach (var child in children)
                    // ^ each instance in children, here: child, in its entirety, is what's being looped over.
            {
            Console.WriteLine($"This child, {child.Name}, is {(child.Troubled ? "a very troubled child" : "is not troubled and is healthy")}"); // <~ ternary needed to be in parenthesis
            Console.WriteLine(child.ForgeASickNote());
            }

            Console.ReadLine();
        }
    }
}
