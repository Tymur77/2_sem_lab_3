using System;
using System.Threading;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static readonly int MAX_COUNT = 14;
        static int count = 0;

        static void Main(string[] args)
        {
            RecursiveMethod();
        }

        private static void RecursiveMethod()
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Started (thread no. = {id})");
            if (++count == MAX_COUNT)
            {
                Console.WriteLine($"Finished (thread no. = {id}) EXCEEDED THREAD COUNT");
                return;
            }
            Thread t1 = new Thread(RecursiveMethod);
            t1.Start();
            t1.Join();
            Console.WriteLine($"Finished (thread no. = {id})");
        }
    }
}
