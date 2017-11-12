using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine($"What is your name?");
            var input = Console.ReadLine();
            Console.WriteLine($"Hello " + input + "!");
            Console.WriteLine("\nType any key to exit the program");
            var exit = Console.ReadKey();
         
            Console.WriteLine("\nGodbye now");

           Console.Beep()

        }
    }
}
