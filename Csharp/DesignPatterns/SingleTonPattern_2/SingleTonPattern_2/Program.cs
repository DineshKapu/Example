using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserSession.usobj.Initialize("Banurekha", new[] { "Admin","User"});

            //accessing the session Information
            Console.WriteLine(UserSession.usobj.UserName);
            Console.WriteLine("Roles:");
            foreach(var i in UserSession.usobj.Roles)
                Console.Write(i+" ");
            Console.WriteLine();
            //clear the session
            UserSession.usobj.Clear();
            Console.Read();
        }
    }
}
