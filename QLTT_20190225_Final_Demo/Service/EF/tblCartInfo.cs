namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCartInfo")]
    public partial class tblCartInfo
    {
        [Key]
        public int CartInfoID { get; set; }

        public int? ProductID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrderID { get; set; }

        public int? Quatity { get; set; }

        public double? Price { get; set; }
    }
}
