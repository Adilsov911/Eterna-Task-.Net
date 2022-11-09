using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaHomeTask.Migrations
{
    public partial class BlogTableAddedSearchAndTrainers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SearchId",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_SearchId",
                table: "Blogs",
                column: "SearchId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_TrainerId",
                table: "Blogs",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Searches_SearchId",
                table: "Blogs",
                column: "SearchId",
                principalTable: "Searches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Trainers_TrainerId",
                table: "Blogs",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Searches_SearchId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Trainers_TrainerId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_SearchId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_TrainerId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "SearchId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Blogs");
        }
    }
}
