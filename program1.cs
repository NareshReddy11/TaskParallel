using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParlle
{
    class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method execution: Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            Task myTask = new Task(new Action(myMethod));
            myTask.Start();
            Console.WriteLine("Main method execution: Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Main method completed");
            Console.ReadLine();
            
        }

        static void myMethod()
        {
            Console.WriteLine("My method executed: Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
