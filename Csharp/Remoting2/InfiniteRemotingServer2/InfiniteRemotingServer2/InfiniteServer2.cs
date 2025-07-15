using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteRemotingServer2
{
    public class InfiniteServer2:MarshalByRefObject
    {
        public int WriteData(int n1, int n2)
        {
            int minval = (Math.Min(n1, n2));
            Console.WriteLine("Call Executed...");
            return minval;
        }
    }
}
