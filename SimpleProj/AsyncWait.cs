using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleProj
{
    class AsyncWait
    {
        public void Run()
        {
            func1();
            func2();
            Console.WriteLine("Please Enter Key..");
            Console.ReadKey();
        }

        private async Task func1()
        {
            //await Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(" --1-- ");
            //        Thread.Sleep(20);
            //    }
            //});

            await Task.Run(() => printLines());
        }

        private void printLines()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" --1-- ");
                Thread.Sleep(20);
            }
        }

        private async Task func2()
        { 
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("**2**");
                    Thread.Sleep(20);
            }        
        }

        private async Task func3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("  ^^3^^");
                Thread.Sleep(20);
            }
        }

    }

    
}
