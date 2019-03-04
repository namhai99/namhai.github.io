namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuestion")]
    public partial class tblQuestion
    {
        [Key]
        public int Question_ID { get; set; }

        public int? Question_ParentID { get; set; }

        [StringLength(250)]
        public string Question_Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Question_Content { get; set; }

        [StringLength(100)]
        public string Question_FileAttach { get; set; }

        [StringLength(100)]
        public string Question_Image { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? IsApproval { get; set; }

        [StringLength(50)]
        public string ApprovalUserName { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public int? CateNewsID { get; set; }

        public int? QuestionStatus { get; set; }

        public bool? isDelete { get; set; }

        public bool? IsPublish { get; set; }
    }
}
