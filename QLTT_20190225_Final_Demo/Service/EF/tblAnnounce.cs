namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAnnounce")]
    public partial class tblAnnounce
    {
        [Key]
        public int AnnounceID { get; set; }

        public int CateAnnounceID { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string ShortDescribe { get; set; }

        [Column(TypeName = "ntext")]
        public string FullDescribe { get; set; }

        [StringLength(50)]
        public string ImageThumb { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        [StringLength(30)]
        public string Author { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PostDate { get; set; }

        public int? RelationTotal { get; set; }

        public bool? Status { get; set; }

        [StringLength(5)]
        public string Language { get; set; }

        public bool? Ishot { get; set; }

        public int? Isview { get; set; }

        public bool? Ishome { get; set; }

        public bool? IsComment { get; set; }

        public bool? IsApproval { get; set; }

        [StringLength(50)]
        public string ApprovalUserName { get; set; }

        public DateTime? ApprovalDate { get; set; }

        [StringLength(50)]
        public string CreatedUserName { get; set; }

        public int? CommentTotal { get; set; }
    }
}
