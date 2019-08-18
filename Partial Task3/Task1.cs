namespace Partial_Task3_Task1
{
    using System;
    using Partial_Task3;

    public class Task1 : IRun
    {
        public void Run()
        {
            Square square = new Square();
            Rectangle rectangle = new Rectangle();

            square.Draw();
            rectangle.Draw();
        }
    }
    public abstract class Figure
    {
        public abstract void Draw();
    }

    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
