namespace Partial_Task3_Task4
{
    using System;
    using Partial_Task3;

    public class Task4 : IRun
    {
        public static void DrawAll(params IDrawble[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
               array[i].Draw();
            }
        }
        public void Run()
        {
            Figure figure = new Figure(5, 6);
            Square square = new Square(7, 8);
            Rectangle rectangle = new Rectangle(4, 3);

            DrawAll(figure, square, rectangle);
        } 
    }


    public class Figure : IDrawble
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

    public class Square : Figure, IDrawble
    {
        public Square(int X, int Y) : base(X, Y) { }
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class Rectangle : Figure, IDrawble
    {
        public Rectangle(int X, int Y) : base(X, Y) { }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}



