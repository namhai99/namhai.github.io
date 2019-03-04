namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblChart24h
    {
        [Key]
        public int ChartID { get; set; }

        [Required]
        [StringLength(250)]
        public string ChartName { get; set; }

        public int? Hour_1 { get; set; }

        public int? Hour_2 { get; set; }

        public int? Hour_3 { get; set; }

        public int? Hour_4 { get; set; }

        public int? Hour_5 { get; set; }

        public int? Hour_6 { get; set; }

        public int? Hour_7 { get; set; }

        public int? Hour_8 { get; set; }

        public int? Hour_9 { get; set; }

        public int? Hour_10 { get; set; }

        public int? Hour_11 { get; set; }

        public int? Hour_12 { get; set; }

        public int? Hour_13 { get; set; }

        public int? Hour_14 { get; set; }

        public int? Hour_15 { get; set; }

        public int? Hour_16 { get; set; }

        public int? Hour_17 { get; set; }

        public int? Hour_18 { get; set; }

        public int? Hour_19 { get; set; }

        public int? Hour_20 { get; set; }

        public int? Hour_21 { get; set; }

        public int? Hour_22 { get; set; }

        public int? Hour_23 { get; set; }

        public int? Hour_24 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ChartPostDate { get; set; }

        public bool? ChartStatus { get; set; }
    }
}
