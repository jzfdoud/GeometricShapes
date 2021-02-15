using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // this tutorial is meant to demonstrate using constructors 

            // Square Class
            var sq1 = new Square(6);
            Console.WriteLine($" Sq1 perimeter: {sq1.Perimeter()}, area: {sq1.Area()}");


            //Rectangle Class
            var rect1 = new Rectangle(6, 4);
            Console.WriteLine($"Rect1 perimeter: {rect1.Perimeter()}, area: {rect1.Area()}");

            var rect2 = new Rectangle(5, 8);
            Console.WriteLine($"Rect2 perimeter: {rect2.Perimeter()}, area: {rect2.Area()}");


            //Quad Class
            var quad1 = new Quad(3, 4, 5, 6);
            var perimeter = quad1.Perimeter();
            Console.WriteLine($"Quad1 perimeter: {perimeter}");

            var quad2 = new Quad();
            Console.WriteLine($"Quad2 perimeter: {quad2.Perimeter()}");
        }
    }
}
