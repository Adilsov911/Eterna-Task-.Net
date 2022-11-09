using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaHomeTask.Migrations
{
    public partial class HomeTableAddedAboutAndService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Homes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Homes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Homes_AboutId",
                table: "Homes",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_ServiceId",
                table: "Homes",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_Abouts_AboutId",
                table: "Homes",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_Services_ServiceId",
                table: "Homes",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Abouts_AboutId",
                table: "Homes");

            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Services_ServiceId",
                table: "Homes");

            migrationBuilder.DropIndex(
                name: "IX_Homes_AboutId",
                table: "Homes");

            migrationBuilder.DropIndex(
                name: "IX_Homes_ServiceId",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Homes");
        }
    }
}
