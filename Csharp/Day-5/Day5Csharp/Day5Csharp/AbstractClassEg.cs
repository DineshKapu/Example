using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Csharp
{
    abstract class Shapes
    {
        //decl an abstract method
        public string prop1 { get; set; }
        public abstract float parameter { get; set; }
        public abstract int Area();
        public void DrawShape() //non-abstract method
        {
            Console.WriteLine("Drawing a Shape...");
        }
        public virtual void ShapeType()
        {
            Console.WriteLine("This is a base type  Shape");

        }
    }
    class Square:Shapes
    {
        public override float parameter { get; set; }

        int side;
        public Square(int n)
        {
            side = n;
        }
        //abstract with overide
        public override int Area()
        {
            return side * side;
        }
        //virtual with override
        public override void ShapeType()
        {
            base.ShapeType();
            Console.WriteLine("This is a subtype Square Shape");
        }
        public new void DrawShape() //non-abstract method
        {
            Console.WriteLine("Drawing a  Square Shape...");
        }
    }
    class AbstractClassEg
    {
        static void Main()
        {
            Shapes shape = new Square(6);
            Console.WriteLine("Area of Square: " + shape.Area());
            shape.DrawShape();
            shape.ShapeType();

            Square s = new Square(10);
            Console.WriteLine("Area of Square using Square Object: " + s.Area());
            s.DrawShape();

            Console.Read();
       
        }

    }
}
