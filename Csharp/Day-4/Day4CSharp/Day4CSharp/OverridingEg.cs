using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharp
{
    class Shape
    {
        protected float R, L, B;
        public virtual float Area()
        {
            return 3.14f * R * R;
        }
        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }
    class Rectangle : Shape
    {
      public void GetLB()
        {
           
            Console.WriteLine("Enter Length : ");
            L = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            B = Convert.ToSingle(Console.ReadLine());
           
        }
        public override  float Area()
        {
            GetLB();
            return L * B;
        }
        public override float Circumference()
        {
            //return base.Circumference();
            return 2 * (L + B);
        }
    }
    class Circle:Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius:");
            R = float.Parse(Console.ReadLine());
        }
    }
    class OverridingEg
    {
        static void Main()
        {

            Rectangle rect = new Rectangle();
            Console.WriteLine("Area of Rectangle is : "+rect.Area());
            Console.WriteLine("Rectangle Circumference:" + rect.Circumference());
            Circle circle = new Circle();
            Console.WriteLine("Area of Circle: "+circle.Area());
            Console.WriteLine("Circumference of circle: " + circle.Circumference());
            Console.WriteLine("-----------------");
            circle.GetRadius();
            Console.WriteLine("Area of Circle: " + circle.Area());
            Console.WriteLine("Circumference of circle: " + circle.Circumference());
            Console.Read();

        }
    }
}
