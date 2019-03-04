namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_SanLuongSXKD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSL { get; set; }

        [StringLength(200)]
        public string TenSanLuong { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }
    }
}
