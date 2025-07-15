using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14CSharp
{
    class Person
    {

        public string Nmae { get; set; }
        //public static void WriteStringLength(string str)
        //{
        //    if(str is null)
        //    {
        //        Console.WriteLine("It is a Null String");
        //    }
        //    if(str is { Length:0})
        //    {
        //        Console.WriteLine("Empty String");
        //        return;
        //    }
        //    if (str is { Length: 1 })
        //    {
        //        Console.WriteLine("It is a string o length 1");
        //        return;
        //    }
        //    else 
        //    {
        //        Console.WriteLine("String of more than 1 length");
        //        return;
        //    }
        //}
    }
    class Program
    {
        //positional Pattern
        public struct CheckBooleanData
        {
            public bool Data1 { get; set; }
            public bool Data2 { get; set; }

            public void unWrao(out bool d1,out bool d2)
            {
                d1 = Data1;
                d2 = Data2;
            }
        }
        //postional Pattern with logical and And or
        //public static bool LogicalAnd(CheckBooleanData n1)
        //{
        //    //using switch expresssions
        //    return n1 switch
        //    {
        //        (false, false) => false,
        //        (true, false) => false,
        //        (false, true) => false,
        //        (true, true) => true,
        //    };
        //public static bool LogicalOr(CheckBooleanData n1)
        //{
        //    //using switch expresssions
        //    switch(n1)
        //    {
        //        case (false, false) return false,
        //        case (true, false) return  true,
        //        case (false, true) return  true,
        //        case (true, true) return true,
        //    }

        //}
    static void Main(string[] args)
        {
            Console.WriteLine();
            //Property PAttern
            Person p = new Person();
            //Person.WriteStringLength("");
            //Person.WriteStringLength("A");

            Console.Read();
        }
    }
}
