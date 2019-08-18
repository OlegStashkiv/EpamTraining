namespace Partial_Task2
{
    using System;
    using Partial_Task2_Task1;
    using Partial_Task2_Task2;
    using Partial_Task2_Task3;
    using Partial_Task2_Task4_1;
    using Partial_Task2_Task4_2;
    using Partial_Task2_Task5;

    public class AutoRanning
    {
        public static void Runing(params IRun[] array)
        {
            for (int i = 0; i < array.Length;)
            {
                Console.WriteLine("Task " + (i + 1));
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
            Runing(new Task1(), new Task2(), new Task3(), new Task4_1(), new Task4_2(), new Task5());
        }
    }
}
