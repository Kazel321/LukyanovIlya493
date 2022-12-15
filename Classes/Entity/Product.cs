namespace PerfumeWorld.Classes.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(100)]
        public string ProductArticle { get; set; }

        [Required]
        public string ProductName { get; set; }

        public int UnitId { get; set; }

        public double ProductCost { get; set; }

        public int ProductMaxSale { get; set; }

        public int ManufacturerId { get; set; }

        public int ProviderId { get; set; }

        public int CategoryId { get; set; }

        public int ProductSale { get; set; }

        public int ProductCount { get; set; }

        public string ProductDescription { get; set; }

        public string ProductPhoto { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Provider Provider { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
