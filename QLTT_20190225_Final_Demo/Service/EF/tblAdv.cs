namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAdv")]
    public partial class tblAdv
    {
        [Key]
        public int AdvID { get; set; }

        [Required]
        [StringLength(150)]
        public string AdvUrl { get; set; }

        [StringLength(30)]
        public string AdvImage { get; set; }

        public int? AdvWidth { get; set; }

        public int? AdvHeight { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AdvPostDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AdvEndDate { get; set; }

        public bool? AdvStatus { get; set; }
    }
}
