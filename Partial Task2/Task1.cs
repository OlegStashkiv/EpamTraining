namespace Partial_Task2_Task1
{
    using System;
    using Partial_Task2;

    class Task1 : IRun
     {
        public void Run()
        {
            Rectangle rectangle = new Rectangle
                (NewCoordinate.Left_Coordinate(), NewCoordinate.Right_Coordinate());

        double p = rectangle.Perimeter();
        double s = rectangle.Square();

        Console.WriteLine("Периметр прямокутника дорiвнює: " + p.ToString());
        Console.WriteLine("Площа прямокутника дорiвнює: " + s.ToString());
        }
     }

     class Rectangle
     {
         private Point A;
         private Point B;
         private Point C;
         private Point D;

         public Rectangle(Point A, Point D)
         {
             this.A = A;
             this.D = D;
             B = new Point(D.x, A.y);
             C = new Point(A.x, D.y);
         }

         public double getLenght(Point x, Point y)
         {
             double lenght;
             double x_result;
             double y_result;
             x_result = (y.x - x.x) * (y.x - x.x);
             y_result = (y.y - x.y) * (y.y - x.y);
             lenght = Sqrt.getSqrt(x_result + y_result);
             return lenght;
         }
         public double Perimeter()
         {
             return (getLenght(A, B) + getLenght(A, C)) * 2;
         }
         public double Square()
         {
             return getLenght(A, B) * getLenght(A, C);
         }

     } 
}