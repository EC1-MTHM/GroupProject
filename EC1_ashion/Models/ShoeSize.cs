using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EC1_ashion.Models
{
    public class ShoeSize
    {
        [ScaffoldColumn(false)]
        public int ShoeSizeID { get; set; }
        [Required, StringLength(100), Display(Name = "Shoe Size")]
        public string ShoeSizeName { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<JointM2M> M2Ms { get; set; }
    }
}