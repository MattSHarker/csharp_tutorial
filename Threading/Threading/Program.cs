using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100000000];

            // Prepare the list of threads and the list of tasks
            int threadCount = 10;
            GenerateNumbersTask[] tasks = new GenerateNumbersTask[threadCount];
            Thread[] threads = new Thread[threadCount];

            // create and start all threads
            for (int i = 0; i < threadCount; ++i)
            {
                tasks[i] = new GenerateNumbersTask()
                {
                    Numbers    = numbers,
                    Count      = 1000,
                    StartIndex = i * 1000
                };

                // create the thread
                threads[i] = new Thread(tasks[i].GenerateNumbers);

                // Start running the threads
                threads[i].Start();
            }

            // wait for all threads to finish, and join them
            for (int i = 0; i < threadCount; ++i)
                threads[i].Join();

            // exit prompt
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

// to lock a thread, use the "lock" method
// 
// private object threadLock = new object();
// lock(threadLock)
// {
//     // code that only one thread should run at a time goes here
// }
