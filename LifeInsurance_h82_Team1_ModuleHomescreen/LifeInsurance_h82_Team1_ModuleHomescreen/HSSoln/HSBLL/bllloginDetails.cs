using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSDAL;
using HSDC;


namespace HSBLL
{
    public class bllloginDetails
    {
        public string GetUserDetails(string userName, string password)        
        {

            dalloginDetails dalloginDetails = new dalloginDetails();
            UserDetails userDetails = dalloginDetails.GetUserDetails(userName, password);
            return userDetails.LastName;

        }
    }
    }

