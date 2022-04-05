using Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetListAsync();
        Task<DepartmentDto> GetByIdAsync(int id);
        // Task<UserDto> GetAsync(Expression<Func<User, bool>> filter);
        Task<DepartmentDto> AddAsync(DepartmentDto departmentAdd);
        Task<DepartmentDto> Updatesync(DepartmentDto deparmentUpdate);
        Task<bool> DeleteAsync(int id);
    }
}
