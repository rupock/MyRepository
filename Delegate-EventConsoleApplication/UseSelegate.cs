using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_EventConsoleApplication
{

    class UseSelegate
    {
        public delegate int Calcuale(int x, int y);
        public int Add(int x, int y) => x + y;
        public int Multiply(int x, int y) => x * y;

        public UseSelegate()
        {
            Calcuale cal = new Calcuale(Add);
            Console.WriteLine(cal.Invoke(3,4));
            cal = Multiply;
            Console.WriteLine(cal.Invoke(3,4));
        }
    }
}

