using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    public partial class AddPartners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "partners",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    sysname = table.Column<string>(maxLength: 256, nullable: false),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    url = table.Column<string>(maxLength: 256, nullable: true),
                    info = table.Column<string>(nullable: true),
                    email = table.Column<string>(maxLength: 256, nullable: true),
                    address = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    socnet = table.Column<string>(nullable: true),
                    photo_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partners", x => x.id);
                    table.ForeignKey(
                        name: "partner_file_fk",
                        column: x => x.photo_id,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "partner_files",
                columns: table => new
                {
                    partner_id = table.Column<int>(nullable: false),
                    file_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partner_files", x => new { x.file_id, x.partner_id });
                    table.ForeignKey(
                        name: "partner_file_file_fk",
                        column: x => x.file_id,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "partner_file_partner_fk",
                        column: x => x.partner_id,
                        principalTable: "partners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_partner_files_partner_id",
                table: "partner_files",
                column: "partner_id");

            migrationBuilder.CreateIndex(
                name: "IX_partners_photo_id",
                table: "partners",
                column: "photo_id");

            migrationBuilder.CreateIndex(
                name: "IX_partners_sysname",
                table: "partners",
                column: "sysname",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "partner_files");

            migrationBuilder.DropTable(
                name: "partners");
        }
    }
}
