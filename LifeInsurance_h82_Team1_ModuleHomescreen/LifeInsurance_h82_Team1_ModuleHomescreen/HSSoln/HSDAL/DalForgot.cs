using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HSDC;

namespace HSDAL
{
    public class DalForgot
    {
        string strcon = @"Data Source=172.25.192.72;Initial Catalog=DB03H82;Persist Security Info=True;User ID=PJ03H82;Password=tcshyd";
        SqlConnection con;
        SqlCommand com;
        public UserDetails GetUserDetails(string username, string emailid)
        {
            UserDetails userDetails = new UserDetails();
            con = new SqlConnection(strcon);
            con.Open();
            SqlCommand com = new SqlCommand(@"select * from HSUserDetails where UserName='" + username + "' and EmailId = '" + emailid + "' ", con);
            SqlDataReader sqlReader = com.ExecuteReader();
            if (sqlReader.Read())
            {
                userDetails.Password = Convert.ToString(sqlReader["Password"]);
              
            }
            con.Close();

            return userDetails;
        }
    }
}
