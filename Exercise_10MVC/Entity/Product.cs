using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exercise_9.Entity
{
    public partial class Product
    {
        [DisplayName("Product Id")]
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Item Number")]
        public string ItemNumber { get; set; }
        [DisplayName("Short Description")]
        public string ShortDescription { get; set; }
        [DisplayName("Full Description")]
        public string FullDescription { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Caliber { get; set; }
        [Required]
        public string Movement { get; set; }
        [Required]
        public string Chronograph { get; set; }
        [Required]
        public string Weight { get; set; }
        [Required]
        public string Height { get; set; }
        [Required]
        public string Diameter { get; set; }
        [Required]
        public string Thickness { get; set; }
        [Required]
        public string Jewely { get; set; }
        [Required]
        [DisplayName("Case Material")]
        public string CaseMaterial { get; set; }
        [Required]
        [DisplayName("Strap Material")]
        public string StrapMaterial { get; set; }
    }
}
