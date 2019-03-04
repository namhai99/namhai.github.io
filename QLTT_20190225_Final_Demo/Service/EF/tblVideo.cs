namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblVideo")]
    public partial class tblVideo
    {
        [Key]
        public int VideoID { get; set; }

        [Required]
        [StringLength(50)]
        public string VideoName { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        [Column(TypeName = "ntext")]
        public string ShortDescribe { get; set; }

        [StringLength(100)]
        public string VideoUrl { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        [StringLength(5)]
        public string Language { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PostDate { get; set; }

        public bool? IsHome { get; set; }

        public bool? VideoType { get; set; }

        [StringLength(600)]
        public string VideoEmbed { get; set; }
    }
}
