using api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto
{
    public class UserDto : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string Password { get; set; }
    }
}
