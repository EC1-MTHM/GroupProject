using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EC1_ashion
{
    public partial class Site_Mobile : System.Web.UI.MasterPage
    {
        public string AT;
        protected void Page_Load(object sender, EventArgs e)
        {
            AT = Session["AT"].ToString();
        }
    }
}