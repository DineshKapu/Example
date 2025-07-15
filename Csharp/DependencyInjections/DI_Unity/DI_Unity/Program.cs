using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using DI_Unity.ConcreteModules;
namespace DI_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an object of the container
            UnityContainer uc = new UnityContainer();

            //2.Register all relevant types
            uc.RegisterType<Iproducts, DataLayer>();
            uc.RegisterType<IOrders, OrderClass>();

            //invoking the DI enabled Methods
            BusinessLayer.BusinessLogic bl = uc.Resolve<BusinessLayer.BusinessLogic>();
            bl.Insert();
            Console.Read();
        }
    }
}
