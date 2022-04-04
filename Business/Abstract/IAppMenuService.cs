using Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppMenuService
    {
        Task<IEnumerable<AppenuDetailDto>> GetListAsync();
        Task<AppMenuDto> GetByIdAsync(int id);
        // Task<UserDto> GetAsync(Expression<Func<User, bool>> filter);
        Task<AppMenuDto> AddAsync(AppMenuDto menuAdd);
        Task<AppMenuDto> Updatesync(AppMenuDto menuUpdate);
        Task<bool> DeleteAsync(int id);
    }
}
