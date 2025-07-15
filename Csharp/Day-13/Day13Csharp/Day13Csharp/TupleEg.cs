using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cdf
{
    namespace Day13Csharp
    {
        class TupleEg
        {
            public static void Main()
            {
                int n1 = 10, n2 = 20, n3 = 30;
                List<int> temp = new List<int> { 1, 2, 3 };
                var (min1, max1, avg1) = Calculate(temp);
                Console.WriteLine($"Minimum value:{min1} Maximum Value: {max1} Average Value:{avg1}");
                Console.Read();
            }
            public static (int, int, double) Calculate(IEnumerable<int> list) // public static (int min1,int max1 ,double avg1)Calculate(int x,int y,int z)
            {
                //    int min1 = Math.Min(x, Math.Min(y, z));
                //    int max1 = Math.Max(x, Math.Max(y, z));
                //    double avg1 = (x + y + z) / 3.0;
                int min1 = list.Min();
                int max1 = list.Max();
                double avg1 = list.Average();
                return (min1, max1, avg1);
            }
        }
    }
}