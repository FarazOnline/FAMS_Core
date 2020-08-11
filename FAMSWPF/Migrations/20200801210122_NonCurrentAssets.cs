using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class NonCurrentAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NonCurrentAssets",
                schema: "Assets",
                columns: table => new
                {
                    AssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetName = table.Column<string>(maxLength: 100, nullable: false),
                    PurchDt = table.Column<DateTime>(nullable: false),
                    OriginalCost = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    LifeYears = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    New = table.Column<bool>(nullable: false),
                    Vendor = table.Column<string>(maxLength: 50, nullable: true),
                    DepreciationType = table.Column<string>(maxLength: 30, nullable: false),
                    DepreciationRate = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    ScrapValue = table.Column<decimal>(type: "decimal(26, 10)", nullable: false),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonCurrentAssets", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FurnitureFixtures",
                schema: "Assets",
                columns: table => new
                {
                    AssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 30, nullable: false),
                    Size = table.Column<string>(maxLength: 30, nullable: false),
                    Make = table.Column<string>(maxLength: 30, nullable: true),
                    MainNCA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FurnitureFixtures", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_FurnitureFixtures_NonCurrentAssets_MainNCA",
                        column: x => x.MainNCA,
                        principalSchema: "Assets",
                        principalTable: "NonCurrentAssets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachinesEquips",
                schema: "Assets",
                columns: table => new
                {
                    MachineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineTyp = table.Column<string>(maxLength: 20, nullable: false),
                    Manufacturer = table.Column<string>(maxLength: 50, nullable: false),
                    Make = table.Column<string>(maxLength: 50, nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    Capacity = table.Column<string>(maxLength: 50, nullable: true),
                    MainNCA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachinesEquips", x => x.MachineId);
                    table.ForeignKey(
                        name: "FK_MachinesEquips_NonCurrentAssets_MainNCA",
                        column: x => x.MainNCA,
                        principalSchema: "Assets",
                        principalTable: "NonCurrentAssets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherNonCurrent",
                schema: "Assets",
                columns: table => new
                {
                    AssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetType = table.Column<string>(maxLength: 50, nullable: false),
                    Manufacturer = table.Column<string>(maxLength: 100, nullable: false),
                    Details = table.Column<string>(maxLength: 100, nullable: true),
                    MainNCA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherNonCurrent", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_OtherNonCurrent_NonCurrentAssets_MainNCA",
                        column: x => x.MainNCA,
                        principalSchema: "Assets",
                        principalTable: "NonCurrentAssets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RealEstates",
                schema: "Assets",
                columns: table => new
                {
                    EstateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlotAddress = table.Column<string>(maxLength: 20, nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 50, nullable: false),
                    RegionAddress = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PostCode = table.Column<string>(maxLength: 10, nullable: false),
                    AreaSize = table.Column<string>(maxLength: 20, nullable: false),
                    MainNCA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealEstates", x => x.EstateId);
                    table.ForeignKey(
                        name: "FK_RealEstates_NonCurrentAssets_MainNCA",
                        column: x => x.MainNCA,
                        principalSchema: "Assets",
                        principalTable: "NonCurrentAssets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                schema: "Assets",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<string>(maxLength: 50, nullable: false),
                    Manufucturer = table.Column<string>(maxLength: 50, nullable: false),
                    Make = table.Column<string>(maxLength: 50, nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    Capacity = table.Column<string>(maxLength: 50, nullable: true),
                    RegNo = table.Column<string>(maxLength: 50, nullable: false),
                    MainNCA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_NonCurrentAssets_MainNCA",
                        column: x => x.MainNCA,
                        principalSchema: "Assets",
                        principalTable: "NonCurrentAssets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FurnitureFixtures_MainNCA",
                schema: "Assets",
                table: "FurnitureFixtures",
                column: "MainNCA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MachinesEquips_MainNCA",
                schema: "Assets",
                table: "MachinesEquips",
                column: "MainNCA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_MainAccount",
                schema: "Assets",
                table: "NonCurrentAssets",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherNonCurrent_MainNCA",
                schema: "Assets",
                table: "OtherNonCurrent",
                column: "MainNCA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RealEstates_MainNCA",
                schema: "Assets",
                table: "RealEstates",
                column: "MainNCA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_MainNCA",
                schema: "Assets",
                table: "Vehicles",
                column: "MainNCA",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FurnitureFixtures",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "MachinesEquips",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "OtherNonCurrent",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "RealEstates",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "Vehicles",
                schema: "Assets");

            migrationBuilder.DropTable(
                name: "NonCurrentAssets",
                schema: "Assets");
        }
    }
}
