using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharp
{
    class OverloadingEg
    {
        public int add(int x,int y)
        {
            return 0;
        }
        public float add(int x,float y)
        {
            return 1.5f;
        }
        public static void swap(int number1,int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Swapping of two numbers number 1= " +number1 + "number 2= "+number2);
        }
        public static void swap(char c1,char c2)
        {
            char temp;
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine("Swapping of two Characters Character 1= " + c1 + "Character 2= " + c2);
        }
    }
    class OverloadChecker
    {
        static void Main()
        {
            OverloadingEg oeg = new OverloadingEg();
            Console.WriteLine( oeg.add(5, 5));
            Console.WriteLine( oeg.add(5, 1.5f));
            OverloadingEg.swap(4, 5);
            OverloadingEg.swap('a', 'e');
            Console.Read();
        }
    }
}
