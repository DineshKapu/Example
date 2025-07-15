using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);
        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType == "land")
            {
                return new LandAnimalFactory();
            }
            else if (factoryType == "sea")
            {
                return new SeaAnimalFactory();
            }
            else
                return null;
        }
    }
}
