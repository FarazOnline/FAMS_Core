using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class CurrenciesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                schema: "Foundation",
                table: "MainAccount");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyId",
                schema: "Foundation",
                table: "MainAccount",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyId = table.Column<string>(nullable: false),
                    CurrencyName = table.Column<string>(maxLength: 100, nullable: true),
                    ConvertRatio = table.Column<decimal>(nullable: true),
                    SinceWhen = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainAccount_CurrencyId",
                schema: "Foundation",
                table: "MainAccount",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainAccount_Currencies_CurrencyId",
                schema: "Foundation",
                table: "MainAccount",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainAccount_Currencies_CurrencyId",
                schema: "Foundation",
                table: "MainAccount");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropIndex(
                name: "IX_MainAccount_CurrencyId",
                schema: "Foundation",
                table: "MainAccount");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                schema: "Foundation",
                table: "MainAccount");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                schema: "Foundation",
                table: "MainAccount",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
