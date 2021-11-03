using System;
using System.Collections.Generic;
using System.Text;

namespace inClassWeek12
{
    abstract class Shape
    {
        public string Color { get; set; }
        protected string Type { get; set; }

        public Shape(string color)
        {
            this.Color = color;
        }
        public void PrintShapeType()
        {
            Console.WriteLine("Shape : {0}", Type);
        }
        public abstract double GetArea();
        public abstract void Draw();
        public abstract void PrintShapeInfo();
    }
}
