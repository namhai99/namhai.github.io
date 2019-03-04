namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRelation")]
    public partial class tblRelation
    {
        [Key]
        public int RelationID { get; set; }

        public int NewsID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string ShortDescribe { get; set; }

        [Column(TypeName = "ntext")]
        public string FullDescribe { get; set; }

        [StringLength(50)]
        public string ImageThumb { get; set; }

        [StringLength(50)]
        public string ImageLarge { get; set; }

        [StringLength(30)]
        public string Author { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PostDate { get; set; }

        public bool? Status { get; set; }

        [StringLength(5)]
        public string Language { get; set; }

        public virtual tblNews tblNews { get; set; }
    }
}
