namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_SanLuongSXKD
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Ngay { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSL { get; set; }

        public decimal? GiaTri { get; set; }
    }
}
