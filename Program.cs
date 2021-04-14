using System;
using System.Threading;

namespace Watki
{
    class Program
    {
        public static void Sortowanie(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write(Thread.CurrentThread.Name + " || ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int [] Tab = { 332, 12, 37, 654, 58, 61, 17, 48, 491, 10 };

            // -------------------------------------------------------
            //Thread thrd = new Thread(() => Sortowanie(Tab));

            //thrd.Start();
            //thrd.Join();

            // -------------------------------------------------------

            int N = 10;
            Thread[] thrdd = new Thread[N];

            for (int i = 0; i < N; i++)
            {
                thrdd[i] = new Thread(() => Sortowanie(Tab));
                thrdd[i].Name = String.Format("Thread: {0}", i);

                thrdd[i].Start();
                thrdd[i].Join();
            }

        }
    }
}
