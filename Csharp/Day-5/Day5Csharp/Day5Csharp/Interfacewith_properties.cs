using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Csharp
{
    interface Interfacewith_properties
    {
 
        string Name { get; set; } 
    }
    class Employee:Interfacewith_properties
    {
        public string Name { get; set; }
    }
    class Company:Interfacewith_properties
    {
        //private string CompanyName { get; set; }
        private string CompanyName;
        public int age { get; set; } = 21;
        public string Name
        {
            get { return CompanyName; }
            set {CompanyName=value; }
        }
    }
    class Prop
    {
        static void Main()
        {
            Interfacewith_properties employee = new Employee();
            employee.Name = "dinesh";

            Interfacewith_properties company = new Company();
            company.Name = "Infinite Ltd..";
            Console.WriteLine("This is {0} from {1}", employee.Name, company.Name);
            Company c = new Company();
            c.Name = "new Infinite";
            c.age = 25;
            Console.WriteLine("This is {0} from {1}", c.Name, c.age);
            Console.Read();
        }
    }
}
