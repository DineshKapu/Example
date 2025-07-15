using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Csharp
{
    abstract class Phones
    {
        public string PhoneType;
        public abstract  void Work();

    }

    class Mobile:Phones
    {
        public override void Work()
        {
            PhoneType = "Mobiles";
            Console.WriteLine("I am a mobile phone "+" "+PhoneType);
        }
    }
    class UnderstandingAbstraction
    {
        public static void Main()
        {
            Phones ph = new Mobile();
            ph.Work();
            Console.Read();

        }
    }
}
