using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class NewStrategy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainAccount_Currencies_CurrencyId",
                schema: "Foundation",
                table: "MainAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_MainAccount_AccountNature_NatureId",
                schema: "Foundation",
                table: "MainAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "DebitNatured",
                schema: "Foundation",
                table: "AccountNature");

            migrationBuilder.EnsureSchema(
                name: "Assets");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currency",
                newSchema: "Foundation");

            migrationBuilder.AlterColumn<string>(
                name: "NatureId",
                schema: "Foundation",
                table: "MainAccount",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                schema: "Foundation",
                table: "MainAccount",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyId",
                schema: "Foundation",
                table: "MainAccount",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DebitNature",
                schema: "Foundation",
                table: "AccountNature",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyName",
                schema: "Foundation",
                table: "Currency",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ConvertRatio",
                schema: "Foundation",
                table: "Currency",
                type: "numeric(18, 9)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyId",
                schema: "Foundation",
                table: "Currency",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currency",
                schema: "Foundation",
                table: "Currency",
                column: "CurrencyId");

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                schema: "Assets",
                columns: table => new
                {
                    BankId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNo = table.Column<string>(maxLength: 50, nullable: false),
                    BankName = table.Column<string>(maxLength: 50, nullable: false),
                    BankBranch = table.Column<string>(maxLength: 50, nullable: false),
                    AccountType = table.Column<string>(maxLength: 30, nullable: false),
                    AccOpenDt = table.Column<DateTime>(nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.BankId);
                    table.ForeignKey(
                        name: "FK_BankAccounts_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CashAccounts",
                schema: "Assets",
                columns: table => new
                {
                    CashId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashAccounts", x => x.CashId);
                    table.ForeignKey(
                        name: "FK_CashAccounts_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_MainAccount",
                schema: "Assets",
                table: "BankAccounts",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CashAccounts_MainAccount",
                schema: "Assets",
                table: "CashAccounts",
                column: "MainAccount",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MainAccount_Currency_CurrencyId",
                schema: "Foundation",
                table: "MainAccount",
                column: "CurrencyId",
                principalSchema: "Foundation",
                principalTable: "Currency",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MainAccount_AccountNature_NatureId",
                schema: "Foundation",
                table: "MainAccount",
                column: "NatureId",
                principalSchema: "Foundation",
                principalTable: "AccountNature",
                principalColumn: "NatureId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainAccount_Currency_CurrencyId",
                schema: "Foundation",
                table: "MainAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_MainAccount_AccountNature_NatureId",
                schema: "Foundation",
                table: "MainAccount");

            migrationBuilder.DropTable(
                name: "BankAccounts",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "CashAccounts",
                schema: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currency",
                schema: "Foundation",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "DebitNature",
                schema: "Foundation",
                table: "AccountNature");

            migrationBuilder.RenameTable(
                name: "Currency",
                schema: "Foundation",
                newName: "Currencies");

            migrationBuilder.AlterColumn<string>(
                name: "NatureId",
                schema: "Foundation",
                table: "MainAccount",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                schema: "Foundation",
                table: "MainAccount",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyId",
                schema: "Foundation",
                table: "MainAccount",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AddColumn<bool>(
                name: "DebitNatured",
                schema: "Foundation",
                table: "AccountNature",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyName",
                table: "Currencies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "ConvertRatio",
                table: "Currencies",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(18, 9)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyId",
                table: "Currencies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainAccount_Currencies_CurrencyId",
                schema: "Foundation",
                table: "MainAccount",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MainAccount_AccountNature_NatureId",
                schema: "Foundation",
                table: "MainAccount",
                column: "NatureId",
                principalSchema: "Foundation",
                principalTable: "AccountNature",
                principalColumn: "NatureId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
