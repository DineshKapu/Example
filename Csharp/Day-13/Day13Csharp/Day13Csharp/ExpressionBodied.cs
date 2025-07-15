using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day13Csharp
{
    class ExpressionBodied
    {
        public static int Year = 2016;
        public int Area(int side) => side * side;
        public int Arithmetic(int a, int b) => ((a + b) + (a - b) + (a * b) + (a / b));
        static void Main()
        {
            Console.WriteLine(LeapYear());
            Console.WriteLine("*******************************");
            ExpressionBodied ab = new ExpressionBodied();
            int i = 6;
            int a = 15, b = 5;
            Console.WriteLine(ab.Area(i));
            Thread.Sleep(2000);
            Console.WriteLine(ab.Arithmetic(a, b));


            Console.Read();
        }
        //1.with expression boided
        //public static string LeapYear()
        //{
        //    return "\n Is " + Year + " a Leap Year ? " + DateTime.IsLeapYear(Year); 
        //}
        //2.
        public static string LeapYear()=>$"Is {Year}  a Leap Year? {DateTime.IsLeapYear(Year)}";
    }
}
