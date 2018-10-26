using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParlle
{
    class program5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3,1,8,9,3,5,0,23,65,89,56,45, };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Thread.Sleep(1000);
            }
            //Parallel.For(0,20,i =>
            //  {
            //      Console.WriteLine(i);
            //      Thread.Sleep(1000);
            //  });
            Parallel.ForEach(arr, (i) =>
              {
                  Console.WriteLine(i);
                  Thread.Sleep(1000);
              });
            Console.ReadLine();
        }
    }
}
