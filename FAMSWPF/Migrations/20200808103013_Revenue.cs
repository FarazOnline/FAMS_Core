using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class Revenue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "RevenueContra");

            migrationBuilder.EnsureSchema(
                name: "Revenue");

            migrationBuilder.CreateTable(
                name: "MainRevenue",
                schema: "Revenue",
                columns: table => new
                {
                    RevId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevenueScheme = table.Column<string>(maxLength: 50, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainRevenue", x => x.RevId);
                    table.ForeignKey(
                        name: "FK_MainRevenue_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherRevenue",
                schema: "Revenue",
                columns: table => new
                {
                    RevId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevScheme = table.Column<string>(maxLength: 50, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherRevenue", x => x.RevId);
                    table.ForeignKey(
                        name: "FK_OtherRevenue_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainRevenueX",
                schema: "RevenueContra",
                columns: table => new
                {
                    RevXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccount = table.Column<int>(nullable: false),
                    MainRevenue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainRevenueX", x => x.RevXId);
                    table.ForeignKey(
                        name: "FK_MainRevenueX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_MainRevenueX_MainRevenue_MainRevenue",
                        column: x => x.MainRevenue,
                        principalSchema: "Revenue",
                        principalTable: "MainRevenue",
                        principalColumn: "RevId");
                });

            migrationBuilder.CreateTable(
                name: "OtherRevenueX",
                schema: "RevenueContra",
                columns: table => new
                {
                    RevXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccount = table.Column<int>(nullable: false),
                    MainRevenue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherRevenueX", x => x.RevXId);
                    table.ForeignKey(
                        name: "FK_OtherRevenueX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_OtherRevenueX_OtherRevenue_MainRevenue",
                        column: x => x.MainRevenue,
                        principalSchema: "Revenue",
                        principalTable: "OtherRevenue",
                        principalColumn: "RevId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainRevenue_MainAccount",
                schema: "Revenue",
                table: "MainRevenue",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherRevenue_MainAccount",
                schema: "Revenue",
                table: "OtherRevenue",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainRevX_MainAcc",
                schema: "RevenueContra",
                table: "MainRevenueX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainRevX_Revenue",
                schema: "RevenueContra",
                table: "MainRevenueX",
                column: "MainRevenue",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherRevX_MainAcc",
                schema: "RevenueContra",
                table: "OtherRevenueX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherRevX_Revenue",
                schema: "RevenueContra",
                table: "OtherRevenueX",
                column: "MainRevenue",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainRevenueX",
                schema: "RevenueContra");

            migrationBuilder.DropTable(
                name: "OtherRevenueX",
                schema: "RevenueContra");

            migrationBuilder.DropTable(
                name: "MainRevenue",
                schema: "Revenue");

            migrationBuilder.DropTable(
                name: "OtherRevenue",
                schema: "Revenue");
        }
    }
}
