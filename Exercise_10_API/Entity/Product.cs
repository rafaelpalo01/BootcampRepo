using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exercise_10_API.Entity
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string ItemNumber { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int Price { get; set; }
        public string Caliber { get; set; }
        public string Movement { get; set; }
        public string Chronograph { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Diameter { get; set; }
        public string Thickness { get; set; }
        public string Jewely { get; set; }
        public string CaseMaterial { get; set; }
        public string StrapMaterial { get; set; }
    }
}
