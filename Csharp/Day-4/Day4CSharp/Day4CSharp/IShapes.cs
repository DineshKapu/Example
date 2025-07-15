using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharp
{
    interface IShapes
    {
        void GetData();
        void Area();
        void Circumference();
    }
    public class Circle1:IShapes
    {
        private float r;
        public void GetData()
        {
            Console.WriteLine("Enter radius:");
            r = float.Parse(Console.ReadLine());
        }
        public void Area()
        {
            Console.WriteLine("The area of a Circle is : " + (3.14*r*r));
        }
        public void Circumference()
        {
            Console.WriteLine("The Circumference of a Circle is : " + (2 * 3.14 * r));
        }
    }

    public class Rectangle1 : IShapes
    {
        private float l,b;
        public void GetData()
        {
            Console.WriteLine("Enter Length:");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth:");
            b = float.Parse(Console.ReadLine());
        }
        public void Area()
        {
            Console.WriteLine("The area of a Rectangle is : " + (l*b));
        }
        public void Circumference()
        {
            Console.WriteLine("The Circumference of a Rectangle is : " + (2 *(l+b)));
        }
    }

    class ShapeTester
    {
        static void Main()
        {

            //default method call
            Circle1 circle = new Circle1();
            circle.GetData();
            circle.Area();
            circle.Circumference();
            Console.WriteLine("-------------------");
            Rectangle1 rect = new Rectangle1();
            rect.GetData();
            rect.Area();
            rect.Circumference();
            Console.WriteLine("-------------------");
            ////explicit implementation calls can be made as follows
            //1. 
            IShapes ishape = new Circle1();
            ishape.GetData();
            ishape.Area();
            ishape.Circumference();
            Console.WriteLine("-------------------");
            //2.
            ((IShapes)rect).GetData();
            ((IShapes)rect).Area();
            ((IShapes)rect).Circumference();
            Console.Read();
            
        }
    }


}
