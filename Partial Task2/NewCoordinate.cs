namespace Partial_Task2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class NewCoordinate
    {
        public static Point Left_Coordinate()
        {
            Console.WriteLine("Введiть координати лiвої верхньої точки:");
            Console.Write("x = ");
            int x1 = Convert.ToInt32(Validation.Valid(Console.ReadLine()));
            Console.Write("y = ");
            int y1 = Convert.ToInt32(Validation.Valid(Console.ReadLine()));

            Point a = new Point(x1, y1);

            return a;
        }

        public static Point Right_Coordinate()
        {
            Console.WriteLine("Введiть координати правої нижньої точки:");
            Console.Write("x = ");
            int x2 = Convert.ToInt32(Validation.Valid(Console.ReadLine()));
            Console.Write("y = ");
            int y2 = Convert.ToInt32(Validation.Valid(Console.ReadLine()));

            Point b = new Point(x2, y2);

            return b;
        }
    }
}
