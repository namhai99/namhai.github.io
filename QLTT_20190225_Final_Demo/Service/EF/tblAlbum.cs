namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAlbum")]
    public partial class tblAlbum
    {
        [Key]
        public int AlbumID { get; set; }

        public int? CateNewsID { get; set; }

        [StringLength(30)]
        public string ImageThumb { get; set; }

        [StringLength(30)]
        public string ImageLarge { get; set; }

        public bool? IsHome { get; set; }

        public int? Order { get; set; }
    }
}
