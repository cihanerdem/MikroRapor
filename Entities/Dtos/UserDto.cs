using Entities.Abstract;
using System;

namespace Entities.Dtos
{
    public class UserDto:IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Department { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserRole { get; set; }
        public string UseDatabeses { get; set; }

        public string Token { get; set; }
        public DateTime? TokenExpireDate { get; set; }
    }
}
