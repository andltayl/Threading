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
            List<Thread> threads;
            List<FindPiThread> darts;           

            Console.WriteLine("How many throws per thread? ");
            throws = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many threads? ");
            numThreads = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numThreads; i++)
            {
                FindPiThread temp = new FindPiThread(throws);

                darts.Add(temp);
                     
            }
        }
    }
}
