using System;

namespace IntermediateDemo
{
    public class RectangleExample2 : IShape
    {
        public RectangleExample2(int height, int widgth)
        {
            Height = height;
            Widgth = widgth;
        }

        public double Perimeter()  /*(double height, double widgth)*/
        {
            //this.Height = height;
            //this.Widgth = widgth;
            return 2 * Height + 2 * Widgth;
        }
        public double Area()
        {
            return Height * Widgth;
        }

        public void Print()
        {
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Widgth: " + Widgth);
        }

        public double Height { get; protected set; }
        public double Widgth { get; protected set; }
    }
}
