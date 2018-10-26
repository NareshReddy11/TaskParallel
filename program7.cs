using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParlle
{
    class program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method execution: Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            Parallel.For(0, 1000, X => BadTime());
            Console.WriteLine("Main method completed");
            Console.ReadLine();
        }
        static void BadTime()
        {
            Console.WriteLine("My badtime executed: Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
