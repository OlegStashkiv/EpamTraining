using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Task2
{
    static class Validation
    {
        public static double Valid(string s)
        {
            double result;
            do
            {
                try
                {
                    result = Convert.ToDouble(s);
                    break;
                }
                catch
                {
                    Console.WriteLine("Неправильний формат вводу. Потрiбно ввести число");
                    s = Console.ReadLine();
                }
            }
            while (true);
            return result;
        }

    }
}
