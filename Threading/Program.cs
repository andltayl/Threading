using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            int throws, numThreads;
            int inside = 0;
            List<Thread> threads = new List<Thread>();
            List<FindPiThread> darts = new List<FindPiThread>();           

            Console.WriteLine("How many throws per thread? ");
            throws = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many threads? ");
            numThreads = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numThreads; i++)
            {
                FindPiThread temp = new FindPiThread(throws);

                darts.Add(temp);
                threads.Add(new Thread(new ThreadStart(darts[i].throwDarts)));
                threads[i].Start();     // Start each thread
                Thread.Sleep(16);       // Sleep main so the random numbers will have a different seed
            }

            for(int i = 0; i < numThreads; i++)
            {
                threads[i].Join();      // Wait for all threads to finish
            }

            for(int i = 0; i < numThreads; i++)
            {
                inside += darts[i].GetDarts();
            }

            Console.WriteLine("Best estimate for Pi: {0}", (4.0 * (inside) / (throws * numThreads)));
            Console.Read();
        }
    }
}
