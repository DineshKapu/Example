using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteRemotingServer
{
    public class InfiniteServer : MarshalByRefObject
    {
        public string Greetings()
        {
            return "Hello Folks !! Welcome to CSharp Remoting...";
        }
    }

    //Service Class
    public class InfiniteServices:MarshalByRefObject
    {
        public int WriteData(int n1,int n2)
        {
            int maxval = (Math.Max(n1, n2));
            Console.WriteLine("Call Executed...");
            return maxval;
        }
    }
}
