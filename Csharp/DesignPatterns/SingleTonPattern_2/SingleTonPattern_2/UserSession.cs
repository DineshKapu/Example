using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern_2
{
    public class UserSession
    {
        //static Private instance for Singleton

        private static readonly UserSession _userinstance = new UserSession();

        //Properties to store session Data
        public string UserName { get; private set; }
        public string[] Roles { get; private set; }

        //PrivateConstructor
        private UserSession() { }

        //public Methods
        public void Initialize(string uname,string[] roles)
        {
            UserName = uname;
            Roles = roles;
        }
        public void Clear()
        {
            UserName = null;
            Roles = null;
        }

        //public Property to access the Singleton Instance
        public static UserSession usobj => _userinstance;
    }
}
