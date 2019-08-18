namespace Partial_Task3_Task2
{
    using System;
    using Partial_Task3;

    public class Task2 : IRun
    {
        public void Run()
        {
            Square square = new Square(5, 6);
            Rectangle rectangle = new Rectangle(8, 12);

            square.Draw();
            rectangle.Draw();
        } 
    }
    public abstract class Figure
    {
        public  int X { get; }
        public int Y { get; }

        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void Draw();
    }

    public class Square : Figure
    {
       public Square (int X, int Y) : base(X, Y) {}
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle (int X, int Y) : base(X, Y) {}

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
