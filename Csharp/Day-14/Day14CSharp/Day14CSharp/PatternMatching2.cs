using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14CSharp
{
    public class Shape
    {
        public const float PI = 3.14f;
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public class Rectangle:Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Rectangle(double l,double b)
        {
            Length =l;
            Breadth = b;
        }
    }
    public class Triangle:Shape
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double b,double h)
        {
            Base = b;
            Height = h;
        }
    }
    class PatternMatching2
    {
        //Prior to C3 7.0 .Testing Each type in a series and then casting it accordingly.
        //public static void DisplayArea(Shape shape)
        //{
        //    if (shape is Circle)
        //    {

        //        Circle c = (Circle)shape;
        //        Console.WriteLine("Area ofCircle:" + c.Radius * c.Radius *Shape.PI);
        //    }
        //    else if(shape is Rectangle)
        //    {
        //        Rectangle r = (Rectangle)shape;
        //        Console.WriteLine("Area Of REctange: "+r.Length*r.Breadth);
        //    }
        //    else if(shape is Triangle)
        //    {
        //        Triangle t = (Triangle)shape;
        //        Console.WriteLine("Area of Triangle:" +0.5*t.Base*t.Height);
        //    }
        //    else
        //    {
        //        throw new ArgumentException(message: "Invalid Shape",paramName:nameof(shape));
        //    }
        //}

        //with c# 7.0
        //public static void DisplayArea(Shape shape)
        //{
        //    if (shape is Circle c)
        //    { 
        //       Console.WriteLine("Area ofCircle:" + c.Radius * c.Radius * Shape.PI);
        //    }
        //    else if (shape is Rectangle r)
        //    {

        //        Console.WriteLine("Area Of REctange: " + r.Length * r.Breadth);
        //    }
        //    else if (shape is Triangle t)
        //    {

        //        Console.WriteLine("Area of Triangle:" + 0.5 * t.Base * t.Height);
        //    }
        //    else
        //    {
        //        throw new ArgumentException(message: "Invalid Shape",paramName:nameof(shape));
        //    }
        //}
        //switch case using when
        public static void DisplayArea(Shape shape)
        {
            switch(shape)
            {
                case Rectangle r when r.Length==r.Breadth:
                    Console.WriteLine("Area Of Square: " + r.Length * r.Breadth);
                    break;

                case Circle c:
                    Console.WriteLine("Area ofCircle:" + c.Radius * c.Radius * Shape.PI);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area Of REctange: " + r.Length * r.Breadth);
                    break;
                case Triangle t:
                    Console.WriteLine("Area of Triangle:" + 0.5 * t.Base * t.Height);
                    break;
                case null:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
                    
                default:
                    throw new ArgumentNullException(nameof(shape));
                    


            }
        }
        static void Main()
        {
            Rectangle square = new Rectangle(5, 5);
            DisplayArea(square);
            Circle circle =new Circle(4);
            DisplayArea(circle);
            Rectangle rect = new Rectangle(6, 7);
            DisplayArea(rect);
            Triangle tri = new Triangle(6, 5);
            DisplayArea(tri);
            Console.Read();
        }
    }
}
