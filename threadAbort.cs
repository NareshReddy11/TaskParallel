using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParlle
{
    class threadAbort
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
    public class ThreadExample2
    {
        public static void Main()
        {
            Console.WriteLine("Start of Main");
            threadAbort mt = new threadAbort();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t2.Start();
            try
            {
                t1.Abort();
                t2.Abort();
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine(tae.ToString());
            }
            Console.WriteLine("End of Main");
            Console.ReadLine();
        }
    }
}
