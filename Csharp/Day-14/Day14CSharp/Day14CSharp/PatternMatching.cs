using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14CSharp
{
    class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public Student(string fn,string ln)
        {
            FName = fn;
            LName = ln;
        }
    }
    class PatternMatching:Student
    {
        public PatternMatching(string f, string l) : base(f, l) { }
        static void Main()
        {
            //Student std = new Student("Yogesh", "Velu");
            //Student std = null;
            Student std = new PatternMatching("A", "B");
            switch (std)
            {
                //constant Pattern
                case null: Console.WriteLine("Constant Pattern");
                    break;
                //type Pattern
                case Student s when s.FName.StartsWith("Y"):
                    Console.WriteLine(s.FName); break;
                //var Pattern
                case var v:
                    Console.WriteLine(v ?.GetType().Name + "  Thru implicit var");
                    break;
            }
            Console.ReadLine();
        }
    }
}
