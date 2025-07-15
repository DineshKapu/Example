using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Unity.BusinessLayer
{
    public class BusinessLogic
    {
        Iproducts _products;
        IOrders _orders;

        //injecting the base type that implements the interface in the constructor
        public BusinessLogic(Iproducts ip,IOrders io)
        {
            _products = ip;
            _orders = io;
        }
        public void Insert()
        {
            _products.InsertProducts();

            _orders.DsiaplyOrders();
        }
    }
}
