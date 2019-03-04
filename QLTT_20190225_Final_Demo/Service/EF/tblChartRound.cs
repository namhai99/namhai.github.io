namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChartRound")]
    public partial class tblChartRound
    {
        [Key]
        public int ChartRoundID { get; set; }

        public int ChartRoundParentID { get; set; }

        [Required]
        [StringLength(250)]
        public string ChartName { get; set; }

        public int? Value { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ChartPostDate { get; set; }

        public bool? ChartStatus { get; set; }
    }
}
