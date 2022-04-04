using Entities.Dtos;
using System.Collections.Generic;
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
