namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOfficialFile")]
    public partial class tblOfficialFile
    {
        [Key]
        public int OfficialFileID { get; set; }

        public int OfficialID { get; set; }

        [StringLength(30)]
        public string FileName { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        public int TT_A1 { get; set; }

        public int TT_A2 { get; set; }

        public int TT_A3 { get; set; }

        public int OfficialFileID_A0 { get; set; }
    }
}
