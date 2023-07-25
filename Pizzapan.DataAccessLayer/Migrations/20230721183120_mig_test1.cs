using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzapan.DataAccessLayer.Migrations
{
    public partial class mig_test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_ContactUs_ContactUsID",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_ContactUsID",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "ContactUsID",
                table: "SocialMedias");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ContactUs");

            migrationBuilder.AddColumn<int>(
                name: "ContactUsID",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_ContactUsID",
                table: "SocialMedias",
                column: "ContactUsID");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_ContactUs_ContactUsID",
                table: "SocialMedias",
                column: "ContactUsID",
                principalTable: "ContactUs",
                principalColumn: "ContactUsID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
