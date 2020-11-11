using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EC1_ashion.Models;
using System.Web.ModelBinding;
using System.Data;
using Microsoft.EntityFrameworkCore.Internal;

namespace EC1_ashion
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["AT"] = "All Products";    
        }

        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new EC1_ashion.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new EC1_ashion.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

        protected void productList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            this.DPGProduct.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
        }
    }
}