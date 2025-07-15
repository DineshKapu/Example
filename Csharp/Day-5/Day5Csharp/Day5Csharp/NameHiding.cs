using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Csharp
{
    class Phone
    {
        public string brand { get; set; }
        public void PhoneFeatures()
        {
            Console.WriteLine("This is base class and features" + " " + brand);
        }
    }
    class Oneplus:Phone
    {
        public new void PhoneFeatures()
        {
            Console.WriteLine("One plus Mobile Features"+" "+brand);
        }
    }
    class NameHiding
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.brand = "phone";
            phone.PhoneFeatures();
            phone= new Oneplus();
            phone.brand = "iphone";
            phone.PhoneFeatures();
            Console.Read();
        }
    }
}
