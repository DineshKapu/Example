using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscountApp.Discounts;
namespace DiscountApp.Factory
{
    public static class DiscountFactory
    {
        public static IDiscountStrategy CreateDiscount(string type)
        {
            IDiscountStrategy id = null;
            if (type.ToLower() == "seasonal")
            {
                id = new SeasonalDiscount();
            }
            else if (type.ToLower() == "clearance")
            {
                id = new ClearanceDiscount();
            }
            else if (type.ToLower() == "membership")
            {
                id = new MembershipDiscounts();
            }
            else
                id = null;
            
            return id;
        }
    }
}
