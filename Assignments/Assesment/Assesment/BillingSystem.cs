using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    class BillingSystem
    {
        static void Main(string[] args)
        {
            int[] item=new int[5] { 200,200,200,200,200} ;
            int tot=0;
            double discount = 0.10;
            for (int i = 0; i < item.Length; i++)
            {
                tot += item[i];
            }
            double discountAmount= tot*discount;
            Console.WriteLine("Total Prce:"+tot);
            Console.WriteLine("Discount Amount:"+discount);
            Console.WriteLine("After Dsicount The total amount is:" + (tot-discountAmount));
            Console.Read();

        }
    }
}
