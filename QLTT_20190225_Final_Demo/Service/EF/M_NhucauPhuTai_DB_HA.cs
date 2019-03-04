namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_NhucauPhuTai_DB_HA
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Ngay { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte STEP { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte MienID { get; set; }

        public decimal? Congsuat1 { get; set; }

        public decimal? Congsuat2 { get; set; }

        public decimal? Congsuat3 { get; set; }

        public decimal? Congsuat4 { get; set; }

        public decimal? Congsuat5 { get; set; }

        public decimal? Congsuat6 { get; set; }

        public decimal? Congsuat7 { get; set; }

        public decimal? Congsuat8 { get; set; }

        public decimal? Congsuat9 { get; set; }

        public decimal? Congsuat10 { get; set; }

        public decimal? Congsuat11 { get; set; }

        public decimal? Congsuat12 { get; set; }

        public decimal? Congsuat13 { get; set; }

        public decimal? Congsuat14 { get; set; }

        public decimal? Congsuat15 { get; set; }

        public decimal? Congsuat16 { get; set; }

        public decimal? Congsuat17 { get; set; }

        public decimal? Congsuat18 { get; set; }

        public decimal? Congsuat19 { get; set; }

        public decimal? Congsuat20 { get; set; }

        public decimal? Congsuat21 { get; set; }

        public decimal? Congsuat22 { get; set; }

        public decimal? Congsuat23 { get; set; }

        public decimal? Congsuat24 { get; set; }
    }
}
