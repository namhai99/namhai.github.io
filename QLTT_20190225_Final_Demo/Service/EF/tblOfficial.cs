namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOfficial")]
    public partial class tblOfficial
    {
        [Key]
        public int OfficialID { get; set; }

        public int? CateOfficialID { get; set; }

        [StringLength(50)]
        public string NoCode { get; set; }

        [StringLength(1000)]
        public string OfficialName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DatePublic { get; set; }

        [StringLength(200)]
        public string Company { get; set; }

        [StringLength(200)]
        public string Classify { get; set; }

        [StringLength(150)]
        public string Writer { get; set; }

        [Column(TypeName = "ntext")]
        public string Quote { get; set; }

        [StringLength(1000)]
        public string KeyShort { get; set; }

        [StringLength(250)]
        public string Attached { get; set; }

        public bool? Status { get; set; }

        public bool? IsApproval { get; set; }

        [StringLength(50)]
        public string ApprovalUserName { get; set; }

        public DateTime? ApprovalDate { get; set; }

        [StringLength(50)]
        public string CreatedUserName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int TT_A1 { get; set; }

        public int TT_A2 { get; set; }

        public int TT_A3 { get; set; }

        public int OfficialID_A0 { get; set; }
    }
}
