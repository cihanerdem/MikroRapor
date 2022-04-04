using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate.BaseEntities
{
    public class ReportSource:AuditableEntity
    {
        public string ReportCode { get; set; }
        public int ReportNumber { get; set; }
        public int CategoryId { get; set; }
        public string ReportName { get; set; }
        public byte[] SourceCode { get; set; }
        public int MenuId { get; set; }
        public string UserToAccess { get; set; }


    }
}
