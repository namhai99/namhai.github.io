using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EF
{
    public partial class FrontPanel_News
    {        
        public int ModulesFrontPanel_ID { get; set; }

        [StringLength(300)]
        public string ModulesFrontPanel_Title { get; set; }

        public int ModulesFrontPanel_Record { get; set; }

        [StringLength(50)]
        public string ModulesFrontPanel_Value { get; set; }

        public int CateNewsID { get; set; }

        public int GroupCate { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        public DateTime ApprovalDate { get; set; }

        public Int64 rn { get; set; }

        [StringLength(50)]
        public string ImageThumb { get; set; }

        [StringLength(350)]
        public string ShortDescribe { get; set; }
        
        public int CommentTotal { get; set; }

        
    }
}
