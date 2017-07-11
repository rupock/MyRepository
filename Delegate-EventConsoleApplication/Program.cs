using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delegate_EventConsoleApplication
{
    /// <summary>
    /// Aspects of Delegate: Type and Instance
    /// Delgates are simillar to callback
    /// </summary>
    class Program
    {
        //delegate protocol: between caller and target method
        // type of delgate name, type of parameter at defining syntex begin with Delegate Key Words
        //example:

      delegate int Transformar(int x);
      
        static void Main(string[] args)
        {
           

            Multicast m = new Multicast();

            m.Multicasts();
         
            UseSelegate d = new UseSelegate();
          
           
            /*    How to subscribe to an event
             * 1. Find the event of interest
             * 2. Look up the event signuture
             * 3. Write a method handle the evnt
             * 4. Subscribe to the event with +=
             Tip: Use visual studio's +=<Tab><Tab>            
             */
            //how to monitor a folder

              
                var watcher = new FileSystemWatcher(@"c:\dev\test");
                watcher.EnableRaisingEvents = true;

                watcher.Created += OnCreated;
                watcher.Deleted += OnDeleted;
                Console.ReadKey(true);
       
      
          
            //invoking delegate; delegate is calling the target method;
              InvokingDelgateTrans(7);

            int[] values = { 7, 3, 1};
            Transform(values, Square);
            foreach (var v in values)
            {
                Console.WriteLine(v+ " is the square value of");
            }
        }

        private static void C_OnChange()
        {
            Console.WriteLine("Car is speeding: going over speed limit 60 MPH");
        }

        protected static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.ChangeType} {e.Name}  at { e.FullPath}");
        }

        protected static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.ChangeType} {e.Name}  at { e.FullPath}");
        }

        //target method
        static int Square(int x)
        {
            return x * x; 
        }

        static void InvokingDelgateTrans(int x)
        {
            // Creating instance of a delegate
            // Transformar t = Square;//calling the target method
            var t = new Transformar(Square);
            // Invoking delegate
            // int result = t(x);
            int result = t.Invoke (x);
            Console.WriteLine(result);
        }

        //transform target method
        static void Transform(int[] values,Transformar t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t.Invoke((values[i]));
            }
        }

    }
}
