using Entities.Concrate.BaseEntities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<UserDetailDto>> GetListAsync();
        Task<UserDto> GetByIdAsync(int id);
       // Task<UserDto> GetAsync(Expression<Func<User, bool>> filter);
        Task<UserDto> AddAsync(UserDto userAdd);
        Task<UserDto> Updatesync(UserDto userUpdate);
        Task<bool> DeleteAsync(int id);
    }
}
