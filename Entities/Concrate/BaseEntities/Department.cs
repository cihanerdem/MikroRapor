using System.Collections;
using System.Collections.Generic;

namespace Entities.Concrate.BaseEntities
{
    public class Department:AuditableEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
       // public virtual ICollection<User>  Users { get; set; }


    }
}
