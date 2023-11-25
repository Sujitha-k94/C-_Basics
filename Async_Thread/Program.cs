using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref vs out
            int a, add = 1, sub = 2;
            int b = 10;
            Program.update(out a, ref b, ref add, ref sub);


            //Thread thread = new Thread(somemethod);
            //thread.Start();

            Console.WriteLine("main method1" + Thread.CurrentThread.ManagedThreadId);
            somemethod();
            Console.WriteLine("main method3");
            Console.ReadLine();

        }
        public static void update(out int c, ref int d, ref int add, ref int sub)
        {
            c = 100;
            add = c + d;
            sub = c - d;
        }

        //static void somemethod()
        //{
        //    Task.Delay(10000).Wait();
        //    Console.WriteLine("some method");
        //}

        //static async void somemethod()  // will process in a single thread
        //{
        //    await Task.Delay(10000);
        //    Console.WriteLine("some method");
        //}

        //static void somemethod()  // will create new thread  & resource intensive
        //{
        //    Task.Delay(10000).Wait();
        //    Console.WriteLine("some method");
        //}

        static async void somemethod()  
        {
            Console.WriteLine("some method2");
            await Task.Delay(10000);
            Console.WriteLine("some method4" + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
