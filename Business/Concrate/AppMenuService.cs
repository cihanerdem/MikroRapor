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
    public class AppMenuService : IAppMenuService
    {
        IAppMenuDal _appMenu;

        public AppMenuService(IAppMenuDal appMenu)
        {
            _appMenu = appMenu;
        }

        public async Task<AppMenuDto> AddAsync(AppMenuDto menuAdd)
        {
            AppMenu app = new AppMenu
            {
                CreateUser = 1,
                CreateDate = DateTime.Now,
                MenuName = menuAdd.MenuName,
                AssociatedMenuId = menuAdd.AssociatedMenuId,
                CategoryId = menuAdd.CategoryId,
                Description = menuAdd.Description,
                MenuNo = menuAdd.MenuNo,
                StaffIdToAccess = menuAdd.StaffIdToAccess,
                Url = menuAdd.Url
            };
            var menu = await _appMenu.AddAsync(app);
            AppMenuDto dto = new AppMenuDto
            {
                MenuNo = menu.MenuNo,
                CategoryId = menu.CategoryId,
                AssociatedMenuId = menu.AssociatedMenuId,
                Description = menu.Description,
                MenuName = menu.MenuName,
                StaffIdToAccess = menu.StaffIdToAccess,
                Url = menu.Url,
                Id = menu.Id
            };
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _appMenu.DeleteAsync(id);
        }

        public async Task<AppMenuDto> GetByIdAsync(int id)
        {

            var app = await _appMenu.GetAsync(x => x.Id == id);
            AppMenuDto menuDto = new AppMenuDto
            {
                Id = app.Id,
                MenuNo = app.MenuNo,
                MenuName = app.MenuName,
                CategoryId = app.CategoryId,
                AssociatedMenuId = app.AssociatedMenuId,
                Description = app.Description,
                StaffIdToAccess = app.StaffIdToAccess,
                Url = app.Url

            };
            return menuDto;
        }

        public async Task<IEnumerable<AppenuDetailDto>> GetListAsync()
        {
            List<AppenuDetailDto> menuList = new List<AppenuDetailDto>();
            var response = await _appMenu.GetListAsync();
            foreach (var item in response.ToList())
            {
                AppenuDetailDto menu = new AppenuDetailDto
                {
                    Id = item.Id,
                    MenuNo = item.MenuNo,
                    CategoryId = item.CategoryId.ToString(),
                    Description = item.Description,
                    AssociatedMenuId = item.AssociatedMenuId,
                    MenuName = item.MenuName,
                    StaffIdToAccess = item.StaffIdToAccess

                };
                menuList.Add(menu);
            }
            return menuList;
        }

        public async Task<AppMenuDto> Updatesync(AppMenuDto menuUpdate)
        {
            var getMenu = await _appMenu.GetAsync(x => x.Id == menuUpdate.Id);
            AppMenu appMenu = new AppMenu
            {
                CreateDate = getMenu.CreateDate,
                CreateUser = getMenu.CreateUser,
                AssociatedMenuId = menuUpdate.AssociatedMenuId,
                CategoryId = menuUpdate.CategoryId,
                Description = menuUpdate.Description,
                Id = menuUpdate.Id,
                MenuName = menuUpdate.MenuName,
                MenuNo = menuUpdate.MenuNo,
                StaffIdToAccess = menuUpdate.StaffIdToAccess,
                UpdateDate = DateTime.Now,
                //To do: Update User Kısmı Kullanıcıya göre Değiştirilecek
                UpdateUser = 1,
                Url = menuUpdate.Url

            };
            var updateApp = await _appMenu.UpdateAsync(appMenu);
            AppMenuDto appDto = new AppMenuDto
            {
                Id = updateApp.Id,
                AssociatedMenuId = updateApp.AssociatedMenuId,
                CategoryId = updateApp.CategoryId,
                Description = updateApp.Description,
                MenuName = updateApp.MenuName,
                MenuNo = updateApp.MenuNo,
                Url = updateApp.Url,
                StaffIdToAccess = updateApp.StaffIdToAccess

            };
            return appDto;
        }
    }
}
