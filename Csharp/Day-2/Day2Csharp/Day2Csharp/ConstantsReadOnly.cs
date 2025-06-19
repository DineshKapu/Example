using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Csharp
{
    class ConstantsReadOnly
    {
        //readonly fields
        public readonly int myvar1 = 5;//assigning value to readonly at the time of declaration.
        public readonly int myvar2; //just declaration

        //non-static field
        public float f=10.5f;

        //static member
        static public int st = 50;

        //constant
        const float PI=3.14f;//value has to be assigned at the time of declaration only.

        //intializing readonly fields at construction
        ConstantsReadOnly()
        {
            Console.WriteLine(myvar1 + " " + myvar2);
            myvar1 = 50; //this takes precedence over the assignment at declaration time
            myvar2 = 100;
        
        }
    
        public static void Main()
        {
            Console.WriteLine("------------Static------");
            Console.WriteLine(ConstantsReadOnly.st);
            ConstantsReadOnly.st = 150;//Can change the static value
            Console.WriteLine(ConstantsReadOnly.st);
            Console.WriteLine("-----------");
            ConstantsReadOnly cro = new ConstantsReadOnly();

            Console.WriteLine("-----not static field-----");
            Console.WriteLine(cro.f);
            cro.f = 25.46f;
            Console.WriteLine(cro.f);

            Console.WriteLine("-----Read-only  field-----");
            Console.WriteLine(cro.myvar1 + " " + cro.myvar2);

            Console.WriteLine("-----const field-----");
            Console.WriteLine(ConstantsReadOnly.PI);

            Console.Read();




        }


    }
}
