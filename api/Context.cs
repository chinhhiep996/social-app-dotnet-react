using api.Entities;
using Microsoft.EntityFrameworkCore;

namespace api
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<LikeEntity> Likes { get; set; }
        public DbSet<FollowerEntity> Followers { get; set; }
        public DbSet<FollowingEntity> Followings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
