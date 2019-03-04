namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrder")]
    public partial class tblOrder
    {
        public int ID { get; set; }

        public int OrderID { get; set; }

        public int MemberID { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? IsActived { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(50)]
        public string NickYahoo { get; set; }

        [StringLength(50)]
        public string NickSkype { get; set; }

        [Column(TypeName = "ntext")]
        public string Require { get; set; }
    }
}
