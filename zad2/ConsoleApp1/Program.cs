using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1



{
    abstract class Shape: Ishape
    {
        public string Name { get; }
        public Shape(string name){
            Name = name;
        }
        public abstract double getArea();
    }

    class Circle : Shape
    {
        public double radius { get; set; }
        public Circle(double radius, string name) : base(name)
        {
            this.radius = radius;
        }
        public override double getArea() { return (radius * radius * Math.PI); }
    }

    class Triangle : Shape
    {
        public double side { get; set; }
        public Triangle(double side, string name) : base(name)
        {
            this.side = side;
        }
        public override double getArea() { return (side * side * Math.Sqrt(3)) / 4; }
    }

    

    class Rectangle : Shape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle(double side1,double side2, string name) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double getArea() { return (side1 * side2); }
    }

    interface Ishape
    {
        double getArea();
        string Name { get; }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10, "круг");
            Triangle triangle = new Triangle(5, "треугольник");
            Rectangle rectangle = new Rectangle(3, 4, "прямоугольник");

            List<Ishape> shapes = new List<Ishape>();
            shapes.Add(circle);
            shapes.Add(triangle);
            shapes.Add(rectangle);
            foreach (Ishape shape in shapes)
            {
                Console.WriteLine($"Площадь {shape.getArea()}");
                Console.WriteLine($"Имя {shape.Name}");

            }
        }
    }
}
