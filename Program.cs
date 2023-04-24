using System;

namespace Static_Members_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints integer methids to the console.
            Console.WriteLine("Integer Methods");
            //calls the Calculate classes methods on two number then prints answer to console as an int.
            Console.WriteLine("15 + 88 is" + Calculate.Add(15, 88));
            Console.WriteLine(Calculate.Sub(78, 88));
            Console.WriteLine(Calculate.Mult(8, 9));
            Console.WriteLine(Calculate.Div(77, 8));

            //prints float methods to the console.
            Console.WriteLine("\nFloat Methods");
            //calls the Calculate classes methods on two number then prints answer to console as an Floats.
            Console.WriteLine(Calculate.Add(15.55f, 88.65f));
            Console.WriteLine(Calculate.Sub(78.45f, 88.89f));
            Console.WriteLine(Calculate.Mult(8.99f, 9.65f));
            Console.WriteLine(Calculate.Div(77.265f, 8.0f));

        }
    }
}
