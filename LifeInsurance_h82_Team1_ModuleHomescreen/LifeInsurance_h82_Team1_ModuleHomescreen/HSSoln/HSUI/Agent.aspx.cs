using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HSBLL;
using HSDC;




public partial class Agent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UserDetails userDetails = new UserDetails();
        userDetails.UserName = txtun.Text;
        userDetails.Password = txtpwd.Text;
        bllloginDetails blllogindetails = new bllloginDetails();
        string lastname = blllogindetails.GetUserDetails(userDetails.UserName, userDetails.Password);
       Response.Write("User is valid. Welcome " + lastname);        
        Response.Redirect(@"Register.aspx");
       Session["uname "] = userDetails.UserName;
         
        
        

    }
}


