using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParlle
{
    class program2
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() => Dowork(1, 3000));
            t1.Start();
            Task t2 = new Task(() => Dowork(2, 2000));
            t2.Start();
            Task t3 = new Task(() => Dowork(3, 1000));
            t3.Start();
            Console.ReadLine();
        }
        public static void Dowork(int id,int sleep)
        {
            Console.WriteLine("task {0} is begin----" ,id);
            Thread.Sleep(sleep);
            Console.WriteLine("task {0} is completed---", id);
        }
    }
}
