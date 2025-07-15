using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharp
{
    interface ICustomer
    {
        // method declarations
        void Print();
        int Add(int a, int b);
    }
    interface Isupplier
    {
        void Prints();
    }
    class Customer:ICustomer,Isupplier
    {
        public void Print()
        {
            Console.WriteLine("Hello from customer");
        }
        public void Prints()
        {
            Console.WriteLine("hello from supplier");
        }
        public int Add(int x,int y)
        {
            return x + y;
        }

    }
    class InterfaceTester
    {
        static void Main()
        {
            Customer customer = new Customer();
            customer.Print();
            customer.Prints();

            ICustomer icust = new Customer();
            icust.Print();
            Console.Read();
        }
    }
}
