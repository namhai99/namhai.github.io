namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLink")]
    public partial class tblLink
    {
        [Key]
        [Column(Order = 0)]
        public int LinkID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string LinkUrl { get; set; }

        [StringLength(50)]
        public string LinkImage { get; set; }

        public int? LinkWidth { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LinkHeight { get; set; }

        public bool? LinkStatus { get; set; }

        public int? LinkType { get; set; }
    }
}
