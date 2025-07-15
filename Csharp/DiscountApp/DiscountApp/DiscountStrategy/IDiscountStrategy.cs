using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApp.Discounts
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscounts(decimal price);
    }
}
