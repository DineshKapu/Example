using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Csharp
{
        class Parent
        {
            int parentdata;
            /* public Parent() //empty constructor
            {
                parentdata = 100;
            Console.WriteLine(parentdata);
            Console.WriteLine("i am from parent");
            }*/
            public Parent(int x) //parameterized constructor
            {
                parentdata = x;
                Console.WriteLine("parent data:{0}",parentdata);
            }
        }
        class Derived:Parent
        {
            int deriveddata;
            public Derived(int a,int b) :base(b)
            {
                deriveddata = a;
                Console.WriteLine("deriveddata:{0}",deriveddata);
                Console.WriteLine("Hi i am from derived");
            }
        }
        class InheritanceEg
        {
            static void Main()
            {
                Derived d = new Derived(10,20);
       
                Console.Read();
            }
        }
}
