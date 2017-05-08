using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo a = new Demo();
            int r = 10;
            int r1 = a.M(out r);
            Console.WriteLine(r);
            Console.WriteLine(r1);
            Console.WriteLine("----------------X------------------");
            Demo1 c = new Demo1();
            Console.WriteLine(c.x);
            c.M(c);
            Console.WriteLine(c.x);
          
            Console.WriteLine("null");

            
          
        }
    }
}
