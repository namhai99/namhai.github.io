namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_SliderType
    {
        [Key]
        public int SliderTypeId { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
