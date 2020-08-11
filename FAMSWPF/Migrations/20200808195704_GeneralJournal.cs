using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class GeneralJournal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Transactions");

            migrationBuilder.CreateTable(
                name: "GeneralJournal",
                schema: "Transactions",
                columns: table => new
                {
                    GenTranxId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    TranxDate = table.Column<DateTime>(nullable: false),
                    Details = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralJournal", x => x.GenTranxId);
                });

            migrationBuilder.CreateTable(
                name: "GJ_Item",
                schema: "Transactions",
                columns: table => new
                {
                    GTAccId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccount = table.Column<int>(nullable: false),
                    DrCr = table.Column<string>(maxLength: 10, nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    MainTranx = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GJ_Item", x => x.GTAccId);
                    table.ForeignKey(
                        name: "FK_GJ_Item_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GJ_Item_GeneralJournal_MainTranx",
                        column: x => x.MainTranx,
                        principalSchema: "Transactions",
                        principalTable: "GeneralJournal",
                        principalColumn: "GenTranxId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GJ_Item_MainAccount",
                schema: "Transactions",
                table: "GJ_Item",
                column: "MainAccount");

            migrationBuilder.CreateIndex(
                name: "IX_GJ_Item_MainTranx",
                schema: "Transactions",
                table: "GJ_Item",
                column: "MainTranx");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GJ_Item",
                schema: "Transactions");

            migrationBuilder.DropTable(
                name: "GeneralJournal",
                schema: "Transactions");
        }
    }
}
