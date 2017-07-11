using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_EventConsoleApplication
{
    class Multicast
    {
        delegate void Del();

        public void MethodeOne() => Console.WriteLine("MethodOne");
        public void MethodeTwo() => Console.WriteLine("MethodeTwo");

        public void Multicasts()
        {
            Del d = MethodeOne;
            d += MethodeTwo;
            d();
        }
    }

}
