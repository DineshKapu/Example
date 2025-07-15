using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project_2
{
    public class EmployeeBAL
    {
        //Client Class or Dependent Class
        public IEmployeeDAL employeeDAL;

        //1.injecting Dependency into the constructor of the dependant object
        //public EmployeeBAL(IEmployeeDAL _edal)
        //{
        //    employeeDAL = _edal;
        //}
        //2, Injecting dependency to the public property of the dependant class
        //public IEmployeeDAL EmpDataObject
        //{
        //    set
        //    {
        //        this.employeeDAL = value;
        //    }
        //}

        //public List<Employee>SelectAllEmployees()
        //{
        //    //create an instance of the dependency class
        //    //employeeDAL = new EmployeeDAL(); //It is a tight coupled code
        //    return employeeDAL.GetAllEmployees();
        //}

        //3. Method injection of the dependency object
        public List<Employee> SelectAllEmployees(IEmployeeDAL employeeDAL)
        {
            //create an instance of the dependency class
            //employeeDAL = new EmployeeDAL();  // is a tight coupled code

            return employeeDAL.GetAllEmployees();
        }

    }
}
