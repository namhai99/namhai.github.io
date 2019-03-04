namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCateProduct")]
    public partial class tblCateProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCateProduct()
        {
            tblProduct = new HashSet<tblProduct>();
        }

        [Key]
        public int CateProductID { get; set; }

        public int? ParentProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string CateProductName { get; set; }

        public int? CateProductTotal { get; set; }

        public int? CateProductOrder { get; set; }

        [StringLength(5)]
        public string Language { get; set; }

        [StringLength(30)]
        public string Icon { get; set; }

        [Column(TypeName = "ntext")]
        public string Slogan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProduct { get; set; }
    }
}
