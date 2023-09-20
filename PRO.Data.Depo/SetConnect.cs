using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Data.Depo
{
    public class SetConnect
    {
        public static void SetProperties(string _str)
        {
            Properties.Settings.Default["PROConnectionString"] = _str;
            Properties.Settings.Default["PROConnectionString1"] = _str; 
        }
    }
}
