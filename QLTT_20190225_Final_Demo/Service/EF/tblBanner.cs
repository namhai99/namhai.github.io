namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBanner")]
    public partial class tblBanner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBanner()
        {
            tblContactSlider = new HashSet<tblContactSlider>();
            tblTopSlider = new HashSet<tblTopSlider>();
        }

        [Key]
        public int BannerId { get; set; }

        [StringLength(300)]
        public string BannerTitle { get; set; }

        [StringLength(300)]
        public string BannerContent { get; set; }

        [StringLength(300)]
        public string ImageFullPath { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        public int BannerTypeId { get; set; }

        [StringLength(10)]
        public string ColorText { get; set; }

        [StringLength(10)]
        public string ColorBG { get; set; }

        public virtual DM_BannerType DM_BannerType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblContactSlider> tblContactSlider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTopSlider> tblTopSlider { get; set; }
    }
}
