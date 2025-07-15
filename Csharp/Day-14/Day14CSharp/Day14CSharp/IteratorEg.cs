using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14CSharp
{
    class IteratorEg
    {
        public static IEnumerable<string>GetData()
        {
            List<string> colors = new List<string> { "Red", "Blue", "Green", "Black", "White" };
            foreach(var items in colors)
            {
                yield return items;
            }
        
        }
        //example for yield with return and break
        public static IEnumerable<int> GetRandomYears()
        {
            int year;
            while(true)
            {
                Random rand = new Random();
                year = rand.Next(2000, 2025);
                if (year % 4 == 0)
                {
                    Console.WriteLine($"Leap Year{year} Encountered");
                    yield break;
                }
                yield return year;
            }
            Console.WriteLine("Method Done..");
        }
        static void Main()
        {
            IEnumerable<string> retColors = GetData();
            //displaying colors
            foreach(var i in retColors)
            {
                Console.WriteLine(i);
            }

            foreach(int yr in GetRandomYears())
            {
                Console.WriteLine(yr);
            }
            Console.ReadLine();
        }
    }
}
