using System;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var suzy = new Child
            {
                Name = "Suzy",
                Troubled = false
            };
            // ^ Object initialization to keep things shorter. Only works with properties.

            Console.WriteLine($"This child, {suzy.Name}, is {(suzy.Troubled ? "a very troubled child" : "is not troubled and is healthy")}"); // <~ ternary needed to be in parenthesis
            Console.WriteLine(suzy.ForgeASickNote(true));
            Console.ReadLine();

            var sam = new Child
            {
                Name = "Sam",
                Troubled = false
            };
            // ^ Object initialization to keep things shorter. Only works with properties.

            Console.WriteLine($"This child, {sam.Name}, is {(sam.Troubled ? "a very troubled child" : "is not troubled and is healthy")}"); // <~ ternary needed to be in parenthesis
            Console.WriteLine(sam.ForgeASickNote(false));
            Console.ReadLine();
        }
    }
}
