using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class Liabilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Liabilities");

            migrationBuilder.CreateTable(
                name: "Accruals",
                schema: "Liabilities",
                columns: table => new
                {
                    AccrualId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payee = table.Column<string>(maxLength: 50, nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accruals", x => x.AccrualId);
                    table.ForeignKey(
                        name: "FK_Accruals_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Creditors",
                schema: "Liabilities",
                columns: table => new
                {
                    CrId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyPerson = table.Column<string>(maxLength: 100, nullable: true),
                    BusinessName = table.Column<string>(maxLength: 100, nullable: true),
                    Supplier = table.Column<bool>(nullable: true),
                    Since = table.Column<DateTime>(nullable: true),
                    CNIC = table.Column<string>(maxLength: 20, nullable: true),
                    NTN = table.Column<string>(maxLength: 20, nullable: true),
                    JobTitle = table.Column<string>(maxLength: 50, nullable: true),
                    PlotAddress = table.Column<string>(maxLength: 20, nullable: true),
                    StreetAddress = table.Column<string>(maxLength: 50, nullable: true),
                    RegionAddress = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    CellNumber = table.Column<string>(maxLength: 30, nullable: true),
                    ResidNumber = table.Column<string>(maxLength: 30, nullable: true),
                    WorkNumber = table.Column<string>(maxLength: 30, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creditors", x => x.CrId);
                    table.ForeignKey(
                        name: "FK_Creditors_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                schema: "Liabilities",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Term = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    AnnualRate = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    Lender = table.Column<string>(maxLength: 50, nullable: true),
                    Purpose = table.Column<string>(maxLength: 50, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_Loans_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NonCurrent",
                schema: "Liabilities",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Term = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    AnnualRate = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    Lender = table.Column<string>(maxLength: 50, nullable: true),
                    Purpose = table.Column<string>(maxLength: 50, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonCurrent", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_NonCurrent_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnearnedIncomes",
                schema: "Liabilities",
                columns: table => new
                {
                    UIncId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Income = table.Column<string>(maxLength: 50, nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnearnedIncomes", x => x.UIncId);
                    table.ForeignKey(
                        name: "FK_UnearnedIncomes_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accruals_MainAccount",
                schema: "Liabilities",
                table: "Accruals",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Creditors_MainAccount",
                schema: "Liabilities",
                table: "Creditors",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_MainAccount",
                schema: "Liabilities",
                table: "Loans",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrent_MainAccount",
                schema: "Liabilities",
                table: "NonCurrent",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnearnedIncomes_MainAccount",
                schema: "Liabilities",
                table: "UnearnedIncomes",
                column: "MainAccount",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accruals",
                schema: "Liabilities");

            migrationBuilder.DropTable(
                name: "Creditors",
                schema: "Liabilities");

            migrationBuilder.DropTable(
                name: "Loans",
                schema: "Liabilities");

            migrationBuilder.DropTable(
                name: "NonCurrent",
                schema: "Liabilities");

            migrationBuilder.DropTable(
                name: "UnearnedIncomes",
                schema: "Liabilities");
        }
    }
}
