﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api;

namespace api.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Entities.CommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid?>("PostEntityId");

                    b.Property<Guid?>("PostedById");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("PostEntityId");

                    b.HasIndex("PostedById");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("api.Entities.FollowerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Followers");
                });

            modelBuilder.Entity("api.Entities.FollowingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Followings");
                });

            modelBuilder.Entity("api.Entities.LikeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid?>("PostId");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("api.Entities.PostEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<byte[]>("Photo");

                    b.Property<Guid?>("PostedById");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("PostedById");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("api.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("api.Entities.CommentEntity", b =>
                {
                    b.HasOne("api.Entities.PostEntity")
                        .WithMany("Comments")
                        .HasForeignKey("PostEntityId");

                    b.HasOne("api.Entities.UserEntity", "PostedBy")
                        .WithMany()
                        .HasForeignKey("PostedById");
                });

            modelBuilder.Entity("api.Entities.FollowerEntity", b =>
                {
                    b.HasOne("api.Entities.UserEntity", "User")
                        .WithMany("Followers")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("api.Entities.FollowingEntity", b =>
                {
                    b.HasOne("api.Entities.UserEntity", "User")
                        .WithMany("Followings")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("api.Entities.LikeEntity", b =>
                {
                    b.HasOne("api.Entities.PostEntity", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId");

                    b.HasOne("api.Entities.UserEntity", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("api.Entities.PostEntity", b =>
                {
                    b.HasOne("api.Entities.UserEntity", "PostedBy")
                        .WithMany()
                        .HasForeignKey("PostedById");
                });
#pragma warning restore 612, 618
        }
    }
}
