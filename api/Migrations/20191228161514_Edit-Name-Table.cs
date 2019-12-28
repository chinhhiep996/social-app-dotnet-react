using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class EditNameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FollowerEntitys_Users_UserId",
                table: "FollowerEntitys");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowingEntitys_Users_UserId",
                table: "FollowingEntitys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FollowingEntitys",
                table: "FollowingEntitys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FollowerEntitys",
                table: "FollowerEntitys");

            migrationBuilder.RenameTable(
                name: "FollowingEntitys",
                newName: "Followings");

            migrationBuilder.RenameTable(
                name: "FollowerEntitys",
                newName: "Followers");

            migrationBuilder.RenameIndex(
                name: "IX_FollowingEntitys_UserId",
                table: "Followings",
                newName: "IX_Followings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FollowerEntitys_UserId",
                table: "Followers",
                newName: "IX_Followers_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Followings",
                table: "Followings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Followers",
                table: "Followers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_Users_UserId",
                table: "Followers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Followings_Users_UserId",
                table: "Followings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_Users_UserId",
                table: "Followers");

            migrationBuilder.DropForeignKey(
                name: "FK_Followings_Users_UserId",
                table: "Followings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Followings",
                table: "Followings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Followers",
                table: "Followers");

            migrationBuilder.RenameTable(
                name: "Followings",
                newName: "FollowingEntitys");

            migrationBuilder.RenameTable(
                name: "Followers",
                newName: "FollowerEntitys");

            migrationBuilder.RenameIndex(
                name: "IX_Followings_UserId",
                table: "FollowingEntitys",
                newName: "IX_FollowingEntitys_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Followers_UserId",
                table: "FollowerEntitys",
                newName: "IX_FollowerEntitys_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FollowingEntitys",
                table: "FollowingEntitys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FollowerEntitys",
                table: "FollowerEntitys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FollowerEntitys_Users_UserId",
                table: "FollowerEntitys",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowingEntitys_Users_UserId",
                table: "FollowingEntitys",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
