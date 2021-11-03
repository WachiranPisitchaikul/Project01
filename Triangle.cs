using System;
using System.Collections.Generic;
using System.Text;

namespace inClassWeek12
{
    class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(string color, double baseLength, double height) : base(color)
        {
            this.Type = "Triangle";
            this.BaseLength = baseLength;
            this.Height = height;
        }
        public override double GetArea()
        {
            return 0.5 * BaseLength * Height;
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Draw Triangle");
        }
        public override void PrintShapeInfo()
        {
            base.PrintShapeType();
            Console.WriteLine("Color : {0} ", Color + $"Base Length : {BaseLength}, Height : {Height}, Area = {GetArea()}");
        }
    }
}
