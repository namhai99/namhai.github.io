namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSinglePage")]
    public partial class tblSinglePage
    {
        [Key]
        public int SinglePageID { get; set; }

        [Required]
        [StringLength(100)]
        public string SinglePageName { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        [Column(TypeName = "ntext")]
        public string SinglePageDesc { get; set; }

        [Column(TypeName = "ntext")]
        public string SinglePageContent { get; set; }

        [StringLength(5)]
        public string Language { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }

        [StringLength(50)]
        public string CreatedUserName { get; set; }
    }
}
