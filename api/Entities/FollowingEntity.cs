using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class FollowingEntity : BaseEntity
    {
        public UserEntity User { get; set; }
    }
}
