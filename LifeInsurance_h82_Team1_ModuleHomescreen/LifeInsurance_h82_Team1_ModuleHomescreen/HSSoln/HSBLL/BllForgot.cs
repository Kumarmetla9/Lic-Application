using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSDC;
using HSDAL;

namespace HSBLL
{
    public class BllForgot
    {
        public string GetUserDetails(string userName, string emailid)
        {
            DalForgot dalforgot = new DalForgot();
            UserDetails userDetails = dalforgot.GetUserDetails(userName, emailid);
            return userDetails.Password;
        }
    }
}
