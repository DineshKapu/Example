using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharp
{

    class Box
    {
        public int length;
        public int breadth;
        //operator overloading
        public static Box operator +(Box box1,Box box2)
        {
            Box temp=new Box();
            temp.length = box1.length + box2.length;
            temp.breadth = box1.breadth + box2.breadth;
            return temp; 
        }
        public static Box operator ++(Box box1)
        {
            Box b3 = new Box();
            b3.length = box1.length++;
            b3.breadth = box1.breadth++;
            return b3;
        }
    }
    //operator overloading

    class PeratorOverloadingEg
    {
        static void Main()
        {
            Box b1=new Box();
            b1.length = 5;
            b1.breadth = 4;
            Box b2 = new Box();
            b2.length = 10;
            b2.breadth = 5;
            Box b3 = b1 + b2;
            Console.WriteLine($"The overall length is :{b3.length} and beadth is: {b3.breadth}");
         
            Box b4 = b1++;
            Console.WriteLine($"the increment of length :{b4.length} and Breadth :{b4.breadth}");
            Console.Read();
        }
    }
}
