using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Day9CSharp
{
    public class Demo:IDisposable
    {
        ~Demo()
        {
            Console.WriteLine("Finalized Call...........");
            Console.Read();
            //WriteLine("");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose called----");
            
        }
    }
    class GarbageEg
    {
        static void Main()
        {
            Console.WriteLine("Maximum no.of generations:{0}", GC.MaxGeneration);
            GarbageEg ge = new GarbageEg();
            Console.WriteLine("The Generation number:{0}", GC.GetGeneration(ge));
            Console.WriteLine("The total memory:{0}",GC.GetTotalMemory(false));
            Console.WriteLine("--------------------------------------");
            ge = null;
            GC.Collect();
            //Console.WriteLine("The Generation number:{0}", GC.GetGeneration(ge));
            //Console.WriteLine("The total memory:{0}", GC.GetTotalMemory(false));
            Console.WriteLine("---------------------");
            Demo demo = new Demo();
            demo.Dispose();
            Console.ReadLine();
        }
    }
}
