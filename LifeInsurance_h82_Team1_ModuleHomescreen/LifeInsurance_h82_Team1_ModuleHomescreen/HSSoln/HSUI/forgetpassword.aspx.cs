using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HSBLL;
using HSDC;
using System.Net.Mail;

public partial class forgetpassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UserDetails userDetails = new UserDetails();
        userDetails.UserName = txtun.Text;
        userDetails.EmailId = txtEmail.Text;       
        BllForgot bllforgot = new BllForgot();
        string Password = bllforgot.GetUserDetails(userDetails.UserName, userDetails.EmailId);
         
            try
            {
                MailMessage m = new MailMessage();
                m.To.Add(new MailAddress( txtEmail.Text));
                m.From = new MailAddress("sekhar.manne@tcs.com");
                m.Subject = "Password Recovery";
                m.IsBodyHtml = true;
                m.Body = "Dear User,<br/>Please use the following password to login.<p/>Password : " + Password + "<p/>WebMaster<br/>AbcPolicies.Com";
                SmtpClient smtp = new SmtpClient("server name");
                smtp.Send(m);
                Response.Redirect( "Sent a mail with your login details. Please use those details to login!");
            }
            catch (Exception ex)
            {
               Response.Redirect ( "Sorry! Unable to send mail!");
            }

    //     using (MailMessage mailMessage = new MailMessage())
    //{
    //    mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["UserName"]);
    //    mailMessage.Subject = subject;
    //    mailMessage.Body = body;
    //    mailMessage.IsBodyHtml = true;
    //    mailMessage.To.Add(new MailAddress(recepientEmail));
    //    SmtpClient smtp = new SmtpClient();
    //    smtp.Host = ConfigurationManager.AppSettings["Host"];
    //    smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
    //    System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
    //    NetworkCred.UserName = ConfigurationManager.AppSettings["UserName"];
    //    NetworkCred.Password = ConfigurationManager.AppSettings["Password"];
    //    smtp.UseDefaultCredentials = true;
    //    smtp.Credentials = NetworkCred;
    //    smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
    //    smtp.Send(mailMessage);
    //}
        }
    }
        
    