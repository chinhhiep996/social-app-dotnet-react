using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class LikeEntity : BaseEntity
    {
        public UserEntity User { get; set; }
        public PostEntity Post { get; set; }
    }
}
