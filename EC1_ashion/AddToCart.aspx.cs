using EC1_ashion.Logic;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EC1_ashion.Errors;

namespace EC1_ashion
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["AT"] = "All Products";
            String quantity = "";
            try
            {
                if ((!string.IsNullOrEmpty(Session["quantity"] as string)))
                {
                    quantity = Session["quantity"].ToString();
                }

            }
            catch (Exception)
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a ProductId.");
                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a ProductId.");
            }

            int value;
            try
            {
                if (!int.TryParse(quantity, out value))
                {
                    //Fail parsing successful 
                    //this.Session["exceptionMessage"] = ex.Message;
                    Response.Redirect("Errors/UnauthorizedError.aspx");
                }
            }
            catch (Exception ex)
            {
                this.Session["exceptionMessage"] = ex.Message;
                Response.Redirect("Errors/UnauthorizedError.aspx");
            }


            string rawId = Request.QueryString["ProductID"];
            int productId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.send(quantity);
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
                Response.Redirect("ShoppingCart.aspx");
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without aProductId.");

                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a ProductId.");
            }
        }
    }
}