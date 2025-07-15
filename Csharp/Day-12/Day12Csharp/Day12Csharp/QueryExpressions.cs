using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Csharp
{
    public class QueryExpressions
    {
        public static void Main(string[] args)
        {
            int[] intval = {1,2,3,4,5,6,7,8,9,10};

            //Query Expression
            IEnumerable<int> oddvalues = from v in intval
                                         where (v % 2) != 0
                                         select v;
            //iterate the result collection
            foreach(int x in oddvalues)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Query Expressions with Objects-----");
            IEnumerable<Student> stdobj = from student in Student.GetStudents()
                                          where student.Name.EndsWith("h")
                                          select student;
            foreach(var s in stdobj)
            {
                Console.WriteLine($"{s.id} {s.Name} {s.Email}");
            }
            //name of the student whose id=103
            IEnumerable<string> stdname = from s in Student.GetStudents()
                          where s.id == 103
                          select s.Name;
            foreach (var s in stdname)
            {
                Console.WriteLine($"{s}");
            }
            //sort by name
            IEnumerable<Student> sortByName = from s in Student.GetStudents()
                                              orderby s.Name
                                              select s;
            foreach (var s in sortByName)
            {
                Console.WriteLine($"{s.id} {s.Name} {s.Email}");
            }
            Console.Read();
        }
        public class Student
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public static List<Student> GetStudents()
            {
                List<Student> stdlist = new List<Student>()
                {
                    new Student{id=101,Name="Dinesh",Email="dinesh@gmail.com"},
                    new Student{id=102,Name="jay",Email="jay@gmail.com"},
                    new Student{id=103,Name="manohar",Email="manohar@gmail.com"},
                     new Student{id=106,Name="porna",Email="porna@gmail.com"},
                    new Student{id=108,Name="rahul",Email="rahul@gmail.com"}

                };
                return stdlist;
            }
        }
    }
}
