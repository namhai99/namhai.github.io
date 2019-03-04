namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCompany")]
    public partial class tblCompany
    {
        [Key]
        public int CompanyID { get; set; }

        public int Categories { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        public bool? IsNormal { get; set; }

        [StringLength(5)]
        public string Language { get; set; }

        public bool? IsHot { get; set; }

        public bool? IsDefault { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedUserName { get; set; }

        [StringLength(50)]
        public string ApprovalUserName { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public bool? IsComment { get; set; }

        public bool? IsApproval { get; set; }

        public int? CommentTotal { get; set; }

        public int? VisitTotal { get; set; }

        public int? GroupCate { get; set; }
    }
}
