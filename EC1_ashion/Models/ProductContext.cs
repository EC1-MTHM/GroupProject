using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.ModelBinding;

namespace EC1_ashion.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Ashion")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ShoeSize> ShoeSizes { get; set; }
        public DbSet<PantsSize> PantsSizes { get; set; }
        public DbSet<TopSize> TopSizes { get; set; }
        public DbSet<JointM2M> M2Ms { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JointM2M>()
                .HasKey(c => new { c.ColorID, c.ProductID, c.ShoeSizeID, c.PantsSizeID, c.TopSizeID });
        } */
    }
}