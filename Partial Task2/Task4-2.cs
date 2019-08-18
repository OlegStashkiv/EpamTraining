namespace Partial_Task2_Task4_2
{
    using System;
    using Partial_Task2;

    class Task4_2 : IRun
    {
        public void Run()
        {
            Console.WriteLine("Введiть радiус круга");
            Console.Write("r = ");
            double r = Validation.Valid(Console.ReadLine());
            Console.WriteLine("Довжина кола дорiвнює: " + Circle.getCircleLenght(r));
            Console.WriteLine("Площа кола дорiвнює: " + Circle.getCircleSquare(r));
        }
    }

    static class Circle
    {
        const double pi = 3.14159;

        public static double getCircleLenght(double r)
        {
            return 2 * pi * r;
        }

        public static double getCircleSquare(double r)
        {
            return pi * (r * r);
        }
    }
}
