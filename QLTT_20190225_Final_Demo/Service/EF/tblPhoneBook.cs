namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPhoneBook")]
    public partial class tblPhoneBook
    {
        public int id { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Phone1 { get; set; }

        [StringLength(500)]
        public string address { get; set; }

        [StringLength(500)]
        public string Phone2 { get; set; }

        [StringLength(15)]
        public string HomePhone { get; set; }

        [StringLength(15)]
        public string officephone { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreatorId { get; set; }

        public bool? CheckParent { get; set; }

        public int? ParentId { get; set; }

        public int? Orders { get; set; }
    }
}
