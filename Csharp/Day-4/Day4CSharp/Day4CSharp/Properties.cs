using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharp
{
    class Employee
    {
        private string ecode = "N.A.";
        private string name = "Unknown";
        //private int age = 0;
        public int age { get; set; }

        //declaring properties
        public string Ecode
        {
            get { return ecode; }
            set { ecode = value; }
        }
        public string EmpName
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            //return base.ToString();]
            return "Employee COde=" + ecode + " " + "Employee Name= " + name + " " +
                "Employee Age=" + age;
           // return String.Format();
        }

    }
    class Properties
    {
        static void Main()
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.Ecode+" "+employee.EmpName);
            employee.Ecode = "e101";
            employee.EmpName = "dinesh";
            Console.WriteLine(employee.Ecode+" "+employee.EmpName);
            Console.WriteLine("---------------------");
            employee.age += 5;
            Console.WriteLine("Employee Details:{0}", employee.ToString());
            Console.Read();

        }
    }
    class Products
    {
        public int ProductId { get; }
        public string ProductName { get; set; }
        public double ProductPrice { get; protected set; }
    }
}
