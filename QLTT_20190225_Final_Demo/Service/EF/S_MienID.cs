namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_MienID
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MienID { get; set; }

        [StringLength(10)]
        public string TenMien { get; set; }

        public short? orderID { get; set; }
    }
}
