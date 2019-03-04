namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPageComment")]
    public partial class tblPageComment
    {
        [Key]
        [Column(Order = 0)]
        public int CommentPageID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PageID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public string Content { get; set; }

        public bool? Actived { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(30)]
        public string GroupCate { get; set; }

        [StringLength(50)]
        public string ApprovalUserName { get; set; }

        public DateTime? ApprovalDate { get; set; }
    }
}
