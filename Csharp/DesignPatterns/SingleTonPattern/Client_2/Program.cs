using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonPattern;
namespace Client_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTonClass training = SingleTonClass.GetInstance();
            {
                training.Show("Client_2:This is Dot Net Taining");
                Console.Read();
            }
        }
    }
}
