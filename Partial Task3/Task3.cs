namespace Partial_Task3_Task3
{
    using System;
    using Partial_Task3;

    public class Task3 : IRun
    {
        public void Run()
        {
            Figure figure = new Figure(5, 6);
            Square square = new Square(7, 8);
            Rectangle rectangle = new Rectangle(4, 3);
            figure.Draw();
            square.Draw();
            rectangle.Draw();
        }
    }

    public class Figure
    {
        public int X { get; }
        public int Y { get; }

        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Figure");
        }
    }

    public class Square : Figure
    {
        public Square(int X, int Y) : base(X, Y) { }
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(int X, int Y) : base(X, Y) { }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}

