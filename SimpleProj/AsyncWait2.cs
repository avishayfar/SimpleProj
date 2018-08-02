using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SimpleProj
{
    class AsyncWait2
    {

        public async void Run()
        {
            Console.WriteLine("Async Application Started!");
          
            Task<string> greetMsg = GetGreetingsAsync();
                  
            Console.WriteLine("Async Method in started....");
            Console.WriteLine("Current Time: " + DateTime.Now);
            Console.WriteLine("Awaiting result from Async method...");

            //All work completed, wait for async method to complete
            string msg = await greetMsg;
            
            Console.WriteLine("Async method completed!");
            Console.WriteLine("Current Time: " + DateTime.Now);
            Console.WriteLine("Async method output: " + greetMsg.Result);

            Console.WriteLine("Async Application Ended!");
            Console.ReadKey();
        }

        public async static Task<string> GetGreetingsAsync()
        {
            await Task.Delay(1000);
            return "Welcome to Async C# Demo!";
        }

    }
}
