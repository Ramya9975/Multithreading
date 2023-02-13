using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            threadEx thread =  new threadEx();
           //thread.hello();
           //thread.training();
           Thread thread2 = new Thread(thread.hello);
           Thread thread3 = new Thread(thread.training);

            thread2.Priority = ThreadPriority.Lowest;
            thread3.Priority = ThreadPriority.Highest;
            thread2.Start();
            thread3.Start();
            Console.ReadLine();



        }

    }
}
