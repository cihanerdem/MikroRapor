using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public  interface IReportService
    {
        Task<IEnumerable<ReportDetailDto>> GetListAsync();
        Task<ReportDto> GetByIdAsync(int id);
        // Task<UserDto> GetAsync(Expression<Func<User, bool>> filter);
        Task<ReportDto> AddAsync(ReportDto reportAdd);
        Task<ReportDto> Updatesync(ReportDto reportUpdate);
        Task<bool> DeleteAsync(int id);
    }
}
