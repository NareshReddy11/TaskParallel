using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParlle
{
    class program3
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(() => Dowork(1, 3000));
            Task t2 = Task.Factory.StartNew(() => Dowork(2, 2000));
            Task t3 = Task.Factory.StartNew(() => Dowork(3, 1000));
            Console.ReadLine();
        }
        static void Dowork(int id,int sleep)
        {
            Console.WriteLine("task {0} is begin", id);
            Thread.Sleep(sleep);
            Console.WriteLine("task {0} is completed", id);
        }
    }
}
/*
                        task 3 is begin
                        task 2 is begin
                        task 1 is begin
                        task 3 is completed
                        task 2 is completed
                        task 1 is completed

*/