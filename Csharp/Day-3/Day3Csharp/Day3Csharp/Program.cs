using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Csharp
{
    class Employee
    {
        int EmpId;
        string EmpName;
        DateTime Doj;
        double Salary;

        //constructor-1
        internal Employee()
        {
            EmpId = 1;
            EmpName = "Dinesh";
            Doj = Convert.ToDateTime("01/06/2025");
            Salary = 350000;
        }

        //constructor-2
        public Employee(int empid,string ename)
        {
            EmpId = empid;
            EmpName = ename;

        }

        //constructor-3
        public Employee(int EmpId,string EmpName,DateTime Doj,double Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Doj = Doj;
            this.Salary = Salary;
        }
        //Destructor
        ~Employee()
        {
            Console.WriteLine("Bye from Employee....");
            Console.Read();
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"empid: {EmpId} ,empname: { EmpName} , doj: {Doj} and salary: {Salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ShowEmployee();
            Console.WriteLine("**************");
            Employee employee1 = new Employee(101,"dinesh");
            employee1.ShowEmployee();
            Console.WriteLine("**************");
            Employee employee2 = new Employee(102, "dinesh",Convert.ToDateTime("06/01/2025"),35000);
            employee2.ShowEmployee();
            employee1 = null;
            GC.Collect();//garbage collection "Force Collection"
            Console.Read();
        }
    }
}
