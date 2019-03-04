namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRSS")]
    public partial class tblRSS
    {
        [Key]
        public int RSSID { get; set; }

        [Required]
        [StringLength(50)]
        public string RSSName { get; set; }

        [StringLength(30)]
        public string Image { get; set; }

        [Column(TypeName = "ntext")]
        public string ShortDescribe { get; set; }

        [StringLength(100)]
        public string RSSUrl { get; set; }

        [StringLength(50)]
        public string Author { get; set; }
    }
}
