using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.create an instance of of EmployeeBAL
            //add inject the dependency object as an argument to the constructor

            //EmployeeBAL employeeBAL = new EmployeeBAL(new EmployeeDALImplementor());

            //2.create an instance of the client class
            //EmployeeBAL employeeBAL = new EmployeeBAL();

            //2.1 inject the dependency object  using the public property of the client

            // employeeBAL.EmpDataObject = new EmployeeDALImplementor();

            //List<Employee> emplist = employeeBAL.SelectAllEmployees();

            //3. create an instance of the client class
            EmployeeBAL employeeBAL = new EmployeeBAL();
            List<Employee> emplist = employeeBAL.SelectAllEmployees(new EmployeeDALImplementor());
            foreach (Employee e in emplist)
            {
                Console.WriteLine($"Id- {e.ID}  Name- {e.Name}  Department- {e.Department}");
            }
            Console.Read();
        }
    }
}
