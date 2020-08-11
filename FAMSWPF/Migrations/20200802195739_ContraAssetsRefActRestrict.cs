using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class ContraAssetsRefActRestrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiquidSecurity_MainAccount_MainAccount",
                schema: "Assets",
                table: "LiquidSecurity");

            migrationBuilder.DropIndex(
                name: "IX_AccountsNatures",
                schema: "Foundation",
                table: "AccountNature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LiquidSecurity",
                schema: "Assets",
                table: "LiquidSecurity");

            migrationBuilder.EnsureSchema(
                name: "AssetsContra");

            migrationBuilder.RenameTable(
                name: "LiquidSecurity",
                schema: "Assets",
                newName: "LiquidSecurities",
                newSchema: "Assets");

            migrationBuilder.RenameIndex(
                name: "IX_LiquidSecurity_MainAccount",
                schema: "Assets",
                table: "LiquidSecurities",
                newName: "IX_LiquidSecurities_MainAccount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LiquidSecurities",
                schema: "Assets",
                table: "LiquidSecurities",
                column: "SecurityId");

            migrationBuilder.CreateTable(
                name: "AdvancesX",
                schema: "AssetsContra",
                columns: table => new
                {
                    AdvXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAdvance = table.Column<int>(nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancesX", x => x.AdvXId);
                    table.ForeignKey(
                        name: "FK_AdvancesX_MainAcc_MainAcc",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_AdvancesX_Advances_MainAdv",
                        column: x => x.MainAdvance,
                        principalSchema: "Assets",
                        principalTable: "Advances",
                        principalColumn: "AdvanceId");
                });

            migrationBuilder.CreateTable(
                name: "DebtorsX",
                schema: "AssetsContra",
                columns: table => new
                {
                    DrXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainDebtor = table.Column<int>(nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtorsX", x => x.DrXId);
                    table.ForeignKey(
                        name: "FK_DebtorsX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_DebtorsX_Debtors_MainDebtor",
                        column: x => x.MainDebtor,
                        principalSchema: "Assets",
                        principalTable: "Debtors",
                        principalColumn: "DebtorId");
                });

            migrationBuilder.CreateTable(
                name: "LiquidSecuritiesX",
                schema: "AssetsContra",
                columns: table => new
                {
                    SecXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainSecurity = table.Column<int>(nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiquidSecuritiesX", x => x.SecXId);
                    table.ForeignKey(
                        name: "FK_LiquidSecuritiesX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_LiquidSecuritiesX_LiquidSecurities_MainSecurity",
                        column: x => x.MainSecurity,
                        principalSchema: "Assets",
                        principalTable: "LiquidSecurities",
                        principalColumn: "SecurityId");
                });

            migrationBuilder.CreateTable(
                name: "NonCurrrentX",
                schema: "AssetsContra",
                columns: table => new
                {
                    NCAXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAsset = table.Column<int>(nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonCurrrentX", x => x.NCAXId);
                    table.ForeignKey(
                        name: "FK_NonCurrrentX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_NonCurrrentX_MainAccount_MainAsset",
                        column: x => x.MainAsset,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateTable(
                name: "OtherCurrentX",
                schema: "AssetsContra",
                columns: table => new
                {
                    OCAXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAsset = table.Column<int>(nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherCurrentX", x => x.OCAXId);
                    table.ForeignKey(
                        name: "FK_OtherCurrentX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_OtherCurrentX_MainAccount_MainAsset",
                        column: x => x.MainAsset,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountsNatures",
                schema: "Foundation",
                table: "AccountNature",
                column: "NatureName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceX_MainAcc",
                schema: "AssetsContra",
                table: "AdvancesX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceX_MainAdv",
                schema: "AssetsContra",
                table: "AdvancesX",
                column: "MainAdvance",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebtorsX_MainAcc",
                schema: "AssetsContra",
                table: "DebtorsX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebtorsX_MainDebt",
                schema: "AssetsContra",
                table: "DebtorsX",
                column: "MainDebtor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LiqSecX_MainAcc",
                schema: "AssetsContra",
                table: "LiquidSecuritiesX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LiqSecX_MainSec",
                schema: "AssetsContra",
                table: "LiquidSecuritiesX",
                column: "MainSecurity",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NCAX_MainAcc",
                schema: "AssetsContra",
                table: "NonCurrrentX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NCAX_MainAsset",
                schema: "AssetsContra",
                table: "NonCurrrentX",
                column: "MainAsset",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OCAX_MainAcc",
                schema: "AssetsContra",
                table: "OtherCurrentX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OCAX_MainAsset",
                schema: "AssetsContra",
                table: "OtherCurrentX",
                column: "MainAsset",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LiquidSecurities_MainAccount_MainAccount",
                schema: "Assets",
                table: "LiquidSecurities",
                column: "MainAccount",
                principalSchema: "Foundation",
                principalTable: "MainAccount",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiquidSecurities_MainAccount_MainAccount",
                schema: "Assets",
                table: "LiquidSecurities");

            migrationBuilder.DropTable(
                name: "AdvancesX",
                schema: "AssetsContra");

            migrationBuilder.DropTable(
                name: "DebtorsX",
                schema: "AssetsContra");

            migrationBuilder.DropTable(
                name: "LiquidSecuritiesX",
                schema: "AssetsContra");

            migrationBuilder.DropTable(
                name: "NonCurrrentX",
                schema: "AssetsContra");

            migrationBuilder.DropTable(
                name: "OtherCurrentX",
                schema: "AssetsContra");

            migrationBuilder.DropIndex(
                name: "IX_AccountsNatures",
                schema: "Foundation",
                table: "AccountNature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LiquidSecurities",
                schema: "Assets",
                table: "LiquidSecurities");

            migrationBuilder.RenameTable(
                name: "LiquidSecurities",
                schema: "Assets",
                newName: "LiquidSecurity",
                newSchema: "Assets");

            migrationBuilder.RenameIndex(
                name: "IX_LiquidSecurities_MainAccount",
                schema: "Assets",
                table: "LiquidSecurity",
                newName: "IX_LiquidSecurity_MainAccount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LiquidSecurity",
                schema: "Assets",
                table: "LiquidSecurity",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsNatures",
                schema: "Foundation",
                table: "AccountNature",
                column: "NatureName");

            migrationBuilder.AddForeignKey(
                name: "FK_LiquidSecurity_MainAccount_MainAccount",
                schema: "Assets",
                table: "LiquidSecurity",
                column: "MainAccount",
                principalSchema: "Foundation",
                principalTable: "MainAccount",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
