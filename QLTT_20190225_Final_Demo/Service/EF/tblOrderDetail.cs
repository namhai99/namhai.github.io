namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderDetail")]
    public partial class tblOrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }

        public int? OrderID { get; set; }

        public int ProductID { get; set; }

        public double Price { get; set; }

        public int Quatity { get; set; }
    }
}
