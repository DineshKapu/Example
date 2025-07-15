using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApp.Discounts
{
    public class ClearanceDiscount:IDiscountStrategy
    {
        public decimal ApplyDiscounts(decimal price) => price * 0.70m;
    }
}
