using System;

namespace Entities.Concrate.BaseEntities
{
    public class User : AuditableEntity
    {
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
