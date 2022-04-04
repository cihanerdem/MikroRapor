using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate.BaseEntities
{
   public class AppMenu:AuditableEntity
    {
        public int MenuNo { get; set; }
        public string StaffIdToAccess { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public int AssociatedMenuId { get; set; }
        public int CategoryId { get; set; }
        public string Url { get; set; }
    }
}
