namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFaq")]
    public partial class tblFaq
    {
        [Key]
        public int FaqID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Question { get; set; }

        [Column(TypeName = "ntext")]
        public string Answer { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PostDate { get; set; }

        public bool? Status { get; set; }

        [StringLength(5)]
        public string Language { get; set; }

        public int? FaqOrder { get; set; }
    }
}
