using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Csharp
{
    class Sample
    {
        static Sample()
        {

        }
        static void CallMe()
        {
            Console.WriteLine("I am a static Function");
        }
        static void Main()
        {
            Sample s = new Sample();
            CallMe();

            /* call the CallMe function*/

            Console.Read();
        }
    }
  
}
