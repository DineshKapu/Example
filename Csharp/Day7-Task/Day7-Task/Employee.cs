using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Task
{
    class EmployeeeInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        List<EmployeeeInfo> emplist = new List<EmployeeeInfo>();

        internal void Add_New_Employee(EmployeeeInfo emp)
        {
            emplist.Add(emp);
        }

        internal void View_All_Employees()
        {
            Console.WriteLine("Employee List");
            foreach (var i in emplist)
            {
                Console.WriteLine($"{i.Id} {i.Name} {i.Salary} {i.Department}");
            }
        }

        internal void Search_Employee_by_ID(int a)
        {
            foreach (var i in emplist)
            {
                if (i.Id == a)
                {
                    Console.WriteLine($"{i.Id} {i.Name} {i.Salary} {i.Department}");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }

        internal void Update(EmployeeeInfo emp1, EmployeeeInfo emp)
        {
            foreach (var i in emplist)
            {
                if (i == emp1)
                {
                    emp1.Department = emp.Department;
                    emp1.Id = emp.Id;
                    emp1.Name = emp.Name;
                    emp1.Salary = emp.Salary;
                    break;
                }
            }
        }

        internal void Delete(EmployeeeInfo emp)
        {
            emplist.Remove(emp);
        }

        internal EmployeeeInfo GetEmployeeById(int id)
        {
            return emplist.FirstOrDefault(e => e.Id == id);
        }
    }

    class Employee
    {
            public static void Main()
            {
                EmployeeeInfo employeee = new EmployeeeInfo();

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("===== Employee Management Menu =====");
                    Console.WriteLine("1. Add New Employee");
                    Console.WriteLine("2. View All Employees");
                    Console.WriteLine("3. Search Employee by ID");
                    Console.WriteLine("4. Update Employee Details");
                    Console.WriteLine("5. Delete Employee");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter your choice: ");

                    try
                    {
                        int a = Convert.ToInt32(Console.ReadLine());

                        switch (a)
                        {
                            case 1:
                                try
                                {
                                    EmployeeeInfo o = new EmployeeeInfo();
                                    Console.Write("Enter Name: ");
                                    o.Name = Console.ReadLine();
                                    Console.Write("Enter Id: ");
                                o.Id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Department: ");
                                    o.Department = Console.ReadLine();
                                    Console.Write("Enter Salary: ");
                                    o.Salary = Convert.ToDouble(Console.ReadLine());
                                    employeee.Add_New_Employee(o);
                                    Console.WriteLine("Employee added successfully.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error adding employee: " + ex.Message);
                                }
                                break;

                            case 2:
                                employeee.View_All_Employees();
                                break;

                            case 3:
                                try
                                {
                                    Console.Write("Enter Id: ");
                                    int w = Convert.ToInt32(Console.ReadLine());
                                    employeee.Search_Employee_by_ID(w);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error searching employee: " + ex.Message);
                                }
                                break;

                            case 4:
                                try
                                {
                                    Console.Write("Enter the ID of the employee to update: ");
                                    int updateId = Convert.ToInt32(Console.ReadLine());
                                    EmployeeeInfo existingEmp = employeee.GetEmployeeById(updateId);
                                    if (existingEmp != null)
                                    {
                                        EmployeeeInfo updatedEmp = new EmployeeeInfo();
                                        Console.Write("Enter new Name: ");
                                        updatedEmp.Name = Console.ReadLine();
                                        Console.Write("Enter new Id: ");
                                        updatedEmp.Id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter new Department: ");
                                        updatedEmp.Department = Console.ReadLine();
                                        Console.Write("Enter new Salary: ");
                                        updatedEmp.Salary = Convert.ToDouble(Console.ReadLine());
                                        employeee.Update(existingEmp, updatedEmp);
                                        Console.WriteLine("Employee updated successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Employee not found.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error updating employee: " + ex.Message);
                                }
                                break;

                            case 5:
                                try
                                {
                                    Console.Write("Enter the employee Id to delete: ");
                                    int e = Convert.ToInt32(Console.ReadLine());
                                    EmployeeeInfo empToDelete = employeee.GetEmployeeById(e);
                                    if (empToDelete != null)
                                    {
                                        employeee.Delete(empToDelete);
                                        Console.WriteLine("Employee deleted.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Employee not found.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error deleting employee: " + ex.Message);
                                }
                                break;

                            case 6:
                                Console.WriteLine("Exiting...");
                                return;

                            default:
                                Console.WriteLine("Invalid choice. Please select between 1 and 6.");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input format.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unexpected error: " + e.Message);
                    }
                }
        }
    }
}
