using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KnowledgeBase.SystemInternal
{
    public class AsyncAwait : ICode
    {
        public string GetDecription()
        {
            return "System internals - async and await";
        }

        public async void Run()
        {
            Console.WriteLine("assigning asnyc functions");

            var printNumber = PrintNumbers();
            Console.WriteLine("assigned printNumber");

            var printAnotherNumbers = PrintAnotherNumbers();
            Console.WriteLine("assigned PrintAnotherNumbers");

            Console.WriteLine("starts awaiting");

            Console.WriteLine("awaiting for printNumber");
            var c = await printNumber;

            Console.WriteLine("awaiting for PrintAnotherNumbers");
            var d = await printAnotherNumbers;

            Console.WriteLine("Await complete {0}, {1}", c, d);
            Console.ReadLine();
        }

        public async Task<bool> PrintNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("ap : {0} id : {1}", i, Thread.CurrentThread.ManagedThreadId);
            }
            await Task.Yield();
            return true;
        }

        public async Task<bool> PrintAnotherNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                //Thread.Sleep(100);
                Console.WriteLine("ap : {0} id : {1}", i, Thread.CurrentThread.ManagedThreadId);
            }
            await Task.Yield();
            return true;
        }
    }
}
