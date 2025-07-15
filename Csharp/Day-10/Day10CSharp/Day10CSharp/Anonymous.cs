using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CSharp
{
    class Anonymous
    {
        static void Main()
        {
            Console.WriteLine("----------Predicate Delegate-----------");
            // Using anonymous method
            List<int> nums = new List<int> { 3,9,11,45,18 };
            Predicate<int>check = delegate (int n)
            { 
                return n % 3 == 0; 
            };

            List<int> result = nums.FindAll(check);

            Console.WriteLine("The Numbers that are Divisible by 3:");
            foreach (int number in result)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
            //using lambda 
            List<int> nums1 = new List<int> { 33, 95, 101, 45, 36 };
            List<int> res = nums.FindAll(n => n % 3 == 0);
            Console.WriteLine("The Numbers that are Divisible by 3:");
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("----------Function Delegate-----------");
            //using anonymous function
            Func<int,int,int> product1 = delegate (int n1,int n2)
                {
                    return n1 * n2;
                };
            Console.WriteLine(product1(5, 6));
            //using lambda
            Func<int,int,int> product2 = (n1,n2) => n1 * n2;
            Console.WriteLine(product2(4, 5));
            Console.Read();

        }

    }
}
