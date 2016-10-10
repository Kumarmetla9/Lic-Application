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
    public class dalloginDetails
    {
        string strcon = @"Data Source=172.25.192.72;Initial Catalog=DB03H82;Persist Security Info=True;User ID=PJ03H82;Password=tcshyd";
        SqlConnection con;
        SqlCommand com;

        public  UserDetails GetUserDetails(string username, string password)
        {
            UserDetails userDetails = new UserDetails();
            con = new SqlConnection(strcon);
            con.Open();
            SqlCommand com = new SqlCommand(@"select * from HSUserDetails where UserName='" + username + "' and Password = '"+ password +"' ", con);
            SqlDataReader sqlReader = com.ExecuteReader();
            if (sqlReader.Read())
            {
                    //userDetails.FirstName = Convert.ToString(sqlReader["firstname"]);
                userDetails.MiddleName = Convert.ToString(sqlReader["MiddleName"]);
                userDetails.LastName = Convert.ToString(sqlReader["LastName"]);
                    //userDetails.EmailId = Convert.ToString(sqlReader["emailid"]);
                    //userDetails.DOB = Convert.ToDateTime(sqlReader["dob"]);
                    //userDetails.AnnualUIncome = Convert.ToInt32(sqlReader["annualuincome"]);
                    //userDetails.Address = Convert.ToString(sqlReader["address"]);
                    //userDetails.ContactNo = Convert.ToInt32(sqlReader["contactno"]);
                    //userDetails.Gender = Convert.ToString(sqlReader["gender"]);
                }

                con.Close();

                return userDetails;

            }
        }
    }

