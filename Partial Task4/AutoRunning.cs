using System;
using Partial_Task4_Task1;
using Partial_Task4_Task2;

namespace Partial_Task4
{
    class AutoRunning
    {
        static void Runing(params IRun[] array)
        {
            for (int i = 0; i < array.Length;)
            {
                Console.WriteLine("{0}{1}", "Task ", i + 1);
                array[i].Run();
                Console.WriteLine("Натиснiть \"enter\" для переходу до наступного завдання");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    i++;
                }
            }
        }

        static void Main(string[] args)
        {
            Runing(new Task1(), new Task2(), new Task3());
        }
    }
}
