﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
   public class UserDetailDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Department { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserRole { get; set; }
        public string UseDatabeses { get; set; }

    }
}
