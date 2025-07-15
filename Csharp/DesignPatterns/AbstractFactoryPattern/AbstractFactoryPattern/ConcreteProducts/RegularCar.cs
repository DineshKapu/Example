using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class RegularCar:ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("FEtching Regular Car Details");
        }
    }
}
