using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParlle
{
    class program6
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(() => DoImpWork(1, 2000));
            Task t2 = Task.Factory.StartNew(() => DoImpWork(2, 5000));
            Task t3 = Task.Factory.StartNew(() => DoImpWork(3, 1000));
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i + ",");
            }

            // t3.Wait();
            t2.Wait();
            // //t1.Wait();
            
        }
        static void DoImpWork(int id,int sleep)
        {
            
            Console.WriteLine("task {0} begin,doing some illegal activity",id);
            Thread.Sleep(sleep);
            Console.WriteLine("task {0} completed illigal activity",id);
        }
    }
}
