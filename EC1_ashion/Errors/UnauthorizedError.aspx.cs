using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EC1_ashion;

namespace EC1_ashion.Errors
{
    public partial class UnauthorizedError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Ex = "";
            if (!string.IsNullOrEmpty(Session["quantity"] as string))
            {
                Ex = Session["exceptionMessage"].ToString();
                Label1.Text = Ex;
            }
            else
            {
                Label1.Text = "Second error message";
            }


            //Set up 405 page! 
        }
    }
}