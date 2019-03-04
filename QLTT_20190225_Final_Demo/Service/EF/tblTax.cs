namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTax")]
    public partial class tblTax
    {
        [Key]
        public int TaxID { get; set; }

        [StringLength(20)]
        public string TaxName { get; set; }

        public double? Discount { get; set; }
    }
}
