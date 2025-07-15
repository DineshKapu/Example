using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14CSharp
{
    class Employee
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public static (string,double,string)GetEmployeeDetails(long eid)
        {
            string ename = "Vikram";
            double salary = 45000;
            string dname = "HR";
            return (ename, salary, dname);
        }
    }
    class Deconstruction
    {
        static void Main()
        {
            //1.Deconstruction by creating multiple variables
            var employeedetails = Employee.GetEmployeeDetails(1001);
            var EName = employeedetails.Item1;
            var Esalary = employeedetails.Item2;
            var EDept = employeedetails.Item3;
            Console.WriteLine($"{EName}, {Esalary} and {EDept}");

            //2.Explictly declare the type of each field inside the paranthesis
            (string name, double sal, string dept) = Employee.GetEmployeeDetails(1001);
            Console.WriteLine(name+" "+sal +" "+dept);

            //3.using var keyword (type is inferred)
            var (Name,Sal,Dept) = Employee.GetEmployeeDetails(1001);
            Console.WriteLine(Name + " " + Sal + " " + Dept);

            //4.tuple into variables  at the calling function
            string EmployeeName, DepartmentName;
            double EmpSalary;
            (EmployeeName, EmpSalary, DepartmentName) = Employee.GetEmployeeDetails(1001);
            Console.WriteLine(EmployeeName+" "+EmpSalary+" and "+DepartmentName);
            Console.Read();
        }
    }
}
