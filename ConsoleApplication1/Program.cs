
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBPSConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var ed = new EvenOdd();
            ed.ED();

          
        }

      
      public  class EvenOdd
        {
            public void ED()
            {
                Console.Title = "Even-Odd Application, "+ "Programmer: Ahmed Chowdhury "+ DateTime.Now;
                Console.WindowHeight = 10;
                Console.WindowWidth = 100;

                start:
                try {
                    Console.WriteLine("Please Enter a valid number: or Ctrl+C then press any key to Exit \n");
                    int input = int.Parse(Console.ReadLine());

                    if (input % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n{input} is an even number. \n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{input} is an odd number. \n");
                    }
                }
                catch(FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"\nInvalid entry: {ex.Message} \n");
                }
                Console.ForegroundColor = ConsoleColor.White;
                goto start;

            }


        }
    }
}



