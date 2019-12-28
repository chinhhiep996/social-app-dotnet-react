using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class CommentEntity : BaseEntity
    {
        public string Content { get; set; }
        public UserEntity PostedBy { get; set; }
    }
}
