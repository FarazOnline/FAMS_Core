using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class CurrentAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "TestSchema");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "TestSchema");

            migrationBuilder.DropColumn(
                name: "AccOpenDt",
                schema: "Assets",
                table: "BankAccounts");

            migrationBuilder.AddColumn<DateTime>(
                name: "OpeningDate",
                schema: "Assets",
                table: "BankAccounts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Advances",
                schema: "Assets",
                columns: table => new
                {
                    AdvanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose = table.Column<string>(maxLength: 100, nullable: false),
                    PaidUpto = table.Column<DateTime>(nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.AdvanceId);
                    table.ForeignKey(
                        name: "FK_Advances_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Debtors",
                schema: "Assets",
                columns: table => new
                {
                    DebtorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyPerson = table.Column<string>(maxLength: 100, nullable: false),
                    BusinessName = table.Column<string>(maxLength: 100, nullable: true),
                    Customer = table.Column<bool>(nullable: true),
                    CustomerSince = table.Column<DateTime>(nullable: true),
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
                    table.PrimaryKey("PK_Debtors", x => x.DebtorId);
                    table.ForeignKey(
                        name: "FK_Debtors_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinishedGoods",
                schema: "Assets",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    ItemCode = table.Column<string>(maxLength: 50, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 100, nullable: true),
                    QuantityUnit = table.Column<string>(maxLength: 50, nullable: false),
                    UnitSize = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    MinLevelUnits = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishedGoods", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_FinishedGoods_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiquidSecurity",
                schema: "Assets",
                columns: table => new
                {
                    SecurityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    Serials = table.Column<string>(maxLength: 30, nullable: false),
                    IssuingAuthority = table.Column<string>(maxLength: 100, nullable: false),
                    Since = table.Column<DateTime>(nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiquidSecurity", x => x.SecurityId);
                    table.ForeignKey(
                        name: "FK_LiquidSecurity_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherCurrent",
                schema: "Assets",
                columns: table => new
                {
                    AssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherCurrent", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_OtherCurrent_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                schema: "Assets",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    ItemCode = table.Column<string>(maxLength: 50, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 100, nullable: true),
                    QuantityUnit = table.Column<string>(maxLength: 50, nullable: false),
                    UnitSize = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    MinLevelUnits = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_RawMaterials_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkInProcess",
                schema: "Assets",
                columns: table => new
                {
                    WIPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkInProcess", x => x.WIPId);
                    table.ForeignKey(
                        name: "FK_WorkInProcess_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountsNatures",
                schema: "Foundation",
                table: "AccountNature",
                column: "NatureName");

            migrationBuilder.CreateIndex(
                name: "IX_Advances_MainAccount",
                schema: "Assets",
                table: "Advances",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Debtors_MainAccount",
                schema: "Assets",
                table: "Debtors",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FinishedGoods_MainAccount",
                schema: "Assets",
                table: "FinishedGoods",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LiquidSecurity_MainAccount",
                schema: "Assets",
                table: "LiquidSecurity",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherCurrent_MainAccount",
                schema: "Assets",
                table: "OtherCurrent",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_MainAccount",
                schema: "Assets",
                table: "RawMaterials",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkInProcess_MainAccount",
                schema: "Assets",
                table: "WorkInProcess",
                column: "MainAccount",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advances",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "Debtors",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "FinishedGoods",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "LiquidSecurity",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "OtherCurrent",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "RawMaterials",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "WorkInProcess",
                schema: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_AccountsNatures",
                schema: "Foundation",
                table: "AccountNature");

            migrationBuilder.DropColumn(
                name: "OpeningDate",
                schema: "Assets",
                table: "BankAccounts");

            migrationBuilder.EnsureSchema(
                name: "TestSchema");

            migrationBuilder.AddColumn<DateTime>(
                name: "AccOpenDt",
                schema: "Assets",
                table: "BankAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "TestSchema",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "TestSchema",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "TestSchema",
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryId_Test",
                schema: "TestSchema",
                table: "Products",
                column: "CategoryId");
        }
    }
}
