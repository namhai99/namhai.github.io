namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMenuLinks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuLinksID { get; set; }

        public int? MenuLinksParent { get; set; }

        [StringLength(250)]
        public string MenuLinksName { get; set; }

        [Required]
        [StringLength(250)]
        public string MenuLinksUrl { get; set; }

        public int? MenuLinksOrder { get; set; }

        [Column(TypeName = "ntext")]
        public string MenuLinksHelp { get; set; }

        [StringLength(50)]
        public string MenuLinksIcon { get; set; }

        public bool? Status { get; set; }

        public bool? isView { get; set; }

        [StringLength(15)]
        public string Target { get; set; }
    }
}
