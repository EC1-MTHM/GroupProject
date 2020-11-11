using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EC1_ashion.Models;

namespace EC1_ashion
{
    public partial class _Default : Page
    {
        public static String CS = ConfigurationManager.ConnectionStrings["Ashion"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["AT"] = "default";
            Bind1stCat();
            BindRestCat();
            Bindfeatured();

            BindAcess();
            //BindTrend();
            //BindSeller();
            //BindFeat();
        }
        private void Bind1stCat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CS))
                {
                    conn.Open();
                    SqlCommand cmd;
                    SqlDataReader sdr;
                    String sql1 = "";

                    sql1 = "Select * from [dbo].[Categories] where CategoryID = 1";
                    
                    cmd = new SqlCommand(sql1, conn);

                    sdr = cmd.ExecuteReader();

                    rptr1st.DataSource = sdr;
                    rptr1st.DataBind();

                    sdr.Close();
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex) { Response.Write(ex); }
        }
        private void BindRestCat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CS))
                {
                    conn.Open();
                    SqlCommand cmd;
                    SqlDataReader sdr;
                    String sql1 = "";

                    sql1 = "Select * from [dbo].[Categories] where CategoryID IN(2,3,4,5) ORDER BY NEWID();";

                    cmd = new SqlCommand(sql1, conn);

                    sdr = cmd.ExecuteReader();

                    rptrAll.DataSource = sdr;
                    rptrAll.DataBind();

                    sdr.Close();
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex) { Response.Write(ex); }
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

                    sql = "Select * from [dbo].[Products] where ProductID IN(1,13,20,4,11,24,29,33) ORDER BY NEWID();";
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
        private void BindAcess()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CS))
                {
                    conn.Open();
                    SqlCommand cmd;
                    SqlDataReader sdr;
                    String sql = "";

                    sql = "Select TOP 3* from [dbo].[Products] where Brand = 'Nike' ORDER BY NEWID();";

                    cmd = new SqlCommand(sql, conn);

                    sdr = cmd.ExecuteReader();

                    slideAccess.DataSource = sdr;
                    slideAccess.DataBind();

                    sdr.Close();
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex) { Response.Write(ex); }
        }
    }
}