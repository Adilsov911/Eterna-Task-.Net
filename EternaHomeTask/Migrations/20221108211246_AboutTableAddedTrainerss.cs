using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaHomeTask.Migrations
{
    public partial class AboutTableAddedTrainerss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Abouts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_TrainerId",
                table: "Abouts",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Trainers_TrainerId",
                table: "Abouts",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Trainers_TrainerId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_TrainerId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Abouts");
        }
    }
}
