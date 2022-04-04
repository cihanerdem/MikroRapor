using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate.BaseEntities
{
    public class Category:AuditableEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
