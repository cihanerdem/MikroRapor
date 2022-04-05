using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate.BaseEntities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentDal _dep;

        public DepartmentService(IDepartmentDal dep)
        {
            _dep = dep;
        }

        public async Task<DepartmentDto> AddAsync(DepartmentDto departmentAdd)
        {
            Department app = new Department
            {
                CreateUser = 1,
                CreateDate = DateTime.Now,
                Code=departmentAdd.Code,
                Description=departmentAdd.Description,
                Name=departmentAdd.Name
                
            };
            var department = await _dep.AddAsync(app);
            DepartmentDto dto = new DepartmentDto
            {
                Code = department.Code,
                Name= department.Name,
                Id = department.Id,
                Description=department.Description
            };
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _dep.DeleteAsync(id);
        }

        public async Task<DepartmentDto> GetByIdAsync(int id)
        {
            var department = await _dep.GetAsync(x => x.Id == id);
            DepartmentDto depDto = new DepartmentDto
            {
                Id = department.Id,
                Code=department.Code,
                Description=department.Description,
                Name=department.Name

            };
            return depDto;
        }

        public async Task<IEnumerable<DepartmentDto>> GetListAsync()
        {
            List<DepartmentDto> depList = new List<DepartmentDto>();
            var response = await _dep.GetListAsync();
            foreach (var item in response.ToList())
            {
                DepartmentDto departtment = new DepartmentDto
                {
                    Id = item.Id,
                    Code=item.Code,
                    Name=item.Name,
                    Description=item.Description

                };
                depList.Add(departtment);
            }
            return depList;
        }

        public async Task<DepartmentDto> Updatesync(DepartmentDto deparmentUpdate)
        {
            var getDep = await _dep.GetAsync(x => x.Id == deparmentUpdate.Id);
            Department dep = new Department
            {
             Id=deparmentUpdate.Id,
             Description=deparmentUpdate.Description,
             Code=deparmentUpdate.Code,
             Name=deparmentUpdate.Name,
             CreateDate=getDep.CreateDate,
             CreateUser=getDep.CreateUser,
             UpdateDate=DateTime.Now,
             UpdateUser=1


            };
            var updateDep = await _dep.UpdateAsync(dep);
            DepartmentDto depDto = new DepartmentDto
            {
               Id=updateDep.Id,
               Code=updateDep.Code,
               Description=updateDep.Description,
               Name=updateDep.Name
            };
            return depDto;
        }
    }
}
