using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            int sum = Sum(a, b);
            int diff = Difference(a, b);
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.WriteLine($"The Difference between {a} and {b} is {diff}");
            int n = 5;
            int res = Fact(n);
            Console.WriteLine($"Factoiral of a number {n} is:{res}");
            //local function-These functions cannot be overloaded
            int Sum(int x,int y)
            {
                x = x + a; //can access variables of the enclosing type
                y = y + b;
                return x + y;
            }
  
            int Difference(int x,int y)
            {
                return x - y;
            }
            int Fact(int p)
            {
                if (p >= 1)
                    return p * Fact(p - 1);
                else
                    return 1;
            }
            Console.WriteLine("************Dictionary************");
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Emp001","Dinesh" },
                {"Emp002","Jay" }
            };
            //with c# 6.0
            Dictionary<string, string> dict1 = new Dictionary<string, string>()
            {
                ["Emp001"]="Dinesh",
                ["Emp005"] = "Jay",
            };

            Console.WriteLine("Press any Key to Exit..");
            Console.Read();
        }

    }
}
