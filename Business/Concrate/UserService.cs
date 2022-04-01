using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate.BaseEntities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class UserService : IUserService
    {
        IUserDal _user;

        public UserService(IUserDal user)
        {
            _user = user;
        }

        public async  Task<UserDto> AddAsync(UserDto userAdd)
        {
            User user = new User
            {
                FirstName=userAdd.FirstName,
                LastName=userAdd.LastName,
                Email=userAdd.Email,
                Department=userAdd.Department,
                GSM=userAdd.GSM,
                Password=userAdd.Password,
                UseDatabeses=userAdd.UseDatabeses,
                UserName=userAdd.UserName,
                UserRole=userAdd.UserRole,
                //Todo :CreateDate ve Create User Düzenlenecek 
                CreateDate=DateTime.Now,
                CreateUser=1
               
            };
            var useradd = await _user.AddAsync(user);
            UserDto userDto = new UserDto
            {
                FirstName=useradd.FirstName,
                LastName=useradd.LastName,
                Department=useradd.Department,
                Email=useradd.Email,
                GSM=useradd.GSM,
                Password=useradd.Password,
                UseDatabeses=useradd.UseDatabeses,
                UserName=useradd.UserName,
                UserRole=useradd.UserRole,
                Id=useradd.Id
            };
            return userDto;
        }

        public async  Task<bool> DeleteAsync(int id)
        {
            return await _user.DeleteAsync(id);
        }

    
        public async  Task<UserDto> GetByIdAsync(int id)
        {
            var user = await _user.GetAsync(x => x.Id == id);
            UserDto userDto = new UserDto
            {
                FirstName=user.FirstName,
                LastName=user.LastName,
                Department=user.Department,
                Email=user.Email,
                GSM=user.GSM,
                Id=user.Id,
                UserName=user.UserName,
                UseDatabeses=user.UseDatabeses,
                UserRole=user.UserRole
                
            };
            return userDto;
        }

        public async  Task<IEnumerable<UserDetailDto>> GetListAsync()
        {
            List<UserDetailDto> userList = new List<UserDetailDto>();
            var response =await  _user.GetListAsync();
            foreach (var item in response.ToList())
            {
                UserDetailDto user = new UserDetailDto
                {
                    Id=item.Id,
                    Department=item.Department.ToString(),
                    FirstName=item.FirstName,
                    Email=item.Email,
                    GSM=item.GSM,
                    LastName=item.LastName,
                    UserName=item.UserName,
                    UseDatabeses=item.UseDatabeses,
                    UserRole=item.UserRole

                };
                userList.Add(user);
            }
            return userList;
        }

        public async  Task<UserDto> Updatesync(UserDto userUpdate)
        {
            var getUser = await _user.GetAsync(x => x.Id == userUpdate.Id);
            User user = new User
            {
                 Id=userUpdate.Id,
                 Department=userUpdate.Department,
                 Email=userUpdate.Email,
                 FirstName=userUpdate.FirstName,
                 GSM=userUpdate.GSM,
                 LastName=userUpdate.LastName,
                 Password=userUpdate.Password,
                 UpdateDate=DateTime.Now,
                 UpdateUser=1,
                 CreateDate=getUser.CreateDate,
                 CreateUser=getUser.CreateUser,
                 UseDatabeses=userUpdate.UseDatabeses,
                 UserName=userUpdate.UserName,
                 UserRole=userUpdate.UserRole
                 
            };
            var updateUser = await _user.UpdateAsync(user);
            UserDto userDto = new UserDto
            {
                Id = updateUser.Id,
                Department = updateUser.Department,
                Email = updateUser.Email,
                FirstName = updateUser.FirstName,
                GSM = updateUser.GSM,
                LastName = updateUser.LastName,
                Password = updateUser.Password,
                UseDatabeses = updateUser.UseDatabeses,
                UserName = updateUser.UserName,
                UserRole = updateUser.UserRole
            };
            return userDto;
        }
    }
}
