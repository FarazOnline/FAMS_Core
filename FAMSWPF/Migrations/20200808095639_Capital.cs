using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class Capital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Capital");

            migrationBuilder.EnsureSchema(
                name: "CapitalContra");

            migrationBuilder.CreateTable(
                name: "Capital",
                schema: "Capital",
                columns: table => new
                {
                    CapId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyPerson = table.Column<string>(maxLength: 100, nullable: true),
                    BusinessName = table.Column<string>(maxLength: 100, nullable: true),
                    ShareRatio = table.Column<double>(nullable: false),
                    OwnerSince = table.Column<DateTime>(nullable: false),
                    CNIC = table.Column<string>(maxLength: 20, nullable: true),
                    NTN = table.Column<string>(maxLength: 20, nullable: true),
                    JobTitle = table.Column<string>(maxLength: 100, nullable: true),
                    PlotAddress = table.Column<string>(maxLength: 20, nullable: true),
                    StreetAddress = table.Column<string>(maxLength: 50, nullable: true),
                    RegionAddress = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    CellNumber = table.Column<string>(maxLength: 30, nullable: false),
                    ResidNumber = table.Column<string>(maxLength: 30, nullable: true),
                    WorkNumber = table.Column<string>(maxLength: 30, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capital", x => x.CapId);
                    table.ForeignKey(
                        name: "FK_Capital_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CapitalX",
                schema: "CapitalContra",
                columns: table => new
                {
                    CapXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccount = table.Column<int>(nullable: false),
                    MainCapital = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalX", x => x.CapXId);
                    table.ForeignKey(
                        name: "FK_CapitalX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_CapitalX_Capital_MainCapital",
                        column: x => x.MainCapital,
                        principalSchema: "Capital",
                        principalTable: "Capital",
                        principalColumn: "CapId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Capital_MainAccount",
                schema: "Capital",
                table: "Capital",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CapitalX_MainAcc",
                schema: "CapitalContra",
                table: "CapitalX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CapitalX_Capital",
                schema: "CapitalContra",
                table: "CapitalX",
                column: "MainCapital",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CapitalX",
                schema: "CapitalContra");

            migrationBuilder.DropTable(
                name: "Capital",
                schema: "Capital");
        }
    }
}
