using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Unity.ConcreteModules
{
    public class DataLayer : Iproducts
    {
        public string InsertProducts()
        {
            string str="DI Injected Successfully";
            Console.WriteLine(str);
            return str;
        }
    }
}
