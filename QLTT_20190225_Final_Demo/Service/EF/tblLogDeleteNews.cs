namespace Service.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblLogDeleteNews
    {
        public int ID { get; set; }

        public int NewsGroupID { get; set; }

        public int TT_A1 { get; set; }

        public int TT_A2 { get; set; }

        public int TT_A3 { get; set; }

        public int? CateNewsID { get; set; }
    }
}
