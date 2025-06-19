using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Csharp
{
    struct Student //class Student
    {
        public float mathsmarks, sciencemarks;
        public void show()
        {
            Console.WriteLine(mathsmarks + " " + sciencemarks);
        }

    }
    class UserDefinedValueTypes
    {
        public static void Main()
        {
            Student s1=new Student();
            s1.mathsmarks = 95.5f;
            s1.sciencemarks = 93.8f;
            Console.WriteLine(s1.sciencemarks + s1.mathsmarks);
            s1.show();

            Student s2 = s1; //assigning s1 to s2
            Console.WriteLine(s2.sciencemarks + s2.mathsmarks);

            Console.WriteLine("-----After Reassigning values-----");
            s1.mathsmarks = 97.7f;
            s1.show();
            s2.show();
            Console.WriteLine(s1.sciencemarks + s1.mathsmarks);
            Console.WriteLine(s2.sciencemarks + s2.mathsmarks);

            /*while using struct the outputs are://Structures are value types
                189.3 189.3
                191.5 189.4
            while using class the outputs are://classes are reference types
                189.3 189.3
                191.5  191.5*/
            Console.WriteLine("-----Enumerations----");
            Enumerations.Enumops();
            Console.Read();
        }
    }
   enum cities
    {
        Agra,Banglore,Chennai,Delhi,Hyderabad,Vizag
    }
    /*enum cities
    {
        Agra=3, Banglore=1, Chennai=2, Delhi=4, Hyderabad=3, Vizag=5
    }*/
    class Enumerations
    {
        enum Days { Mon=4,Tue,Wed,Thu,Fri,sat,Sun}
        public static void Enumops()
        {
            foreach(int c in Enum.GetValues(typeof(cities)))
            {
                if(c==1)
                {
                    Console.WriteLine(Enum.GetName(typeof(cities),c)+" "+ "is a Garden City");
                }
                else if(c==2)
                {
                    Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "is a Temple City");
                }
                else if (c == 5)
                {
                    Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "is a Steel City");
                }

            }
            Console.WriteLine("----------");
            foreach(var x in Enum.GetValues(typeof(cities)))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("--Accesing constants");
            int wkstart = (int)Days.Mon;
            int weekend = (int)Days.Fri;
            Console.WriteLine("Mondays are weekstarts: {0}", wkstart);
            Console.WriteLine("Fridays are :{0}", weekend);
        }
    }

}
