using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaHomeTask.Migrations
{
    public partial class added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Searches_SearchId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Trainers_TrainerId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Abouts_AboutId",
                table: "Homes");

            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Services_ServiceId",
                table: "Homes");

            migrationBuilder.DropForeignKey(
                name: "FK_PricingServices_Offers_OfferId",
                table: "PricingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_PricingServices_Pricings_PricingId",
                table: "PricingServices");

            migrationBuilder.AlterColumn<int>(
                name: "PricingId",
                table: "PricingServices",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "PricingServices",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "Homes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AboutId",
                table: "Homes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "Blogs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SearchId",
                table: "Blogs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Searches_SearchId",
                table: "Blogs",
                column: "SearchId",
                principalTable: "Searches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Trainers_TrainerId",
                table: "Blogs",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_Abouts_AboutId",
                table: "Homes",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_Services_ServiceId",
                table: "Homes",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PricingServices_Offers_OfferId",
                table: "PricingServices",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PricingServices_Pricings_PricingId",
                table: "PricingServices",
                column: "PricingId",
                principalTable: "Pricings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Searches_SearchId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Trainers_TrainerId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Abouts_AboutId",
                table: "Homes");

            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Services_ServiceId",
                table: "Homes");

            migrationBuilder.DropForeignKey(
                name: "FK_PricingServices_Offers_OfferId",
                table: "PricingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_PricingServices_Pricings_PricingId",
                table: "PricingServices");

            migrationBuilder.AlterColumn<int>(
                name: "PricingId",
                table: "PricingServices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "PricingServices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "Homes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AboutId",
                table: "Homes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "Blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SearchId",
                table: "Blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_PricingServices_Offers_OfferId",
                table: "PricingServices",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PricingServices_Pricings_PricingId",
                table: "PricingServices",
                column: "PricingId",
                principalTable: "Pricings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
