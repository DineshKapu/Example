using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9CSharp
{
    class PersonDescription
    {
        public string Firstname,Lastname;
        public PersonDescription(string f,string l)
        {
            Firstname = f;
            Lastname = l;
        }
    }
    class Person
    {
        public int Age;
        public PersonDescription desc; //composition
        public Person(int a,string fn,string ln)
        {
            Age = a;
            desc = new PersonDescription(fn, ln);
        }
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person pcopy = new Person(this.Age,desc.Firstname,desc.Lastname);
            return pcopy;
        }
    }
    class DeepvsShallow
    {
        static void Main()
        {
            Person p1 = new Person(22,"Dinesh","Kapu");
            Person p2 = (Person)p1.ShallowCopy();
            Console.WriteLine($"P1.Age is{p1.Age},P1's FirstName is {p1.desc.Firstname}");
            Console.WriteLine($"P2.Age is{p2.Age},P2's FirstName is {p2.desc.Firstname}");
            p2.desc.Firstname = "Satya";
            Console.WriteLine(p1.desc.Firstname);
            Console.WriteLine(p2.desc.Firstname);

            Console.WriteLine("------Deep copy------");
            Person p3 = p1.DeepCopy();
            Console.WriteLine($"P1.Age is{p1.Age},P1's FirstName is {p1.desc.Firstname}");
            Console.WriteLine($"P3.Age is{p3.Age},P3's FirstName is {p3.desc.Firstname}");

            p3.desc.Lastname = "Reddy";
            Console.WriteLine(p1.desc.Lastname);
            Console.WriteLine(p3.desc.Lastname);
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.Read();
        }

    }
}
