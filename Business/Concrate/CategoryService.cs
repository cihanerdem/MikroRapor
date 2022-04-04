using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate.BaseEntities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDal _category;

        public CategoryService(ICategoryDal category)
        {
            _category = category;
        }

        public async Task<CategoryDto> AddAsync(CategoryDto categoryAdd)
        {
            Category app = new Category
            {
                CreateUser = 1,
                CreateDate = DateTime.Now,
                Code = categoryAdd.Code,
                Description = categoryAdd.Description,
                Id = 1,
                Name = categoryAdd.Name,

            };
            var cat = await _category.AddAsync(app);
            CategoryDto dto = new CategoryDto
            {
              Id = cat.Id,
              Code=cat.Code,
              Name=cat.Name,
              Description=cat.Description
            };
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _category.DeleteAsync(id);
        }

        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            var getCat = await _category.GetAsync(x => x.Id == id);
            CategoryDto catDto = new CategoryDto
            {
                Id = getCat.Id,
               Code=getCat.Code,
               Description=getCat.Description,
               Name=getCat.Name

            };
            return catDto;
        }

        public async Task<IEnumerable<CategoryDetailDto>> GetListAsync()
        {
            List<CategoryDetailDto> catList = new List<CategoryDetailDto>();
            var response = await _category.GetListAsync();
            foreach (var item in response.ToList())
            {
                CategoryDetailDto cat = new CategoryDetailDto
                {
                    Id = item.Id,
                    Code=item.Code,
                    CreateDate=(DateTime)item.CreateDate,
                    CreateUser=item.CreateUser,
                    Name=item.Name,
                    Description = item.Description,
                    UpdateDate=item.UpdateDate,
                    UpdateUser=item.UpdateUser

                };
                catList.Add(cat);
            }
            return catList;
        }

        public async Task<CategoryDto> Updatesync(CategoryDto categoryUpdate)
        {
            var getCat = await _category.GetAsync(x => x.Id == categoryUpdate.Id);
            Category category = new Category
            {
                CreateDate = getCat.CreateDate,
                CreateUser = getCat.CreateUser,
               Code=categoryUpdate.Code,
               Description=categoryUpdate.Description,
               Id=categoryUpdate.Id,
               Name=categoryUpdate.Name,
               UpdateDate=DateTime.Now,
               UpdateUser=1

            };
            var updateCat = await _category.UpdateAsync(category);
            CategoryDto catDto = new CategoryDto
            {
                Id = updateCat.Id,
              Code=updateCat.Code,
              Name=updateCat.Name,
              Description=updateCat.Description
             

            };
            return catDto;
        }
    }
}
