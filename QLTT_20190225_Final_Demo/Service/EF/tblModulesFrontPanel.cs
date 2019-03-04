namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblModulesFrontPanel")]
    public partial class tblModulesFrontPanel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModulesFrontPanel_ID { get; set; }

        public int? ModulesFrontPanel_Parent { get; set; }

        [StringLength(250)]
        public string ModulesFrontPanel_Name { get; set; }

        [Required]
        [StringLength(250)]
        public string ModulesFrontPanel_Url { get; set; }

        public int? ModulesFrontPanel_Order { get; set; }

        [Column(TypeName = "ntext")]
        public string ModulesFrontPanel_Help { get; set; }

        [StringLength(50)]
        public string ModulesFrontPanel_Icon { get; set; }

        [StringLength(250)]
        public string ModulesFrontPanel_Title { get; set; }

        [StringLength(50)]
        public string ModulesFrontPanel_Value { get; set; }

        public int ModulesFrontPanel_Record { get; set; }

        public bool? ModulesFrontPanel_Status { get; set; }

        [StringLength(50)]
        public string ModulesFrontPanel_Panel { get; set; }

        [StringLength(20)]
        public string language { get; set; }

        [StringLength(500)]
        public string ModulesFontPanel_Content { get; set; }
    }
}
