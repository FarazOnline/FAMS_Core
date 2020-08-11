using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class TestingIndexName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_CategoryId",
                schema: "TestSchema",
                table: "Products",
                newName: "IX_CategoryId_Test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_CategoryId_Test",
                schema: "TestSchema",
                table: "Products",
                newName: "IX_CategoryId");
        }
    }
}
