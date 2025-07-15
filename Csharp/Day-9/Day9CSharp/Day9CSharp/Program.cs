using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9CSharp
{
    public delegate int CalculatorDel(int x);
    class Program
    {
        static int p;
        public int Square(int x)
        {
            p = x * x;
            return p;
        }
        public int Triple(int q)
        {
            p = q * q * q;
            return p;
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            CalculatorDel cd = new CalculatorDel(prog.Square);
            int result = cd(5);
            Console.WriteLine("Return Value is:{0}",result);
            cd = new CalculatorDel(prog.Triple);
            Console.WriteLine("Return Value is:{0}",cd(5));
            Console.Read();

        }
    }
}
