using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EC1_ashion.Models
{
    public class JointM2M
    {
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int? ColorID { get; set; }
        [Key]
        [Column(Order = 3)]
        public int? ShoeSizeID { get; set; }
        [Key]
        [Column(Order = 4)]
        public int? PantsSizeID { get; set; }
        [Key]
        [Column(Order = 5)]
        public int? TopSizeID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Color Color { get; set; }
        public virtual ShoeSize ShoeSize { get; set; }
        public virtual PantsSize PantsSize { get; set; }
        public virtual TopSize TopSize { get; set; }

        //public Product Product;
        //public Color Color;
        //public Size Size;
    }
}