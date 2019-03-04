namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblContactSlider")]
    public partial class tblContactSlider
    {
        [Key]
        public int ContactSliderId { get; set; }

        public int BannerId { get; set; }

        public bool Active { get; set; }

        public virtual tblBanner tblBanner { get; set; }
    }
}
