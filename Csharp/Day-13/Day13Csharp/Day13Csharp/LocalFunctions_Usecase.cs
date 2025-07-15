using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Csharp
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        //public Nullable<string> Projects { get; set; }
    }
    class LocalFunctions_Usecase
    {
        static void Main()
        {
            Employee emp1 = new Employee()
            {
                Id = 1001,
                Name="Dinesh",
                Gender="Male",
                Salary=56000,
                Department="IT"
            };

            bool IsInserted = AddEmployee(emp1);
            Console.WriteLine($"Is Employee with Id{emp1.Id} inserted?:{IsInserted}");
            Console.WriteLine("**************");

            Employee emp2 = new Employee()
            {
                Id = 1002,
                Name = "Eswar",
                Department = "IT"
            };
            IsInserted = AddEmployee(emp2);
            Console.WriteLine($"Is Employee with Id{emp2.Id} inserted?:{IsInserted}");

           //calling function passing null object
            //Console.WriteLine("---------Empty Object------");
            //Employee e=null;
            //IsInserted = AddEmployee(e);//It Throws Exception
            Console.WriteLine("Press any Key to Exit..");
            Console.Read();
        }
       //Parent Function
       public static bool AddEmployee(Employee eRequest)
        {
            bool isvalid;
            var validationResult = IsRequestValid();
            if(validationResult.isvalid==false)
            {
                Console.WriteLine($"{nameof(eRequest.Id)}{nameof(validationResult.errorMessage)}:"
                    + $"{validationResult.errorMessage}");
                return false;
            }
            return true;

            //Local Function
            (bool isvalid,string errorMessage)IsRequestValid()
            {
                if(eRequest==null)
                {
                    throw new ArgumentNullException(nameof(eRequest), $"The {nameof(eRequest)} object cannot be null");
                }
                var msg = new Lazy<StringBuilder>();
                if(string.IsNullOrWhiteSpace(eRequest.Name))
                {
                    msg.Value.AppendLine($" The {nameof(eRequest)}'s {nameof(eRequest.Name)} property cannot be empty");
                }
                if(eRequest.Id<=0)
                {
                    msg.Value.AppendLine($" The {nameof(eRequest)}'s {nameof(eRequest.Id)} property cannot be les than or equal to Zero");
                }
                if(eRequest.Salary<=10000 || eRequest.Salary>=60000)
                {
                    msg.Value.AppendLine($" The {nameof(eRequest)}'s {nameof(eRequest.Salary)} property has to between 10000 -60000 only");
                }
                if(msg.IsValueCreated)
                {
                    var errorMessage = msg.Value.ToString();
                    return (isvalid: false, errorMessage: errorMessage);
                }
                return (isvalid: true, errorMessage:string.Empty);
            }
        }
    }
}
