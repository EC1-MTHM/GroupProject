using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using EC1_ashion.Models;


namespace EC1_ashion
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        public static String CS = ConfigurationManager.ConnectionStrings["Ashion"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["AT"] = "All Products";
            //If the person click the link b4 the button sends a string null for error handling
            Session["quantity"] = "null";
            Bindfeatured();
        }
        public IQueryable<Product> GetProduct([QueryString("productID")] int? productId)
        {
            var _db = new EC1_ashion.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.ProductID == productId);
            }
            else
            {
                query = null;
            }
            return query;
        }
        private void Bindfeatured()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CS))
                {
                    conn.Open();
                    SqlCommand cmd;
                    SqlDataReader sdr;
                    String sql = "";

                    sql = "Select TOP 4* from [dbo].[Products] ORDER BY NEWID();";
                    //TOP 8* 
                    cmd = new SqlCommand(sql, conn);

                    sdr = cmd.ExecuteReader();

                    Featured.DataSource = sdr;
                    Featured.DataBind();

                    sdr.Close();
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex) { Response.Write(ex); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label test = (Label)productDetail.FindControl("Label1");
            TextBox quantity = (TextBox)productDetail.FindControl("quantity");
            Image I1 = (Image)productDetail.FindControl("avail");

            int value;
            //int value = Convert.ToInt32(textBox1.Text);
            try
            {
                if (int.TryParse(quantity.Text, out value))
                {
                    //parsing successful 
                    test.Text = "Available and Waiting.";
                    I1.ImageUrl = "img/Warning/correct.png";
                    I1.Style.Add("visibility", "visible");
                    Session["quantity"] = quantity.Text;
                }
                else
                {
                    //parsing failed.
                    test.Text = "Not a integer.";
                    I1.ImageUrl = "img/Warning/wrong.png";
                    I1.Style.Add("visibility", "visible");
                }
            }
            catch(Exception){
                test.Text = "Invalid";
                I1.ImageUrl = "img/Warning/wrong.png";
                I1.Style.Add("visibility", "visible");
            }
        }
    }
}