using System;
using System.Collections.Generic;

namespace очередь
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> clients = CreateQueue();
            int cash = 0;
            int clientNumber = 1;

            while (clients.Count > 0)
            {
                int money = clients.Dequeue();
                cash += money;

                Console.WriteLine($"{clientNumber++} клиент сделал покупки на сумму {money} рублей.");
                Console.SetCursorPosition(50,0);
                Console.WriteLine($"касса: {cash} руб.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static Queue<int> CreateQueue()
        {
            Queue<int> clients = new Queue<int>();
            Random random = new Random();
            int maxValue = 2000;

            Console.Write("введите количество клиентов в очереди: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                for (int i = 0; i < number; i++)
                {
                    clients.Enqueue(random.Next(maxValue));
                }
            }

            return clients;
        }
    }
}
