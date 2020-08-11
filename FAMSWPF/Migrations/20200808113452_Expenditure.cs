using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class Expenditure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ExpenditureContra");

            migrationBuilder.EnsureSchema(
                name: "Expenditure");

            migrationBuilder.CreateTable(
                name: "DirectLabour",
                schema: "Expenditure",
                columns: table => new
                {
                    DLId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Labourer = table.Column<string>(maxLength: 100, nullable: true),
                    LbrrAddress = table.Column<string>(maxLength: 100, nullable: true),
                    LbrrContact = table.Column<string>(maxLength: 30, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectLabour", x => x.DLId);
                    table.ForeignKey(
                        name: "FK_DirectLabour_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainCost",
                schema: "Expenditure",
                columns: table => new
                {
                    CostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostScheme = table.Column<string>(maxLength: 50, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCost", x => x.CostId);
                    table.ForeignKey(
                        name: "FK_MainCost_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherExpense",
                schema: "Expenditure",
                columns: table => new
                {
                    ExpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpScheme = table.Column<string>(maxLength: 50, nullable: true),
                    MainAccount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherExpense", x => x.ExpId);
                    table.ForeignKey(
                        name: "FK_OtherExpense_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainCostX",
                schema: "ExpenditureContra",
                columns: table => new
                {
                    CostXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccount = table.Column<int>(nullable: false),
                    MainCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCostX", x => x.CostXId);
                    table.ForeignKey(
                        name: "FK_MainCostX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_MainCostX_MainCost_MainCost",
                        column: x => x.MainCost,
                        principalSchema: "Expenditure",
                        principalTable: "MainCost",
                        principalColumn: "CostId");
                });

            migrationBuilder.CreateTable(
                name: "OtherExpenseX",
                schema: "ExpenditureContra",
                columns: table => new
                {
                    ExpXId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccount = table.Column<int>(nullable: false),
                    MainExpense = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherExpenseX", x => x.ExpXId);
                    table.ForeignKey(
                        name: "FK_OtherExpenseX_MainAccount_MainAccount",
                        column: x => x.MainAccount,
                        principalSchema: "Foundation",
                        principalTable: "MainAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_OtherExpenseX_OtherExpense_MainExpense",
                        column: x => x.MainExpense,
                        principalSchema: "Expenditure",
                        principalTable: "OtherExpense",
                        principalColumn: "ExpId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DirectLabour_MainAccount",
                schema: "Expenditure",
                table: "DirectLabour",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainCost_MainAccount",
                schema: "Expenditure",
                table: "MainCost",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherExpense_MainAccount",
                schema: "Expenditure",
                table: "OtherExpense",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainCostX_MainAcc",
                schema: "ExpenditureContra",
                table: "MainCostX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainCostX_Cost",
                schema: "ExpenditureContra",
                table: "MainCostX",
                column: "MainCost",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherExpX_MainAcc",
                schema: "ExpenditureContra",
                table: "OtherExpenseX",
                column: "MainAccount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherExpX_Expense",
                schema: "ExpenditureContra",
                table: "OtherExpenseX",
                column: "MainExpense",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirectLabour",
                schema: "Expenditure");

            migrationBuilder.DropTable(
                name: "MainCostX",
                schema: "ExpenditureContra");

            migrationBuilder.DropTable(
                name: "OtherExpenseX",
                schema: "ExpenditureContra");

            migrationBuilder.DropTable(
                name: "MainCost",
                schema: "Expenditure");

            migrationBuilder.DropTable(
                name: "OtherExpense",
                schema: "Expenditure");
        }
    }
}
