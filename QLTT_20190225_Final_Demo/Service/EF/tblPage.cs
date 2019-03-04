namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPage")]
    public partial class tblPage
    {
        [Key]
        public int PageID { get; set; }

        [Required]
        [StringLength(100)]
        public string PageName { get; set; }

        public int? ParentPageID { get; set; }

        [Required]
        [StringLength(200)]
        public string PageTitle { get; set; }

        public bool PageType { get; set; }

        [StringLength(100)]
        public string Imagethumb { get; set; }

        [Column(TypeName = "ntext")]
        public string Describe { get; set; }

        [Column(TypeName = "ntext")]
        public string PageContent { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PostDate { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        public bool Status { get; set; }

        [Required]
        [StringLength(5)]
        public string Language { get; set; }

        [StringLength(30)]
        public string Icon { get; set; }

        public bool? IsView { get; set; }

        public bool? IsComment { get; set; }

        [StringLength(50)]
        public string CreatedUserName { get; set; }

        [StringLength(50)]
        public string ApprovalUserName { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public bool? IsApproval { get; set; }

        public int? CommentTotal { get; set; }

        public int? VisitTotal { get; set; }
    }
}
