using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EC1_ashion.Models
{
    public class Color
    {
        [ScaffoldColumn(false)]
        public int ColorID { get; set; }
        [Required, StringLength(100), Display(Name = "Color")]
        public string ColorName { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<JointM2M> M2Ms { get; set; }
    }
}