namespace Partial_Task2_Task4_1
{
    using System;
    using Partial_Task2;

    class Task4_1 : IRun
    {
        public void Run()
        {
            Point a = NewCoordinate.Left_Coordinate();
            Point b = NewCoordinate.Right_Coordinate();

            double p = Rectangle.Perimeter(a, b);
            double s = Rectangle.Square(a, b);

            Console.WriteLine("Периметр прямокутника дорiвнює: " + p.ToString());
            Console.WriteLine("Площа прямокутника дорiвнює: " + s.ToString());
        }

    }
   
    static class Rectangle
    {
        static private Point A;
        static private Point B;
        static private Point C;
        static private Point D;

        public static double getLenght(Point x, Point y)
        {
            double lenght;
            double x_result;
            double y_result;
            x_result = (y.x - x.x) * (y.x - x.x);
            y_result = (y.y - x.y) * (y.y - x.y);
            lenght = Sqrt.getSqrt(x_result + y_result);
            return lenght;
        }
        public static double Perimeter(Point A, Point D)
        {
            Rectangle.A = A;
            Rectangle.D = D;
            B = new Point(D.x, A.y);
            C = new Point(A.x, D.y);
            return (getLenght(A, B) + getLenght(A, C)) * 2;
        }
        public static double Square(Point A, Point D)
        {
            Rectangle.A = A;
            Rectangle.D = D;
            B = new Point(D.x, A.y);
            C = new Point(A.x, D.y);
            return getLenght(A, B) * getLenght(A, C);
        }
    }
}