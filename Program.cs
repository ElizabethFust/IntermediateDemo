using System;

namespace IntermediateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new RectangleExample2(5, 3);

            rectangle.Print();

            Console.ReadLine();

           
            double result = rectangle.Perimeter(); //rectangle.Perimeter(5, 3);
            Console.WriteLine("Perimeter: " + result);
            Console.ReadLine();

            
        }
    }
}
