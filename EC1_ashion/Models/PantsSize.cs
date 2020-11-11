using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EC1_ashion.Models
{
    public class PantsSize
    {
        [ScaffoldColumn(false)]
        public int PantsSizeID { get; set; }
        [Required, StringLength(100), Display(Name = "Pants Size")]
        public string PantsSizeName { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<JointM2M> M2Ms { get; set; }
    }
}