using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApp.Discounts
{
    public class SeasonalDiscount:IDiscountStrategy
    {
        public decimal ApplyDiscounts(decimal price) => price * 0.90m;
    }
}
