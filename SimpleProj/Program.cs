using System;

namespace SimpleProj
{
    class Program
    { 
        static void Main(string[] args)
        {
            CheckAsyncAwait();
            Console.ReadKey();
        }

        public static void CheckAsyncAwait()
        {
            AsyncWait asynWait = new AsyncWait();
            asynWait.Run();

            Console.WriteLine("........................");

            AsyncWait1 asyncwait1 = new AsyncWait1();
            asyncwait1.Run();

            Console.WriteLine("........................");

            AsyncWait2 asyncwait2 = new AsyncWait2();
            asyncwait2.Run();
        }
    }
}
