using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscountApp.Factory;
using DiscountApp.Discounts;
namespace DiscountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Original Price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter discount type (Seasonal(10%) / Clearance(30%) / Membership(5%)): ");
            string type = Console.ReadLine();
            IDiscountStrategy discount = DiscountFactory.CreateDiscount(type);
            decimal discountedPrice = discount.ApplyDiscounts(price);
            Console.WriteLine($"Final price after {type} discount: {discountedPrice}");
            Console.Read();
        }

    }
}
