using System;
using System.Collections.Generic;
using System.Text;

namespace inClassWeek12
{
    class Rectangle : Shape, IVehicle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, string color) : base(color)
        {
            this.Type = "Rectangle";
            this.Width = width;
            this.Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Draw Rectangle []");
        }
        public override void PrintShapeInfo()
        {
            base.PrintShapeType();
            Console.WriteLine("Color : {0}", Color + $"Width : {Width}, Height : {Height}, Area = {GetArea()}");
        }
        public void Move()
        {
            Console.WriteLine($"{Type} is Moving ...");
        }
        public void StartEngine()
        {
            Console.WriteLine($"{Type} is Start Engine ...");
        }
    }
}
