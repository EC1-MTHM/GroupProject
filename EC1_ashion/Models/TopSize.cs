using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EC1_ashion.Models
{
    public class TopSize
    {
        [ScaffoldColumn(false)]
        public int TopSizeID { get; set; }
        [Required, StringLength(100), Display(Name = "Top Size")]
        public string TopSizeName { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<JointM2M> M2Ms { get; set; }
    }
}