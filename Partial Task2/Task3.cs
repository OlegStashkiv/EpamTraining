namespace Partial_Task2_Task3
{
    using System;
    using Partial_Task2;

    class Task3 : IRun
    {
        public void Run ()
        {
            Circle circle = new Circle();
            Console.WriteLine("Введiть радіус круга");
            Console.Write("r = ");
            double r = Validation.Valid(Console.ReadLine());
            Console.WriteLine("Довжина кола дорiвнює: " + circle.getCircleLenght(r));
            Console.WriteLine("Площа кола дорiвнює: " + circle.getCircleSquare(r));
        }  
    }

    class Circle
    {
        const double pi = 3.14159;

        public double getCircleLenght(double r)
        {
            return 2 * pi * r;
        }

        public double getCircleSquare(double r)
        {
            return pi * (r * r);
        }
    }
}
