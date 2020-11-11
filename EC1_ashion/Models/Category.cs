using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EC1_ashion.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Category Description")]
        public string Description { get; set; }
        public string CategoryImagePath { get; set; }
        public int? AmountOfItems { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}