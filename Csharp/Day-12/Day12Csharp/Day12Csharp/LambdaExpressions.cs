using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Day12Csharp.QueryExpressions;

namespace Day12Csharp
{
    public class LambdaExpressions
    {
        public static void Main()
        {
            List<int> numbers = new List<int> {36,71,12,15,29,18,27,17,9,10 };
            //using lambda find out the squares of each element
            var square = numbers.Select(n => n * n);
            foreach(var v in square)
            {
                Console.Write("{0}   ", v);


            }

            //Student s = new Student();
            Console.WriteLine();

            //find all the numbers divisible by 3
            //List<int>DivBy3=numbers.FindAll(n=>n%3==0);
            //var DivBy3 = numbers.Select(n => n % 3 == 0); //It returns Boolean values
            var DivBy3 = numbers.Where(n => n % 3 == 0);
            foreach (var v in DivBy3)
            {
                Console.Write("{0}", v);
            }
            Console.WriteLine();

            //lambda with objects
            //Student student = Student.GetStudents().Find(std=>std.id==101);
            //Console.WriteLine(student.Name);
            ////sort by name
            //var ss = Student.GetStudents().OrderBy(x => x.Name);
            //foreach(var i in ss)
            //{
            //    Console.WriteLine($"{s.id} {s.Name} {s.Email}");
            //}

            Console.Read();
        }
    }
}
