using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using EC1_ashion.Logic;

namespace EC1_ashion
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        
        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }
        public string AT;
        protected void Page_Load(object sender, EventArgs e)
        {
            var _db = new EC1_ashion.Models.ProductContext();
            AT = Session["AT"].ToString();
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new
           ShoppingCartActions())
            {
                string cartStr = string.Format("{0}",usersShoppingCart.GetCount());
                Tp.InnerText = cartStr;
                Tp2.InnerText = cartStr;
            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {

                if (Page.IsValid)
                {/*RECIEVING THE EMAIL FROM WEB APP*/
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("EC1.1601459@gmail.com");
                    mailMessage.To.Add("EC1.1601459@gmail.com");
                    mailMessage.Subject = "Customer: " + this.email.Text;

                    mailMessage.Body = "<b>Sender Email : </b>" + email.Text + " has Subscribed";
                    mailMessage.IsBodyHtml = true;

                    /*SENDING EMAIL TO THE PERSON*/
                    String ToEmailAddress = this.email.Text;
                    String Username = "Customer";
                    String EmailBody = "Hello " + Username + ",<br/><br/>Thank You for Subscribing.<br/>You will emailed weekly on our latest and best Line<br/><br/> DO NOT REPLY TO THIS EMAIL";

                    MailMessage AutoResponse = new MailMessage("EC1.1601459@gmail.com", ToEmailAddress);

                    AutoResponse.Body = EmailBody;
                    AutoResponse.IsBodyHtml = true;
                    AutoResponse.Subject = "Thank You";

                    using (SmtpClient client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("EC1.1601459@gmail.com", "UTech.EC1");
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;

                        client.Send(mailMessage);
                        client.Send(AutoResponse);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }

}