using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleProj
{
    class AsyncWait1
    {
            public async void Run()
            {
                Task<int> task = func1();
                func2();
                int count = await task;
                Console.WriteLine("the count is " + count);
                Console.WriteLine("Please Enter Key..");
                Console.ReadKey();
        }

            private async Task<int> func1()
            {
                int count = 0;
                await Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(" --1-- ");
                        Thread.Sleep(20);
                        count++;
                    }
                });
                return count;
            }

            private async Task func2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("**2**");
                    Thread.Sleep(20);
                }
            }

    }
}
