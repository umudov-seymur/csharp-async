using System;
using System.Threading.Tasks;

namespace TaskForPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAll();
            Console.Read();
        }

        public static async Task PrintAll()
        {
            Task task1 = PrintA();
            Task task2 = PrintB();

            await Task.WhenAll(task1, task2);
        }

        public static async Task PrintA()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("A");
                    Task.Delay(1000).Wait();
                }
            });
        }

        public static async Task PrintB()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Task.Delay(2000).Wait();
                    Console.WriteLine("B");
                }
            });
        }
    }
}
