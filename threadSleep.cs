using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParlle
{
    class threadSleep
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
    public class ThreadExample
    {
        public static void Main()
        {
            threadSleep mt = new threadSleep();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t2.Start();
        }
    }
}
