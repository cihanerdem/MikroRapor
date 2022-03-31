using DataAccess.Abstract;
using DataAccess.Concrate.Context;
using Entities.Concrate.BaseEntities;

namespace DataAccess.Concrate.EntityFrameWork
{
    public class EFUserDal:EFBaseRepository<User, MikroRaporContext>,IUserDal
    {
    }
}
