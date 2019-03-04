namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBook")]
    public partial class tblBook
    {
        [Key]
        public int BookID { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        public int? ProductID { get; set; }

        [StringLength(50)]
        public string FromCity { get; set; }

        [StringLength(50)]
        public string FromDistrict { get; set; }

        public DateTime? FromDate { get; set; }

        [StringLength(250)]
        public string FromAddress { get; set; }

        [StringLength(50)]
        public string ToCity { get; set; }

        [StringLength(50)]
        public string ToDistrict { get; set; }

        public DateTime? ToDate { get; set; }

        [StringLength(250)]
        public string ToAddress { get; set; }

        [StringLength(250)]
        public string Road { get; set; }

        [Column(TypeName = "ntext")]
        public string Other { get; set; }

        public bool? Actived { get; set; }
    }
}
