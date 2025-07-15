using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using InfiniteRemotingServer2;

namespace InfiniteServicesHost2
{
    class Server2
    {
        static void Main(string[] args)
        {
            //create a new channel
            //HttpChannel c = new HttpChannel(83);
            TcpChannel t = new TcpChannel(101);

            //register the channel
            ChannelServices.RegisterChannel(t);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(InfiniteServer2),
                "OurRemoteService1", WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services Started at Port No. 101...");
            Console.WriteLine("Press any key to stop the Server...");
            Console.Read();
        }
    }
}
