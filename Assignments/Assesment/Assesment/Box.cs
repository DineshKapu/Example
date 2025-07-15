using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    class Box
    {
        public int length;
        public static Box operator +(Box box1, Box box2)
        {
            Box temp = new Box();
            temp.length = box1.length + box2.length;
            return temp;
        }
        public static void Main()
        {

            Box box1 = new Box();
            box1.length = 10;
            Box box2 = new Box();
            box2.length = 20;
            Box box3 = box1 + box2;
            Console.WriteLine($"The overall length is :{box3.length}");
            Console.Read();

        }

    }
 
}
