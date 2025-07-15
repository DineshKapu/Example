using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern2.ConcreteProducts;
using AbstractFactoryPattern2.ConcreteFactory;
using AbstractFactoryPattern2.AbstractProducts;
using AbstractFactoryPattern2.AbstractFactory;
namespace AbstractFactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Which Furniture do you want? (Modern/Vintage or exit): ");
                string FurnitureChoice = Console.ReadLine().ToLower();
                if(FurnitureChoice=="exit")
                {
                    break;
                }
                IFurnitureFactory factory = null;
                if(FurnitureChoice == "modern")
                {
                    factory = new ModernFurnitureFactory();
                }
                else if (FurnitureChoice == "vintage")
                {
                    factory = new VintageFurnitureFactory();
                }
                else
                {
                    Console.WriteLine("Invalid Factory Type.Try Again");
                    factory = null;
                    continue;
                }
      
                Console.WriteLine($"You selected {FurnitureChoice} factory. Do you want a 'Chair' or a 'Sofa'?");
                string Type = Console.ReadLine().ToLower();
                if(Type=="chair")
                {
                    IChair chair= factory.CreateChair();
                    chair.SitOn();
                }
                else if(Type=="sofa")
                {
                    ISofa sofa = factory.CreateSofa();
                    sofa.LayOn();
                }
                else
                {
                    Console.WriteLine("Invalid Type.Try Again");
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine("Thank You For Choosing Our Furniture ._.");
            Console.Read();
        }
    }
}
