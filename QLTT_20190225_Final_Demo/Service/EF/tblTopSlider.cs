namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTopSlider")]
    public partial class tblTopSlider
    {
        [Key]
        public int TopSliderId { get; set; }

        public int SliderType { get; set; }

        public int? BannerId { get; set; }

        public bool Active { get; set; }

        [StringLength(50)]
        public string PhuTaiType { get; set; }

        [StringLength(50)]
        public string GiaBienType { get; set; }

        public virtual tblBanner tblBanner { get; set; }
    }
}
