namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblModules
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Modules_ID { get; set; }

        public int? Modules_Parent { get; set; }

        [StringLength(250)]
        public string Modules_Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Modules_Url { get; set; }

        public int? Modules_Order { get; set; }

        [Column(TypeName = "ntext")]
        public string Modules_Help { get; set; }

        [StringLength(50)]
        public string Modules_Icon { get; set; }
    }
}
