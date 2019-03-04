namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_BannerType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_BannerType()
        {
            tblBanner = new HashSet<tblBanner>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Height { get; set; }

        [Required]
        [StringLength(50)]
        public string Width { get; set; }

        public int MaxSize { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBanner> tblBanner { get; set; }
    }
}
