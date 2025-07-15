using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern2.AbstractFactory;
using AbstractFactoryPattern2.AbstractProducts;
using AbstractFactoryPattern2.ConcreteProducts;
namespace AbstractFactoryPattern2.ConcreteFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
