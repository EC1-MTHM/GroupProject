using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EC1_ashion.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }
        [Required, StringLength(100), Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required, Display(Name = "Brand")]
        public string Brand { get; set; }
        [Required, StringLength(10000), Display(Name = "Product Description"),DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath1 { get; set; }
        public string ImagePath2 { get; set; }
        public string ImagePath3 { get; set; }
        public string ImagePath4 { get; set; }
        [Display(Name = "Final Price")]
        public double? UnitPrice { get; set; }
        [Display(Name = "Discount Price")]
        public double? Discount { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<JointM2M> M2Ms { get; set; }
        //public virtual ICollection<Color> Colors { get; set; }
        //public virtual ICollection<Size> Sizes { get; set; }
    }
}