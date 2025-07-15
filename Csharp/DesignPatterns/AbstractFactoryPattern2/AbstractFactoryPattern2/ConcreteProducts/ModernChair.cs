using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern2.AbstractProducts;

namespace AbstractFactoryPattern2.ConcreteProducts
{
    public class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sit on Modern Chair");
        }
    }
}
