using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharp
{
    class Student
    {
        private string Rollno;
        private string Name;
        private String Class;
        public void GetData()
        {
            Console.WriteLine("Enter Roll no:");
            Rollno = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class: ");
            Class = Console.ReadLine();
        }
        public void PutData()
        {
            Console.WriteLine("Name of the Student :{0}", Name);
            Console.WriteLine("Roll no:{0}", Rollno);
            Console.WriteLine("Class:" + Class);
        }

    }
    class Marks: Student
    {
        protected int[] a = new int[5];

        public void GetMarks()
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write("Enter Subject{0} marks:", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void PutMarks()
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("The {0} Subject Marks are:{1}",i+1,a[i]);
            }
        }
    }

    class Results: Marks
    {
        int TotalMarks = 0;
        public void GetResults()
        {
            for (int i = 0; i <a.Length; i++) { 
            TotalMarks += a[i];
             }
        }
        public void PutResults()
        {
            Console.WriteLine("======results=======");
            PutData();
            PutMarks();
            
            Console.WriteLine("TotalMarks: {0}", TotalMarks);
          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Results results = new Results();
            results.GetData();
            results.GetMarks();
            results.GetResults();
            results.PutResults();
            Console.Read();
        }
    }
}
