using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS.Globals
{
    public static class UserComputerInfo
    {
        public static string winUserName = Environment.UserName;
        public static string hostName = System.Net.Dns.GetHostName();
        public static string computerName = Environment.MachineName;
        public static string domainName = Environment.UserDomainName;

    }
}
