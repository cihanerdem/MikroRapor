using DataAccess.Abstract;
using DataAccess.Concrate.Context;
using Entities.Concrate.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFrameWork
{
    public class EFCategoryDal : EFBaseRepository<Category, MikroRaporContext>, ICategoryDal
    {
    }
}
