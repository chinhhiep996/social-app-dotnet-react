using System.Collections.Generic;

namespace api.Entities
{
    public class PostEntity : BaseEntity
    {
        public string Content { get; set; }
        public byte[] Photo { get; set; }
        public ICollection<LikeEntity> Likes { get; set; }
        public ICollection<CommentEntity> Comments { get; set; }
        public UserEntity PostedBy { get; set; }
    }
}
