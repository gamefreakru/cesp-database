using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class UpdatePrices2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prices_cources_CourseDtoId",
                table: "prices");

            migrationBuilder.DropColumn(
                name: "CourseDtoId",
                table: "prices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseDtoId",
                table: "prices",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_prices_cources_CourseDtoId",
                table: "prices",
                column: "CourseDtoId",
                principalTable: "cources",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
