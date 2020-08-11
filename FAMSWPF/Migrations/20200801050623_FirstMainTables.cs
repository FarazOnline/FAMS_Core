using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class FirstMainTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Foundation");

            migrationBuilder.CreateTable(
                name: "AccountNature",
                schema: "Foundation",
                columns: table => new
                {
                    NatureId = table.Column<string>(maxLength: 10, nullable: false),
                    NatureName = table.Column<string>(maxLength: 150, nullable: false),
                    DebitNatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountNature", x => x.NatureId);
                });

            migrationBuilder.CreateTable(
                name: "MainAccount",
                schema: "Foundation",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTitle = table.Column<string>(maxLength: 200, nullable: false),
                    NatureId = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainAccount", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_MainAccount_AccountNature_NatureId",
                        column: x => x.NatureId,
                        principalSchema: "Foundation",
                        principalTable: "AccountNature",
                        principalColumn: "NatureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainAccount_NatureId",
                schema: "Foundation",
                table: "MainAccount",
                column: "NatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainAccount",
                schema: "Foundation");

            migrationBuilder.DropTable(
                name: "AccountNature",
                schema: "Foundation");
        }
    }
}
