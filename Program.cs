using System;

namespace inClassWeek12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            var rectangle = new Rectangle(20, 20, "blue");
            var triangle = new Triangle("green", 20, 15);

            rectangle.PrintShapeInfo();
            rectangle.Draw();

            triangle.PrintShapeInfo();
            triangle.Draw();
            rectangle.Move();
            rectangle.StartEngine();

        }
    }
}
