namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblShortURL")]
    public partial class tblShortURL
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string LongURL { get; set; }

        [Required]
        [StringLength(50)]
        public string ShortURL { get; set; }

        [StringLength(200)]
        public string Title { get; set; }
    }
}
