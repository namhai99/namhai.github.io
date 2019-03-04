namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCateNews
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCateNews()
        {
            tblNews = new HashSet<tblNews>();
            tblNewsGroup = new HashSet<tblNewsGroup>();
        }

        [Key]
        public int CateNewsID { get; set; }

        public int? ParentNewsID { get; set; }

        [Required]
        [StringLength(200)]
        public string CateNewsName { get; set; }

        public int? CateNewsTotal { get; set; }

        public int? CateNewsOrder { get; set; }

        [StringLength(5)]
        public string Language { get; set; }

        public int? GroupCate { get; set; }

        [StringLength(30)]
        public string Icon { get; set; }

        [StringLength(200)]
        public string Slogan { get; set; }

        [StringLength(1000)]
        public string Roles { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        public bool? IsUrl { get; set; }

        [StringLength(30)]
        public string Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNews> tblNews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNewsGroup> tblNewsGroup { get; set; }
    }
}
