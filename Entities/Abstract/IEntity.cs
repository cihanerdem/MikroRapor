using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime? CreateDate { get; set; }
        int CreateUser { get; set; }
        DateTime? UpdateDate { get; set; }
        int UpdateUser { get; set; }

    }
}
