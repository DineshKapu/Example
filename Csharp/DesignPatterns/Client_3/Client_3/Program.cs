using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonPattern;
namespace Client_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTonClass Company = SingleTonClass.GetInstance();
            {
                Company.Show("Client_3:Infinite Computer Solutions");

            }
            SingleTonClass.DerivedSingleTon derivedobj = new SingleTonClass.DerivedSingleTon();
            { 
                derivedobj.Show("This is from Derived Object of the SingleTon..");
            }
            Console.Read();
        }
    }
}
