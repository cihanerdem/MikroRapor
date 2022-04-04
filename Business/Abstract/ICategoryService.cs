using Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDetailDto>> GetListAsync();
        Task<CategoryDto> GetByIdAsync(int id);
        // Task<UserDto> GetAsync(Expression<Func<User, bool>> filter);
        Task<CategoryDto> AddAsync(CategoryDto categoryAdd);
        Task<CategoryDto> Updatesync(CategoryDto categoryUpdate);
        Task<bool> DeleteAsync(int id);
    }
}
