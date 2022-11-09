using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaHomeTask.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Trainers_TrainerId",
                table: "Abouts");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "Abouts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Trainers_TrainerId",
                table: "Abouts",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Trainers_TrainerId",
                table: "Abouts");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "Abouts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Trainers_TrainerId",
                table: "Abouts",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
