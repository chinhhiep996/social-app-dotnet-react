
using System;
using System.Collections.Generic;

namespace api.Entities
{
    public class UserEntity : BaseEntity
    {
        public UserEntity()
        {
            Followings = new List<FollowingEntity>();
            Followers = new List<FollowerEntity>();

        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public ICollection<FollowingEntity> Followings { get; set; }
        public ICollection<FollowerEntity> Followers { get; set; }
        public ICollection<LikeEntity> Likes { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
